using GameLogic;

namespace GameUI
{
    public partial class WinGameForm : Form
    {
        public WinGameForm()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please Enter A Name.");
                return;
            }
            GameEngine.Instance.WinGame(NameTextBox.Text);

            this.Visible = false;
            this.Dispose();
        }
    }
}
