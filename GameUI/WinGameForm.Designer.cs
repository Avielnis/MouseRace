using System.Resources;

namespace GameUI
{
    partial class WinGameForm
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
            TitleLable = new Label();
            NameLable = new Label();
            NameTextBox = new TextBox();
            SubmitButton = new Button();
            SuspendLayout();
            // 
            // TitleLable
            // 
            TitleLable.Anchor = AnchorStyles.Top;
            TitleLable.AutoSize = true;
            TitleLable.Font = new Font("Bahnschrift SemiCondensed", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TitleLable.ForeColor = Color.LightSkyBlue;
            TitleLable.Location = new Point(120, 9);
            TitleLable.Name = "TitleLable";
            TitleLable.Size = new Size(114, 39);
            TitleLable.TabIndex = 2;
            TitleLable.Text = "Winner!";
            TitleLable.UseMnemonic = false;
            // 
            // NameLable
            // 
            NameLable.AutoSize = true;
            NameLable.Location = new Point(28, 57);
            NameLable.Name = "NameLable";
            NameLable.Size = new Size(42, 15);
            NameLable.TabIndex = 3;
            NameLable.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(73, 54);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(268, 23);
            NameTextBox.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.SteelBlue;
            SubmitButton.FlatAppearance.BorderSize = 0;
            SubmitButton.FlatStyle = FlatStyle.Flat;
            SubmitButton.Font = new Font("Aharoni", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.ForeColor = SystemColors.ButtonFace;
            SubmitButton.Location = new Point(266, 93);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(75, 23);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // WinGameForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(373, 128);
            ControlBox = false;
            Controls.Add(SubmitButton);
            Controls.Add(NameTextBox);
            Controls.Add(NameLable);
            Controls.Add(TitleLable);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "WinGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinGameForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TitleLable;
        private Label NameLable;
        private TextBox NameTextBox;
        private Button SubmitButton;
    }
}