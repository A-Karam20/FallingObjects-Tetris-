namespace FallingObjects
{
    partial class Game
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
            Box = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            PlayAgain = new Button();
            Over = new TextBox();
            NextBox = new TableLayoutPanel();
            score_ = new TextBox();
            Score = new TextBox();
            NextShape = new TextBox();
            highscore_ = new TextBox();
            HighScore = new TextBox();
            Box.SuspendLayout();
            SuspendLayout();
            // 
            // Box
            // 
            Box.BackColor = Color.White;
            Box.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            Box.ColumnCount = 10;
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            Box.Controls.Add(tableLayoutPanel2, 1, 1);
            Box.ForeColor = SystemColors.Desktop;
            Box.Location = new Point(229, 12);
            Box.Name = "Box";
            Box.RowCount = 20;
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            Box.Size = new Size(254, 403);
            Box.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Location = new Point(29, 24);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(8, 8);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // PlayAgain
            // 
            PlayAgain.Font = new Font("Sitka Small", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PlayAgain.Location = new Point(34, 159);
            PlayAgain.Name = "PlayAgain";
            PlayAgain.Size = new Size(159, 37);
            PlayAgain.TabIndex = 3;
            PlayAgain.Text = "Play again";
            PlayAgain.UseVisualStyleBackColor = true;
            PlayAgain.Visible = false;
            PlayAgain.Click += PlayAgain_Click;
            // 
            // Over
            // 
            Over.BackColor = Color.LightGray;
            Over.BorderStyle = BorderStyle.None;
            Over.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point);
            Over.Location = new Point(19, 116);
            Over.Name = "Over";
            Over.ReadOnly = true;
            Over.Size = new Size(189, 37);
            Over.TabIndex = 3;
            Over.Text = "Game Over";
            Over.TextAlign = HorizontalAlignment.Center;
            Over.Visible = false;
            // 
            // NextBox
            // 
            NextBox.ColumnCount = 3;
            NextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            NextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            NextBox.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            NextBox.Location = new Point(598, 175);
            NextBox.Name = "NextBox";
            NextBox.RowCount = 4;
            NextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NextBox.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            NextBox.Size = new Size(130, 89);
            NextBox.TabIndex = 2;
            // 
            // score_
            // 
            score_.BackColor = SystemColors.Info;
            score_.BorderStyle = BorderStyle.None;
            score_.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            score_.Location = new Point(67, 40);
            score_.Name = "score_";
            score_.ReadOnly = true;
            score_.Size = new Size(84, 32);
            score_.TabIndex = 4;
            score_.TabStop = false;
            score_.Text = "Score:";
            score_.TextAlign = HorizontalAlignment.Center;
            // 
            // Score
            // 
            Score.BackColor = SystemColors.Info;
            Score.BorderStyle = BorderStyle.None;
            Score.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            Score.Location = new Point(67, 78);
            Score.Name = "Score";
            Score.ReadOnly = true;
            Score.Size = new Size(84, 32);
            Score.TabIndex = 5;
            Score.TabStop = false;
            Score.Text = "0";
            Score.TextAlign = HorizontalAlignment.Center;
            // 
            // NextShape
            // 
            NextShape.BackColor = SystemColors.Info;
            NextShape.BorderStyle = BorderStyle.None;
            NextShape.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NextShape.Location = new Point(610, 147);
            NextShape.Name = "NextShape";
            NextShape.ReadOnly = true;
            NextShape.Size = new Size(106, 22);
            NextShape.TabIndex = 6;
            NextShape.TabStop = false;
            NextShape.Text = "Next Shape:";
            NextShape.TextAlign = HorizontalAlignment.Center;
            // 
            // highscore_
            // 
            highscore_.BackColor = SystemColors.Info;
            highscore_.BorderStyle = BorderStyle.None;
            highscore_.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            highscore_.Location = new Point(598, 40);
            highscore_.Name = "highscore_";
            highscore_.ReadOnly = true;
            highscore_.Size = new Size(153, 32);
            highscore_.TabIndex = 7;
            highscore_.TabStop = false;
            highscore_.Text = "High Score:";
            highscore_.TextAlign = HorizontalAlignment.Center;
            // 
            // HighScore
            // 
            HighScore.BackColor = SystemColors.Info;
            HighScore.BorderStyle = BorderStyle.None;
            HighScore.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            HighScore.Location = new Point(623, 78);
            HighScore.Name = "HighScore";
            HighScore.ReadOnly = true;
            HighScore.Size = new Size(84, 32);
            HighScore.TabIndex = 8;
            HighScore.TabStop = false;
            HighScore.Text = "0";
            HighScore.TextAlign = HorizontalAlignment.Center;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(HighScore);
            Controls.Add(highscore_);
            Controls.Add(NextShape);
            Controls.Add(PlayAgain);
            Controls.Add(Score);
            Controls.Add(Over);
            Controls.Add(NextBox);
            Controls.Add(Box);
            Controls.Add(score_);
            Name = "Game";
            Text = "Game";
            Load += Game_Load;
            Box.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel Box;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel NextBox;
        private TextBox Over;
        private Button PlayAgain;
        private TextBox score_;
        private TextBox Score;
        private TextBox NextShape;
        private TextBox highscore_;
        private TextBox HighScore;
    }
}