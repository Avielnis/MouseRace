
using GameLogic;

namespace GameUI
{
    public partial class LeaderBoardForm : Form
    {
        private LeaderBoardConnection leaderBoard;
        public LeaderBoardForm()
        {
            InitializeComponent();
            leaderBoard = new LeaderBoardConnection();
            LoadLeaderBoard();
        }

        private void LoadLeaderBoard()
        {

            dataGridViewLeaderboard.Rows.Clear();


            var data = leaderBoard.GetLeaderBoard();

            foreach (var entry in data)
            {
                dataGridViewLeaderboard.Rows.Add(entry.Name, GameEngine.Instance.GetElapsedTimeString(entry.Time));
            }
        }
    }
}
