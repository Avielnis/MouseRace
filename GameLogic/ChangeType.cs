using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class ChangeType : Element
    {
        float angle = 0;
        private Color currentColor;

        public ChangeType()
        {
            currentColor = Color.Green;
            FlatAppearance.MouseDownBackColor = Color.Transparent;
            FlatAppearance.MouseOverBackColor = Color.Transparent;

            personalBehaviorTimer.Interval = random.Next(2, 5) * 1000;// random interval
            personalBehaviorTimer.Tick += PersonalBehaeviorTimer_Tick;
        }

        private void PersonalBehaeviorTimer_Tick(object? sender, EventArgs e)
        {
            if (isCollect())
            {
                currentColor = Color.Red;
            }
            else
            {
                currentColor = Color.Green;
            }

            personalBehaviorTimer.Interval = random.Next(2, 5) * 1000;
        }

        private bool isCollect()
        {
            return currentColor == Color.Green;
        }
        public override void Behave()
        {

            angle += SPEED;
            if (angle >= 360)
            {
                angle = 0;
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;


            e.Graphics.TranslateTransform(Width / 2, Height / 2);
            e.Graphics.RotateTransform(angle);
            e.Graphics.TranslateTransform(-Width / 2, -Height / 2);



            using (SolidBrush brush = new SolidBrush(currentColor))
            {
                e.Graphics.FillRectangle(brush, new Rectangle(0, 0, Width, Height));
            }
        }

        public override void PreformClick()
        {
            if (isCollect())
            {
                new CollectStrategy().Invoke(this);
                return;
            }
            new AvoidStrategy().Invoke(this);
        }

    }
}
