using GameUI;

namespace GameUI
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            CollectedCountLable = new Label();
            TimerLable = new Label();
            SuspendLayout();
            // 
            // CollectedCountLable
            // 
            CollectedCountLable.Anchor = AnchorStyles.Top;
            CollectedCountLable.AutoSize = true;
            CollectedCountLable.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CollectedCountLable.Location = new Point(12, 9);
            CollectedCountLable.Name = "CollectedCountLable";
            CollectedCountLable.Size = new Size(95, 22);
            CollectedCountLable.TabIndex = 0;
            CollectedCountLable.Text = "Collected: 0";
            // 
            // TimerLable
            // 
            TimerLable.Anchor = AnchorStyles.Top;
            TimerLable.AutoSize = true;
            TimerLable.Font = new Font("Bernard MT Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TimerLable.Location = new Point(12, 41);
            TimerLable.Name = "TimerLable";
            TimerLable.Size = new Size(51, 22);
            TimerLable.TabIndex = 1;
            TimerLable.Text = "00:00";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(720, 450);
            Controls.Add(TimerLable);
            Controls.Add(CollectedCountLable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "GameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mouse Race";
            Load += GameForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CollectedCountLable;
        private Label TimerLable;
    }
}
