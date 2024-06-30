using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class TriangType : Element
    {
        public TriangType(IOnClickStrategies OnClickStrategie) : base(OnClickStrategie)
        {
            this.BackColor = Color.White;
            personalBehaviorTimer.Interval = 3000;
            personalBehaviorTimer.Tick += PersonalBehaviorTimer_Tick;
        }

        public override void Behave()
        {
            if (isMovingFoword)
            {
                this.Top -= SPEED;
                this.Left -= SPEED;
                if (this.Top <= 0 || this.Left <= 0)
                {
                    isMovingFoword = false;
                }
            }
            else
            {
                this.Top += SPEED;
                this.Left += SPEED;
                if (this.Top + this.Height >= MARGINED_WINDOW_SIZE.Height || this.Left+this.Width>= MARGINED_WINDOW_SIZE.Width)
                {
                    isMovingFoword = true;
                }
            }
        }

        //public override void PreformClick()
        //{
        //    new CollectStrategy().Invoke(this);
        //}

        private void PersonalBehaviorTimer_Tick(object? sender, EventArgs e)
        {
            isMovingFoword=!isMovingFoword;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            Point[] p = new Point[3];
            p[0] = new Point(0, 0);
            p[1] = new Point(1000, 1000);
            p[2] = new Point(0, 2000);
            graphics.AddPolygon(p);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }

    }
}
