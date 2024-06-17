namespace GameUI
{
    partial class StartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            StartButton = new Button();
            TitleLable = new Label();
            SuspendLayout();
            // 
            // StartButton
            // 
            StartButton.BackColor = Color.SteelBlue;
            StartButton.FlatAppearance.BorderSize = 0;
            StartButton.FlatStyle = FlatStyle.Flat;
            StartButton.Font = new Font("Aharoni", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            StartButton.ForeColor = SystemColors.ButtonFace;
            StartButton.Location = new Point(143, 70);
            StartButton.Name = "StartButton";
            StartButton.Size = new Size(75, 23);
            StartButton.TabIndex = 0;
            StartButton.Text = "Start!";
            StartButton.UseVisualStyleBackColor = true;
            StartButton.Click += StartButton_Click;
            // 
            // TitleLable
            // 
            TitleLable.Anchor = AnchorStyles.Top;
            TitleLable.AutoSize = true;
            TitleLable.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLable.ForeColor = Color.LightSkyBlue;
            TitleLable.Location = new Point(100, 19);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(167, 39);
            TitleLable.TabIndex = 1;
            TitleLable.Text = "Mouse Race";
            TitleLable.UseMnemonic = false;
            // 
            // StartForm
            // 
            AcceptButton = StartButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 128);
            Controls.Add(TitleLable);
            Controls.Add(StartButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button StartButton;
        private Label TitleLable;
    }
}