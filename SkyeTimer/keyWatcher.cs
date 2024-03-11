using System.Diagnostics;
using System.Runtime.InteropServices;
namespace SkyeTimer
{
    public partial class KeyboardHook : IDisposable
    {
        private static IntPtr _hookId;
        private static readonly List<KeyboardHook> HooksObjects = new List<KeyboardHook>();
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(int vKey);
        private readonly Dictionary<int, Action<KeyEventArgs>> keyDownHandlers = new Dictionary<int, Action<KeyEventArgs>>();
        private readonly Dictionary<int, Action<KeyEventArgs>> keyUpHandlers = new Dictionary<int, Action<KeyEventArgs>>();

        public KeyboardHook()
        {
            OnCreateKeyboardHook(this);
        }

        public KeyboardHook(Form form)
        {
            OnCreateKeyboardHook(this);

            form.Closed += (sender, e) => this.Dispose();
        }

        public event EventHandler<KeyEventArgs> KeyDownGlobal;
        public event EventHandler<KeyEventArgs> KeyUpGlobal;

        public void RegisterHotKey(Keys key, Action<KeyEventArgs> onKeyDown, Action<KeyEventArgs> onKeyUp)
        {
            var keyCode = (int)key;
            keyDownHandlers[keyCode] = onKeyDown;
            keyUpHandlers[keyCode] = onKeyUp;
        }

        public void Dispose()
        {
            HooksObjects.Remove(this);

            if (HooksObjects.Count == 0)
            {
                UnhookWindowsHookEx(_hookId);
            }
        }

        private static void OnCreateKeyboardHook(KeyboardHook obj)
        {
            if (HooksObjects.Count == 0)
            {
                _hookId = SetHook(KeyboardProc);
            }

            HooksObjects.Add(obj);
        }
        public static bool IsShiftPressed()
        {
            return (Control.ModifierKeys & Keys.Shift) != 0;
        }

        public static bool IsKeyPressed(Keys key)
        {
            return (GetAsyncKeyState((int)key) & 0x8000) != 0;
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            using (var curProcess = Process.GetCurrentProcess())
            using (var curModule = curProcess.MainModule)
            {
                var modHandle = GetModuleHandle(curModule.ModuleName);
                return SetWindowsHookEx(WH_KEYBOARD_LL, proc, modHandle, 0);
            }
        }

        private static readonly LowLevelKeyboardProc KeyboardProc = HookCallback;

        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        private const int WH_KEYBOARD_LL = 13;
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private const int WM_SYSKEYDOWN = 0x0104;
        private const int WM_SYSKEYUP = 0x0105;

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                var keyDown = wParam == (IntPtr)WM_KEYDOWN || wParam == (IntPtr)WM_SYSKEYDOWN;
                var keyUp = wParam == (IntPtr)WM_KEYUP || wParam == (IntPtr)WM_SYSKEYUP;

                if (keyDown || keyUp)
                {
                    var kbd = (KBDLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));
                    var keyCode = (int)kbd.vkCode;

                    var e = new KeyEventArgs((Keys)keyCode);

                    foreach (var hookObject in HooksObjects)
                    {
                        if (keyDown && hookObject.keyDownHandlers.TryGetValue(keyCode, out var keyDownHandler))
                        {
                            keyDownHandler?.Invoke(e);
                        }
                        else if (keyUp && hookObject.keyUpHandlers.TryGetValue(keyCode, out var keyUpHandler))
                        {
                            keyUpHandler?.Invoke(e);
                        }
                    }

                    if (keyDown && HooksObjects.Any(hookObject => hookObject.KeyDownGlobal != null))
                    {
                        foreach (var hookObject in HooksObjects)
                        {
                            hookObject.KeyDownGlobal?.Invoke(hookObject, e);
                        }
                    }

                    if (keyUp && HooksObjects.Any(hookObject => hookObject.KeyUpGlobal != null))
                    {
                        foreach (var hookObject in HooksObjects)
                        {
                            hookObject.KeyUpGlobal?.Invoke(hookObject, e);
                        }
                    }
                }
            }

            return CallNextHookEx(_hookId, nCode, wParam, lParam);
        }

        [StructLayout(LayoutKind.Sequential)]
        public class KBDLLHOOKSTRUCT
        {
            public uint vkCode;
            public uint scanCode;
            public KBDLLHOOKSTRUCTFlags flags;
            public uint time;
            public UIntPtr dwExtraInfo;
        }

        [Flags]
        public enum KBDLLHOOKSTRUCTFlags : uint
        {
            LLKHF_EXTENDED = 0x01,
            LLKHF_INJECTED = 0x10,
            LLKHF_ALTDOWN = 0x20,
            LLKHF_UP = 0x80,
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod,
            uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}
