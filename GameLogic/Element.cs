using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLogic
{
    public abstract class Element : Button
    {

        protected bool isMovingFoword;
        protected System.Windows.Forms.Timer movingTimer;
        protected System.Windows.Forms.Timer personalBehaviorTimer;
        protected IOnClickStrategies onClickStrategie;

        protected Random random = new Random();

       
        protected readonly int SPEED = GameEngine.Instance.Speed;
        private static readonly int MAX_SIZE = GameEngine.Instance.MaxSize;
        protected static readonly Size MARGINED_WINDOW_SIZE = new Size(GameEngine.Instance.WindowSize.Width - MAX_SIZE, GameEngine.Instance.WindowSize.Height - MAX_SIZE);


        public Element(IOnClickStrategies onClickStrategie) : base()
        {
            isMovingFoword = true;
            this.onClickStrategie = onClickStrategie;
            setTimers();

            styleElement();

        }
        private void styleElement()
        {
            this.Location = new Point(random.Next(0, MARGINED_WINDOW_SIZE.Width), random.Next(MARGINED_WINDOW_SIZE.Height));
            int size = random.Next(30, MAX_SIZE);
            this.Size = new Size(size, size);
            this.UseVisualStyleBackColor = true;

            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
            BackColor = Color.Transparent;
        }
        protected void setTimers()
        {
            movingTimer = new System.Windows.Forms.Timer();
            movingTimer.Enabled = true;
            movingTimer.Interval = 50;
            movingTimer.Tick += MovingTime_Tick;

            personalBehaviorTimer = new System.Windows.Forms.Timer();
            personalBehaviorTimer.Enabled = true;


        }

        private void MovingTime_Tick(object? sender, EventArgs e)
        {
            this.Behave();
        }

        public IOnClickStrategies OnClickStrategie
        {
            set { this.OnClickStrategie = value; }
        }

        public abstract void Behave();


        public virtual void PreformClick()
        {
            onClickStrategie.Invoke(this);
        }
    }
}
