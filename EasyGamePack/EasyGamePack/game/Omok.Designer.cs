namespace Omok
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

            // 게임 상태 그룹박스
            this.grpGameStatus = new System.Windows.Forms.GroupBox();
            this.grpGameStatus.Location = new System.Drawing.Point(30, 30);
            this.grpGameStatus.Name = "grpGameStatus";
            this.grpGameStatus.Size = new System.Drawing.Size(180, 180);
            this.grpGameStatus.TabIndex = 0;
            this.grpGameStatus.Text = "게임 상태";
            this.grpGameStatus.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.grpGameStatus.BackColor = System.Drawing.Color.FromArgb(245, 222, 179);

            // 게임 시작 버튼
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStart.Location = new System.Drawing.Point(20, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(140, 45);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "게임 시작";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(152, 251, 152);
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // 리셋 버튼
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReset.Location = new System.Drawing.Point(20, 100);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(140, 45);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "다시 시작";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(255, 182, 193);
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);

            // 게임 상태 그룹박스에 버튼들 추가
            this.grpGameStatus.Controls.Add(this.btnStart);
            this.grpGameStatus.Controls.Add(this.btnReset);

            // 난이도 그룹박스
            this.grpDifficulty = new System.Windows.Forms.GroupBox();
            this.grpDifficulty.Location = new System.Drawing.Point(30, 230);
            this.grpDifficulty.Name = "grpDifficulty";
            this.grpDifficulty.Size = new System.Drawing.Size(180, 200);
            this.grpDifficulty.TabIndex = 3;
            this.grpDifficulty.Text = "난이도 설정";
            this.grpDifficulty.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.grpDifficulty.BackColor = System.Drawing.Color.FromArgb(245, 222, 179);

            // 쉬움 버튼
            this.btnEasy = new System.Windows.Forms.Button();
            this.btnEasy.Location = new System.Drawing.Point(20, 40);
            this.btnEasy.Name = "btnEasy";
            this.btnEasy.Size = new System.Drawing.Size(140, 40);
            this.btnEasy.TabIndex = 4;
            this.btnEasy.Text = "쉬움";
            this.btnEasy.UseVisualStyleBackColor = true;
            this.btnEasy.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnEasy.BackColor = System.Drawing.Color.White;
            this.btnEasy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEasy.Click += new System.EventHandler(this.btnEasy_Click);

            // 보통 버튼
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnNormal.Location = new System.Drawing.Point(20, 90);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(140, 40);
            this.btnNormal.TabIndex = 5;
            this.btnNormal.Text = "보통";
            this.btnNormal.UseVisualStyleBackColor = true;
            this.btnNormal.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnNormal.BackColor = System.Drawing.Color.White;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);

            // 어려움 버튼
            this.btnHard = new System.Windows.Forms.Button();
            this.btnHard.Location = new System.Drawing.Point(20, 140);
            this.btnHard.Name = "btnHard";
            this.btnHard.Size = new System.Drawing.Size(140, 40);
            this.btnHard.TabIndex = 6;
            this.btnHard.Text = "어려움";
            this.btnHard.UseVisualStyleBackColor = true;
            this.btnHard.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnHard.BackColor = System.Drawing.Color.White;
            this.btnHard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHard.Click += new System.EventHandler(this.btnHard_Click);

            // 난이도 그룹박스에 버튼들 추가
            this.grpDifficulty.Controls.Add(this.btnEasy);
            this.grpDifficulty.Controls.Add(this.btnNormal);
            this.grpDifficulty.Controls.Add(this.btnHard);

            // 정보 그룹박스
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.grpInfo.Location = new System.Drawing.Point(30, 450);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(180, 200);
            this.grpInfo.TabIndex = 7;
            this.grpInfo.Text = "게임 정보";
            this.grpInfo.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold);
            this.grpInfo.BackColor = System.Drawing.Color.FromArgb(245, 222, 179);

            // 게임 상태 레이블
            this.lblGameStatus = new System.Windows.Forms.Label();
            this.lblGameStatus.Location = new System.Drawing.Point(10, 30);
            this.lblGameStatus.Name = "lblGameStatus";
            this.lblGameStatus.Size = new System.Drawing.Size(160, 30);
            this.lblGameStatus.TabIndex = 8;
            this.lblGameStatus.Text = "게임 시작 전";
            this.lblGameStatus.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblGameStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 스코어 레이블
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScore.Location = new System.Drawing.Point(10, 70);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(160, 30);
            this.lblScore.TabIndex = 9;
            this.lblScore.Text = "승점 - 흑: 0 백: 0";
            this.lblScore.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 현재 난이도 레이블
            this.lblDifficulty = new System.Windows.Forms.Label();
            this.lblDifficulty.Location = new System.Drawing.Point(10, 110);
            this.lblDifficulty.Name = "lblDifficulty";
            this.lblDifficulty.Size = new System.Drawing.Size(160, 30);
            this.lblDifficulty.TabIndex = 10;
            this.lblDifficulty.Text = "난이도: 보통";
            this.lblDifficulty.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.lblDifficulty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 도움말 레이블
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblHelp.Location = new System.Drawing.Point(30, 680);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(180, 150);
            this.lblHelp.TabIndex = 11;
            this.lblHelp.Text = "게임 방법:\n\n1. 게임 시작을 클릭하세요\n2. 난이도를 선택하세요\n3. 보드를 클릭하여\n   돌을 놓으세요\n\n처음 돌은 항상\n흑돌(검은색)입니다";
            this.lblHelp.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblHelp.BackColor = System.Drawing.Color.FromArgb(245, 222, 179);
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // 정보 그룹박스에 레이블들 추가
            this.grpInfo.Controls.Add(this.lblGameStatus);
            this.grpInfo.Controls.Add(this.lblScore);
            this.grpInfo.Controls.Add(this.lblDifficulty);

            // 폼에 컨트롤 추가
            this.Controls.Add(this.grpGameStatus);
            this.Controls.Add(this.grpDifficulty);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lblHelp);

            // 폼 설정
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "오목 게임";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpGameStatus.ResumeLayout(false);
            this.grpDifficulty.ResumeLayout(false);
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpGameStatus;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpDifficulty;
        private System.Windows.Forms.Button btnEasy;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnHard;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblGameStatus;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblDifficulty;
        private System.Windows.Forms.Label lblHelp;
    }
}