
using GameLogic;

namespace GameUI
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Visible = false;
            gameForm.ShowDialog();
            this.Dispose();
        }
    }
}
