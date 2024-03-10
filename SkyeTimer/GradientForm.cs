namespace SkyeTimer
{
    public enum GradientType
    {
        Horizontal,
        Vertical,
        ForwardDiagonal,
        BackwardDiagonal
    }

    public class GradientForm : Form
    {
        private RadioButton horizontalRadioButton;
        private RadioButton verticalRadioButton;
        private RadioButton forwardDiagonalRadioButton;
        private RadioButton backwardDiagonalRadioButton;
        private Button okButton;

        public GradientType SelectedGradient { get; private set; }

        public GradientForm()
        {
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            this.Text = "Select Gradient Type";
            this.Size = new Size(350, 200);

            horizontalRadioButton = new RadioButton
            {
                Text = "Horizontal",
                Location = new Point(20, 20)
            };

            verticalRadioButton = new RadioButton
            {
                Text = "Vertical",
                Location = new Point(20, 50)
            };

            forwardDiagonalRadioButton = new RadioButton
            {
                Text = "Forward Diagonal",
                Location = new Point(20, 80)
            };

            backwardDiagonalRadioButton = new RadioButton
            {
                Text = "Backward Diagonal",
                Location = new Point(20, 110)
            };

            okButton = new Button
            {
                Text = "OK",
                Location = new Point(120, 140)
            };
            okButton.Click += OkButton_Click;

            this.Controls.Add(horizontalRadioButton);
            this.Controls.Add(verticalRadioButton);
            this.Controls.Add(forwardDiagonalRadioButton);
            this.Controls.Add(backwardDiagonalRadioButton);
            this.Controls.Add(okButton);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            SelectedGradient = GetSelectedGradient();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private GradientType GetSelectedGradient()
        {
            if (horizontalRadioButton.Checked)
                return GradientType.Horizontal;
            else if (verticalRadioButton.Checked)
                return GradientType.Vertical;
            else if (forwardDiagonalRadioButton.Checked)
                return GradientType.ForwardDiagonal;
            else if (backwardDiagonalRadioButton.Checked)
                return GradientType.BackwardDiagonal;
            else
                throw new InvalidOperationException("No gradient type selected.");
        }
    }
}
