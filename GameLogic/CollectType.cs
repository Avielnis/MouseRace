﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    internal class CollectType : Element
    {
        private const int TWO_SECONDS = 2000;

        public CollectType() {
            this.BackColor = Color.Green;
            this.Size = new Size(this.Width + 10, this.Height - 5); // make a rectengle
            personalBehaviorTimer.Interval = TWO_SECONDS;
            personalBehaviorTimer.Tick += PersonalBehaeviorTimer_Tick;
        }

        private void PersonalBehaeviorTimer_Tick(object? sender, EventArgs e)
        {
            isMovingFoword = !isMovingFoword;
        }

        public override void Behave()
        {
            if(isMovingFoword)
            {
                this.Top -= speed;
                if (this.Top <= 0)
                {
                    isMovingFoword = false;
                }
            }
            else
            {
                this.Top += speed;
                if (this.Top +this.Height >= MARGINED_WINDOW_SIZE.Height)
                {
                    isMovingFoword = true;
                }
            }
        }

        public override void PreformClick()
        {
            new CollectStrategy().Invoke(this);
        }
    }
}
