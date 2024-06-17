using GameLogic;

namespace GameUI
{
    public partial class GameForm : Form
    {
        private List<Element> elements;

        private CancellationTokenSource cts;
        private Task timerTask;


        public GameForm()
        {
            InitializeComponent();
            InitElements();

        }
        private void GameForm_Load(object sender, EventArgs e)
        {
            StartTimer();
        }

        private void InitElements()
        {
            this.Controls.AddRange(GameEngine.Instance.Elements.ToArray());
            foreach (Element element in GameEngine.Instance.Elements)
            {
                element.Click += Element_Click;
            }

        }

        private void Element_Click(object? sender, EventArgs e)
        {
            (sender as Element).PreformClick();
            CollectedCountLable.Text = string.Format("Collected {0}", GameEngine.Instance.CollectedCount.ToString());
            
            if (GameEngine.Instance.isGameEnded())
            {
                EndGame();
            }   
        }

        private void EndGame()
        {
            if (GameEngine.Instance.PlayerLost)
            {
                MessageBox.Show("You clicked RED!, better luck next time.");
            }
            else
            {
                WinGameForm winGameForm = new WinGameForm();
                this.Visible = false;
                winGameForm.ShowDialog();
            }

            LeaderBoardForm leaderBoardForm = new LeaderBoardForm();
            Dispose();
            leaderBoardForm.ShowDialog();
        }


        private void StartTimer()
        {
            cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;

            timerTask = Task.Run(() => TimerLoop(token), token);
        }

        private void TimerLoop(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {

                GameEngine.Instance.ElapsedTime += 100;

                string time = GameEngine.Instance.GetElapsedTimeString();
                this.Invoke((Action)(() => TimerLable.Text = time));
                Thread.Sleep(100);
            }
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            cts.Cancel();
            cts.Dispose();
            base.OnFormClosing(e);
        }
    }
}
