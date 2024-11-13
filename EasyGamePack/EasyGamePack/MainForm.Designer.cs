using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;

namespace EasyGamePack
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.flowGames = new System.Windows.Forms.FlowLayoutPanel();
            this.panelOmok = new System.Windows.Forms.Panel();
            this.picOmok = new System.Windows.Forms.PictureBox();
            this.lblOmokTitle = new System.Windows.Forms.Label();
            this.lblOmokDesc = new System.Windows.Forms.Label();
            this.btnOmok = new System.Windows.Forms.Button();
            this.panelTicTacToe = new System.Windows.Forms.Panel();
            this.picTicTacToe = new System.Windows.Forms.PictureBox();
            this.lblTicTacToeTitle = new System.Windows.Forms.Label();
            this.lblTicTacToeDesc = new System.Windows.Forms.Label();
            this.btnTicTacToe = new System.Windows.Forms.Button();
            this.panelTetris = new System.Windows.Forms.Panel();
            this.picTetris = new System.Windows.Forms.PictureBox();
            this.lblTetrisTitle = new System.Windows.Forms.Label();
            this.lblTetrisDesc = new System.Windows.Forms.Label();
            this.btnTetris = new System.Windows.Forms.Button();
            this.panelBlackjack = new System.Windows.Forms.Panel();
            this.picBlackjack = new System.Windows.Forms.PictureBox();
            this.lblBlackjackTitle = new System.Windows.Forms.Label();
            this.lblBlackjackDesc = new System.Windows.Forms.Label();
            this.btnBlackjack = new System.Windows.Forms.Button();
            this.panelMemory = new System.Windows.Forms.Panel();
            this.picMemory = new System.Windows.Forms.PictureBox();
            this.lblMemoryTitle = new System.Windows.Forms.Label();
            this.lblMemoryDesc = new System.Windows.Forms.Label();
            this.btnMemory = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.flowGames.SuspendLayout();
            this.panelOmok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picOmok)).BeginInit();
            this.panelTicTacToe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTicTacToe)).BeginInit();
            this.panelTetris.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTetris)).BeginInit();
            this.panelBlackjack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBlackjack)).BeginInit();
            this.panelMemory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMemory)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblCredit);
            this.panelTop.Controls.Add(this.btnLogout);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 80);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint_2);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(23, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(168, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "이지게임팩";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.lblCredit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblCredit.Location = new System.Drawing.Point(23, 55);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(237, 20);
            this.lblCredit.TabIndex = 1;
            this.lblCredit.Text = "원광대학교 윈도우프로그래밍 6조";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(686, 25);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(91, 30);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "로그아웃";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.panelMain.Controls.Add(this.flowGames);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 80);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(800, 620);
            this.panelMain.TabIndex = 0;
            // 
            // flowGames
            // 
            this.flowGames.AutoScroll = true;
            this.flowGames.AutoScrollMinSize = new System.Drawing.Size(1000, 0);
            this.flowGames.BackColor = System.Drawing.Color.Transparent;
            this.flowGames.Controls.Add(this.panelOmok);
            this.flowGames.Controls.Add(this.panelTicTacToe);
            this.flowGames.Controls.Add(this.panelTetris);
            this.flowGames.Controls.Add(this.panelBlackjack);
            this.flowGames.Controls.Add(this.panelMemory);
            this.flowGames.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowGames.Location = new System.Drawing.Point(0, 0);
            this.flowGames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowGames.Name = "flowGames";
            this.flowGames.Padding = new System.Windows.Forms.Padding(17, 20, 17, 20);
            this.flowGames.Size = new System.Drawing.Size(800, 620);
            this.flowGames.TabIndex = 0;
            this.flowGames.WrapContents = false;
            this.flowGames.Paint += new System.Windows.Forms.PaintEventHandler(this.flowGames_Paint);
            // 
            // panelOmok
            // 
            this.panelOmok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panelOmok.Controls.Add(this.picOmok);
            this.panelOmok.Controls.Add(this.lblOmokTitle);
            this.panelOmok.Controls.Add(this.lblOmokDesc);
            this.panelOmok.Controls.Add(this.btnOmok);
            this.panelOmok.Location = new System.Drawing.Point(26, 30);
            this.panelOmok.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelOmok.Name = "panelOmok";
            this.panelOmok.Size = new System.Drawing.Size(206, 450);
            this.panelOmok.TabIndex = 0;
            // 
            // picOmok
            // 
            this.picOmok.BackColor = System.Drawing.Color.Transparent;
            this.picOmok.Location = new System.Drawing.Point(23, 20);
            this.picOmok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picOmok.Name = "picOmok";
            this.picOmok.Size = new System.Drawing.Size(160, 140);
            this.picOmok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picOmok.TabIndex = 0;
            this.picOmok.TabStop = false;
            // 
            // lblOmokTitle
            // 
            this.lblOmokTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblOmokTitle.ForeColor = System.Drawing.Color.White;
            this.lblOmokTitle.Location = new System.Drawing.Point(23, 180);
            this.lblOmokTitle.Name = "lblOmokTitle";
            this.lblOmokTitle.Size = new System.Drawing.Size(160, 40);
            this.lblOmokTitle.TabIndex = 1;
            this.lblOmokTitle.Text = "오목";
            this.lblOmokTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOmokDesc
            // 
            this.lblOmokDesc.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblOmokDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblOmokDesc.Location = new System.Drawing.Point(23, 220);
            this.lblOmokDesc.Name = "lblOmokDesc";
            this.lblOmokDesc.Size = new System.Drawing.Size(160, 76);
            this.lblOmokDesc.TabIndex = 2;
            this.lblOmokDesc.Text = "봇과 즐기는\n전략 보드게임\nmade by. 정익상";
            this.lblOmokDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOmok
            // 
            this.btnOmok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnOmok.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOmok.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnOmok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOmok.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnOmok.ForeColor = System.Drawing.Color.White;
            this.btnOmok.Location = new System.Drawing.Point(23, 380);
            this.btnOmok.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOmok.Name = "btnOmok";
            this.btnOmok.Size = new System.Drawing.Size(160, 40);
            this.btnOmok.TabIndex = 3;
            this.btnOmok.Text = "시작하기";
            this.btnOmok.UseVisualStyleBackColor = false;
            this.btnOmok.Click += new System.EventHandler(this.btnOmok_Click);
            // 
            // panelTicTacToe
            // 
            this.panelTicTacToe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panelTicTacToe.Controls.Add(this.picTicTacToe);
            this.panelTicTacToe.Controls.Add(this.lblTicTacToeTitle);
            this.panelTicTacToe.Controls.Add(this.lblTicTacToeDesc);
            this.panelTicTacToe.Controls.Add(this.btnTicTacToe);
            this.panelTicTacToe.Location = new System.Drawing.Point(250, 30);
            this.panelTicTacToe.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelTicTacToe.Name = "panelTicTacToe";
            this.panelTicTacToe.Size = new System.Drawing.Size(206, 450);
            this.panelTicTacToe.TabIndex = 1;
            // 
            // picTicTacToe
            // 
            this.picTicTacToe.BackColor = System.Drawing.Color.Transparent;
            this.picTicTacToe.Location = new System.Drawing.Point(23, 20);
            this.picTicTacToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTicTacToe.Name = "picTicTacToe";
            this.picTicTacToe.Size = new System.Drawing.Size(160, 140);
            this.picTicTacToe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTicTacToe.TabIndex = 0;
            this.picTicTacToe.TabStop = false;
            // 
            // lblTicTacToeTitle
            // 
            this.lblTicTacToeTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTicTacToeTitle.ForeColor = System.Drawing.Color.White;
            this.lblTicTacToeTitle.Location = new System.Drawing.Point(23, 180);
            this.lblTicTacToeTitle.Name = "lblTicTacToeTitle";
            this.lblTicTacToeTitle.Size = new System.Drawing.Size(160, 40);
            this.lblTicTacToeTitle.TabIndex = 1;
            this.lblTicTacToeTitle.Text = "틱택톡";
            this.lblTicTacToeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTicTacToeDesc
            // 
            this.lblTicTacToeDesc.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblTicTacToeDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTicTacToeDesc.Location = new System.Drawing.Point(23, 220);
            this.lblTicTacToeDesc.Name = "lblTicTacToeDesc";
            this.lblTicTacToeDesc.Size = new System.Drawing.Size(160, 76);
            this.lblTicTacToeDesc.TabIndex = 2;
            this.lblTicTacToeDesc.Text = "3x3 격자의\n두뇌 게임\nmade by. 양우혁";
            this.lblTicTacToeDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTicTacToe
            // 
            this.btnTicTacToe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnTicTacToe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTicTacToe.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnTicTacToe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicTacToe.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnTicTacToe.ForeColor = System.Drawing.Color.White;
            this.btnTicTacToe.Location = new System.Drawing.Point(23, 380);
            this.btnTicTacToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTicTacToe.Name = "btnTicTacToe";
            this.btnTicTacToe.Size = new System.Drawing.Size(160, 40);
            this.btnTicTacToe.TabIndex = 3;
            this.btnTicTacToe.Text = "시작하기";
            this.btnTicTacToe.UseVisualStyleBackColor = false;
            this.btnTicTacToe.Click += new System.EventHandler(this.btnTicTacToe_Click);
            // 
            // panelTetris
            // 
            this.panelTetris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panelTetris.Controls.Add(this.picTetris);
            this.panelTetris.Controls.Add(this.lblTetrisTitle);
            this.panelTetris.Controls.Add(this.lblTetrisDesc);
            this.panelTetris.Controls.Add(this.btnTetris);
            this.panelTetris.Location = new System.Drawing.Point(474, 30);
            this.panelTetris.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelTetris.Name = "panelTetris";
            this.panelTetris.Size = new System.Drawing.Size(206, 450);
            this.panelTetris.TabIndex = 2;
            // 
            // picTetris
            // 
            this.picTetris.BackColor = System.Drawing.Color.Transparent;
            this.picTetris.Location = new System.Drawing.Point(23, 20);
            this.picTetris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picTetris.Name = "picTetris";
            this.picTetris.Size = new System.Drawing.Size(160, 140);
            this.picTetris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTetris.TabIndex = 0;
            this.picTetris.TabStop = false;
            this.picTetris.Click += new System.EventHandler(this.picTetris_Click);
            // 
            // lblTetrisTitle
            // 
            this.lblTetrisTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTetrisTitle.ForeColor = System.Drawing.Color.White;
            this.lblTetrisTitle.Location = new System.Drawing.Point(23, 180);
            this.lblTetrisTitle.Name = "lblTetrisTitle";
            this.lblTetrisTitle.Size = new System.Drawing.Size(160, 40);
            this.lblTetrisTitle.TabIndex = 1;
            this.lblTetrisTitle.Text = "테트리스";
            this.lblTetrisTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTetrisDesc
            // 
            this.lblTetrisDesc.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblTetrisDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblTetrisDesc.Location = new System.Drawing.Point(23, 220);
            this.lblTetrisDesc.Name = "lblTetrisDesc";
            this.lblTetrisDesc.Size = new System.Drawing.Size(160, 76);
            this.lblTetrisDesc.TabIndex = 2;
            this.lblTetrisDesc.Text = "블록 쌓기의\n클래식\nmade by. 김수호";
            this.lblTetrisDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnTetris
            // 
            this.btnTetris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnTetris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTetris.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnTetris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTetris.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnTetris.ForeColor = System.Drawing.Color.White;
            this.btnTetris.Location = new System.Drawing.Point(23, 380);
            this.btnTetris.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTetris.Name = "btnTetris";
            this.btnTetris.Size = new System.Drawing.Size(160, 40);
            this.btnTetris.TabIndex = 3;
            this.btnTetris.Text = "시작하기";
            this.btnTetris.UseVisualStyleBackColor = false;
            this.btnTetris.Click += new System.EventHandler(this.btnTetris_Click);
            // 
            // panelBlackjack
            // 
            this.panelBlackjack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panelBlackjack.Controls.Add(this.picBlackjack);
            this.panelBlackjack.Controls.Add(this.lblBlackjackTitle);
            this.panelBlackjack.Controls.Add(this.lblBlackjackDesc);
            this.panelBlackjack.Controls.Add(this.btnBlackjack);
            this.panelBlackjack.Location = new System.Drawing.Point(698, 30);
            this.panelBlackjack.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelBlackjack.Name = "panelBlackjack";
            this.panelBlackjack.Size = new System.Drawing.Size(206, 450);
            this.panelBlackjack.TabIndex = 3;
            // 
            // picBlackjack
            // 
            this.picBlackjack.BackColor = System.Drawing.Color.Transparent;
            this.picBlackjack.Location = new System.Drawing.Point(23, 20);
            this.picBlackjack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBlackjack.Name = "picBlackjack";
            this.picBlackjack.Size = new System.Drawing.Size(160, 140);
            this.picBlackjack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBlackjack.TabIndex = 0;
            this.picBlackjack.TabStop = false;
            // 
            // lblBlackjackTitle
            // 
            this.lblBlackjackTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblBlackjackTitle.ForeColor = System.Drawing.Color.White;
            this.lblBlackjackTitle.Location = new System.Drawing.Point(23, 180);
            this.lblBlackjackTitle.Name = "lblBlackjackTitle";
            this.lblBlackjackTitle.Size = new System.Drawing.Size(160, 40);
            this.lblBlackjackTitle.TabIndex = 1;
            this.lblBlackjackTitle.Text = "블랙잭";
            this.lblBlackjackTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBlackjackDesc
            // 
            this.lblBlackjackDesc.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblBlackjackDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblBlackjackDesc.Location = new System.Drawing.Point(23, 220);
            this.lblBlackjackDesc.Name = "lblBlackjackDesc";
            this.lblBlackjackDesc.Size = new System.Drawing.Size(160, 76);
            this.lblBlackjackDesc.TabIndex = 2;
            this.lblBlackjackDesc.Text = "21을 향한\n카드 게임\nmade by. 최이지";
            this.lblBlackjackDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBlackjack
            // 
            this.btnBlackjack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnBlackjack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlackjack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnBlackjack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlackjack.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnBlackjack.ForeColor = System.Drawing.Color.White;
            this.btnBlackjack.Location = new System.Drawing.Point(23, 380);
            this.btnBlackjack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBlackjack.Name = "btnBlackjack";
            this.btnBlackjack.Size = new System.Drawing.Size(160, 40);
            this.btnBlackjack.TabIndex = 3;
            this.btnBlackjack.Text = "시작하기";
            this.btnBlackjack.UseVisualStyleBackColor = false;
            this.btnBlackjack.Click += new System.EventHandler(this.btnBlackjack_Click);
            // 
            // panelMemory
            // 
            this.panelMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(48)))), ((int)(((byte)(54)))));
            this.panelMemory.Controls.Add(this.picMemory);
            this.panelMemory.Controls.Add(this.lblMemoryTitle);
            this.panelMemory.Controls.Add(this.lblMemoryDesc);
            this.panelMemory.Controls.Add(this.btnMemory);
            this.panelMemory.Location = new System.Drawing.Point(922, 30);
            this.panelMemory.Margin = new System.Windows.Forms.Padding(9, 10, 9, 10);
            this.panelMemory.Name = "panelMemory";
            this.panelMemory.Size = new System.Drawing.Size(206, 450);
            this.panelMemory.TabIndex = 4;
            // 
            // picMemory
            // 
            this.picMemory.BackColor = System.Drawing.Color.Transparent;
            this.picMemory.Location = new System.Drawing.Point(23, 20);
            this.picMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMemory.Name = "picMemory";
            this.picMemory.Size = new System.Drawing.Size(160, 140);
            this.picMemory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMemory.TabIndex = 0;
            this.picMemory.TabStop = false;
            // 
            // lblMemoryTitle
            // 
            this.lblMemoryTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblMemoryTitle.ForeColor = System.Drawing.Color.White;
            this.lblMemoryTitle.Location = new System.Drawing.Point(23, 180);
            this.lblMemoryTitle.Name = "lblMemoryTitle";
            this.lblMemoryTitle.Size = new System.Drawing.Size(160, 40);
            this.lblMemoryTitle.TabIndex = 1;
            this.lblMemoryTitle.Text = "기억력 게임";
            this.lblMemoryTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMemoryDesc
            // 
            this.lblMemoryDesc.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMemoryDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.lblMemoryDesc.Location = new System.Drawing.Point(23, 220);
            this.lblMemoryDesc.Name = "lblMemoryDesc";
            this.lblMemoryDesc.Size = new System.Drawing.Size(160, 76);
            this.lblMemoryDesc.TabIndex = 2;
            this.lblMemoryDesc.Text = "짝 맞추기\n두뇌 훈련\nmade by. 조효민";
            this.lblMemoryDesc.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnMemory
            // 
            this.btnMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.btnMemory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMemory.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(68)))), ((int)(((byte)(74)))));
            this.btnMemory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMemory.Font = new System.Drawing.Font("맑은 고딕", 11F, System.Drawing.FontStyle.Bold);
            this.btnMemory.ForeColor = System.Drawing.Color.White;
            this.btnMemory.Location = new System.Drawing.Point(23, 380);
            this.btnMemory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMemory.Name = "btnMemory";
            this.btnMemory.Size = new System.Drawing.Size(160, 40);
            this.btnMemory.TabIndex = 3;
            this.btnMemory.Text = "시작하기";
            this.btnMemory.UseVisualStyleBackColor = false;
            this.btnMemory.Click += new System.EventHandler(this.btnMemory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(37)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 700);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.flowGames.ResumeLayout(false);
            this.panelOmok.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picOmok)).EndInit();
            this.panelTicTacToe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTicTacToe)).EndInit();
            this.panelTetris.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picTetris)).EndInit();
            this.panelBlackjack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBlackjack)).EndInit();
            this.panelMemory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMemory)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel flowGames;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCredit;
        private System.Windows.Forms.Button btnLogout;

        private System.Windows.Forms.Panel panelOmok;
        private System.Windows.Forms.Panel panelTicTacToe;
        private System.Windows.Forms.Panel panelTetris;
        private System.Windows.Forms.Panel panelBlackjack;
        private System.Windows.Forms.Panel panelMemory;

        private System.Windows.Forms.Button btnOmok;
        private System.Windows.Forms.Button btnTicTacToe;
        private System.Windows.Forms.Button btnTetris;
        private System.Windows.Forms.Button btnBlackjack;
        private System.Windows.Forms.Button btnMemory;

        private System.Windows.Forms.PictureBox picOmok;
        private System.Windows.Forms.PictureBox picTicTacToe;
        private System.Windows.Forms.PictureBox picTetris;
        private System.Windows.Forms.PictureBox picBlackjack;
        private System.Windows.Forms.PictureBox picMemory;

        private System.Windows.Forms.Label lblOmokTitle;
        private System.Windows.Forms.Label lblTicTacToeTitle;
        private System.Windows.Forms.Label lblTetrisTitle;
        private System.Windows.Forms.Label lblBlackjackTitle;
        private System.Windows.Forms.Label lblMemoryTitle;

        private System.Windows.Forms.Label lblOmokDesc;
        private System.Windows.Forms.Label lblTicTacToeDesc;
        private System.Windows.Forms.Label lblTetrisDesc;
        private System.Windows.Forms.Label lblBlackjackDesc;
        private System.Windows.Forms.Label lblMemoryDesc;
    }
}