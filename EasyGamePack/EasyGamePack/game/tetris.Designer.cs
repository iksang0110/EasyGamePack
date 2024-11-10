namespace TetrisGame
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();

            // 컨트롤 초기화
            this.panelGame = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.panelNextBlock = new System.Windows.Forms.Panel();
            this.labelNextBlock = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelLines = new System.Windows.Forms.Label();
            this.labelControls = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelGameOver = new System.Windows.Forms.Label();
            this.labelPaused = new System.Windows.Forms.Label();

            // 패널에 컨트롤 추가
            this.panelInfo.SuspendLayout();

            // panelGame
            this.panelGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGame.Location = new System.Drawing.Point(20, 20);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(400, 640); // 높이를 640으로 조정
            this.panelGame.TabIndex = 0;
            this.panelGame.Margin = new System.Windows.Forms.Padding(0);
            this.panelGame.Padding = new System.Windows.Forms.Padding(0);

            // panelInfo
            this.panelInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Location = new System.Drawing.Point(440, 20);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(240, 640);
            this.panelInfo.TabIndex = 1;
            this.panelInfo.Padding = new System.Windows.Forms.Padding(10);

            // labelNextBlock
            this.labelNextBlock.AutoSize = true;
            this.labelNextBlock.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.labelNextBlock.ForeColor = System.Drawing.Color.White;
            this.labelNextBlock.Location = new System.Drawing.Point(20, 10);
            this.labelNextBlock.Name = "labelNextBlock";
            this.labelNextBlock.Size = new System.Drawing.Size(90, 21);
            this.labelNextBlock.TabIndex = 0;
            this.labelNextBlock.Text = "다음 블록";

            // panelNextBlock
            this.panelNextBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(46)))));
            this.panelNextBlock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNextBlock.Location = new System.Drawing.Point(45, 40);
            this.panelNextBlock.Name = "panelNextBlock";
            this.panelNextBlock.Size = new System.Drawing.Size(150, 150);
            this.panelNextBlock.TabIndex = 1;

            // labelScore
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.labelScore.ForeColor = System.Drawing.Color.White;
            this.labelScore.Location = new System.Drawing.Point(20, 200);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(90, 21);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "점수: 0";

            // labelLevel
            this.labelLevel.AutoSize = true;
            this.labelLevel.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.labelLevel.ForeColor = System.Drawing.Color.White;
            this.labelLevel.Location = new System.Drawing.Point(20, 230);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(90, 21);
            this.labelLevel.TabIndex = 3;
            this.labelLevel.Text = "레벨: 1";

            // labelLines
            this.labelLines.AutoSize = true;
            this.labelLines.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.labelLines.ForeColor = System.Drawing.Color.White;
            this.labelLines.Location = new System.Drawing.Point(20, 260);
            this.labelLines.Name = "labelLines";
            this.labelLines.Size = new System.Drawing.Size(90, 21);
            this.labelLines.TabIndex = 4;
            this.labelLines.Text = "줄 수: 0";

            // labelControls
            this.labelControls.AutoSize = true;
            this.labelControls.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.labelControls.ForeColor = System.Drawing.Color.White;
            this.labelControls.Location = new System.Drawing.Point(20, 300);
            this.labelControls.Name = "labelControls";
            this.labelControls.Size = new System.Drawing.Size(160, 140);
            this.labelControls.TabIndex = 5;
            this.labelControls.Text = "조작 방법:\n\n← → : 이동\n↑ : 회전\n↓ : 천천히 내리기\n스페이스바: 바로 내리기\nP: 일시정지\nESC: 종료";

            // buttonPause
            this.buttonPause.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.buttonPause.ForeColor = System.Drawing.Color.White;
            this.buttonPause.Location = new System.Drawing.Point(45, 500);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(150, 40);
            this.buttonPause.TabIndex = 6;
            this.buttonPause.Text = "일시정지";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);

            // buttonRestart
            this.buttonRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(204)))), ((int)(((byte)(163)))));
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(45, 550);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(150, 40);
            this.buttonRestart.TabIndex = 7;
            this.buttonRestart.Text = "다시 시작";
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Visible = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);

            // labelGameOver
            this.labelGameOver.AutoSize = false;
            this.labelGameOver.BackColor = System.Drawing.Color.Transparent;
            this.labelGameOver.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.labelGameOver.ForeColor = System.Drawing.Color.Red;
            this.labelGameOver.Location = new System.Drawing.Point(120, 300);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(200, 45);
            this.labelGameOver.TabIndex = 8;
            this.labelGameOver.Text = "게임 오버!";
            this.labelGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelGameOver.Visible = false;

            // labelPaused
            this.labelPaused.AutoSize = false;
            this.labelPaused.BackColor = System.Drawing.Color.Transparent;
            this.labelPaused.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold);
            this.labelPaused.ForeColor = System.Drawing.Color.Yellow;
            this.labelPaused.Location = new System.Drawing.Point(120, 300);
            this.labelPaused.Name = "labelPaused";
            this.labelPaused.Size = new System.Drawing.Size(200, 45);
            this.labelPaused.TabIndex = 9;
            this.labelPaused.Text = "일시정지";
            this.labelPaused.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPaused.Visible = false;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.labelPaused);
            this.Controls.Add(this.panelGame);
            this.Controls.Add(this.panelInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "테트리스";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);

            // 패널에 컨트롤 추가
            this.panelInfo.Controls.Add(this.labelNextBlock);
            this.panelInfo.Controls.Add(this.panelNextBlock);
            this.panelInfo.Controls.Add(this.labelScore);
            this.panelInfo.Controls.Add(this.labelLevel);
            this.panelInfo.Controls.Add(this.labelLines);
            this.panelInfo.Controls.Add(this.labelControls);
            this.panelInfo.Controls.Add(this.buttonPause);
            this.panelInfo.Controls.Add(this.buttonRestart);

            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Panel panelNextBlock;
        private System.Windows.Forms.Label labelNextBlock;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelLines;
        private System.Windows.Forms.Label labelControls;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Label labelPaused;
    }
}