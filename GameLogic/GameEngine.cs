using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class GameEngine
    {
        private static readonly GameEngine instance = new GameEngine();


        private int numCollect;
        private int numAvoid;
        private int numChange;
        private int collectCount;
        private int changeCount;
        public long ElapsedTime { get; set; }
        private List<Element> elements;
        public Size WindowSize { get; }
        private bool playerLose;



        private GameEngine()
        {
            Rectangle screenBounds = Screen.PrimaryScreen.Bounds;
            int screenWidth = screenBounds.Width;
            int screenHeight = screenBounds.Height;
            WindowSize = new Size(screenWidth / 2, screenHeight / 2);

            InitNumbers();

        }

        private void InitNumbers()
        {
            Random random = new Random();

            numCollect = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            numAvoid = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);
            numChange = random.Next(Config.MIN_ELEMENTS_EACH, Config.MAX_ELEMENTS_EACH);

            collectCount = 0;
            changeCount = 0;
        }

        public static GameEngine Instance
        {
            get
            {
                return instance;
            }
        }

        public int Speed
        {
            get
            {
                return Config.SPEED;
            }
        }
        public int MaxSize
        {
            get
            {
                return Config.MAX_ELEMENT_SIZE;
            }
        }
        public void AddCollected(Element element)
        {
            if (element is CollectType)
            {
                collectCount++;

            }
            else
            {
                changeCount++;
            }
        }

        public int CollectedCount
        {
            get
            {
                return collectCount + changeCount;
            }
        }

        public bool PlayerLost
        {
            get
            {
                return playerLose;
            }
        }

        public string GetElapsedTimeString()
        {
            return GetElapsedTimeString(ElapsedTime);
        }


        public string GetElapsedTimeString(long time)
        {
            long minutes = time / 60000;
            long seconds = (time % 60000) / 1000;
            long milliseconds = time % 1000;

            return string.Format("{0:D2}:{1:D2}:{2:D3}", minutes, seconds, milliseconds);
        }


        public void InitElements()
        {
            elements = new List<Element>();
            int i = 0;
            while (i < numCollect || i < numAvoid || i < numChange)
            {
                if (i < numCollect)
                {
                    elements.Add(new CollectType());
                }
                if (i < numAvoid)
                {
                    elements.Add(new AvoidType());
                }
                if (i < numChange)
                {
                    elements.Add(new ChangeType());
                }
                i++;
            }
        }

        public List<Element> Elements
        {

            get
            {
                if (elements == null)
                {
                    InitElements();
                }
                return elements;
            }
        }


        public bool isGameEnded()
        {
            return collectCount + changeCount == numChange + numCollect || playerLose;
        }
        public void LoseGame()
        {
            playerLose = true;

        }

        public void WinGame(string playerName)
        {
            LeaderBoardConnection leaderBoard = new LeaderBoardConnection();
            leaderBoard.AddToBoard(playerName, ElapsedTime);
        }


    }

}
