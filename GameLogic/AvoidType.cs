﻿using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    internal class AvoidType : Element
    {
        private const int THREE_SECONDS = 3000;
        public AvoidType()
        {
            this.BackColor = Color.Red;
            personalBehaviorTimer.Interval = THREE_SECONDS;
            personalBehaviorTimer.Tick += PersonalTimer_Tick;
        }

        private void PersonalTimer_Tick(object? sender, EventArgs e)
        {
            isMovingFoword = !isMovingFoword;
        }

        public override void Behave()
        {
            if (isMovingFoword)
            {
                this.Left += speed;

                if (this.Left + this.Width >= MARGINED_WINDOW_SIZE.Width)
                {
                    isMovingFoword = false;
                }
            }
            else
            {
                this.Left -= speed;
                if (this.Left <= 0)
                {
                    isMovingFoword = true;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, this.Width,this.Height);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pevent);
        }

        public override void PreformClick()
        {
            new AvoidStrategy().Invoke(this);
        }
    }
}

