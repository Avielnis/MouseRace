namespace GameUI
{
    partial class LeaderBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderBoardForm));
            dataGridViewLeaderboard = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaderboard).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewLeaderboard
            // 
            dataGridViewLeaderboard.AllowUserToAddRows = false;
            dataGridViewLeaderboard.AllowUserToDeleteRows = false;
            dataGridViewLeaderboard.AllowUserToResizeColumns = false;
            dataGridViewLeaderboard.AllowUserToResizeRows = false;
            dataGridViewLeaderboard.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewLeaderboard.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLeaderboard.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            dataGridViewLeaderboard.Dock = DockStyle.Fill;
            dataGridViewLeaderboard.Location = new Point(0, 0);
            dataGridViewLeaderboard.Name = "dataGridViewLeaderboard";
            dataGridViewLeaderboard.Size = new Size(244, 107);
            dataGridViewLeaderboard.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Name";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Time";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // LeaderBoardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(244, 107);
            Controls.Add(dataGridViewLeaderboard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "LeaderBoardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Leader Board";
            ((System.ComponentModel.ISupportInitialize)dataGridViewLeaderboard).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewLeaderboard;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}