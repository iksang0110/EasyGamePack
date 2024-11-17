namespace EasyGamePack.game.BlackJack
{
    partial class BlackJackMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerCard1 = new System.Windows.Forms.Panel();
            this.PlayerCard2 = new System.Windows.Forms.Panel();
            this.PlayerCard3 = new System.Windows.Forms.Panel();
            this.PlayerCard4 = new System.Windows.Forms.Panel();
            this.DealerCard1 = new System.Windows.Forms.Panel();
            this.DealerCard2 = new System.Windows.Forms.Panel();
            this.DealerCard3 = new System.Windows.Forms.Panel();
            this.DealButton = new System.Windows.Forms.Button();
            this.HitButton = new System.Windows.Forms.Button();
            this.StandButton = new System.Windows.Forms.Button();
            this.NextRoundButton = new System.Windows.Forms.Button();
            this.PlayerCount = new System.Windows.Forms.Label();
            this.DealerCount = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rulesToolStripMenuItem,
            this.tipToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // rulesToolStripMenuItem
            // 
            this.rulesToolStripMenuItem.Name = "rulesToolStripMenuItem";
            this.rulesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rulesToolStripMenuItem.Text = "Rules";
            this.rulesToolStripMenuItem.Click += new System.EventHandler(this.rulesToolStripMenuItem_Click);
            // 
            // tipToolStripMenuItem
            // 
            this.tipToolStripMenuItem.Name = "tipToolStripMenuItem";
            this.tipToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tipToolStripMenuItem.Text = "Tip";
            this.tipToolStripMenuItem.Click += new System.EventHandler(this.tipToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::EasyGamePack.Properties.Resources.BlackJackTable;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1000, 600);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PlayerCard1
            // 
            this.PlayerCard1.BackgroundImage = global::EasyGamePack.Properties.Resources.b1fv;
            this.PlayerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayerCard1.Location = new System.Drawing.Point(424, 323);
            this.PlayerCard1.Name = "PlayerCard1";
            this.PlayerCard1.Size = new System.Drawing.Size(120, 120);
            this.PlayerCard1.TabIndex = 2;
            // 
            // PlayerCard2
            // 
            this.PlayerCard2.Location = new System.Drawing.Point(565, 323);
            this.PlayerCard2.Name = "PlayerCard2";
            this.PlayerCard2.Size = new System.Drawing.Size(120, 120);
            this.PlayerCard2.TabIndex = 3;
            // 
            // PlayerCard3
            // 
            this.PlayerCard3.Location = new System.Drawing.Point(702, 323);
            this.PlayerCard3.Name = "PlayerCard3";
            this.PlayerCard3.Size = new System.Drawing.Size(124, 120);
            this.PlayerCard3.TabIndex = 4;
            // 
            // PlayerCard4
            // 
            this.PlayerCard4.Location = new System.Drawing.Point(280, 323);
            this.PlayerCard4.Name = "PlayerCard4";
            this.PlayerCard4.Size = new System.Drawing.Size(120, 120);
            this.PlayerCard4.TabIndex = 0;
            // 
            // DealerCard1
            // 
            this.DealerCard1.BackgroundImage = global::EasyGamePack.Properties.Resources.b1fv;
            this.DealerCard1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealerCard1.Location = new System.Drawing.Point(424, 27);
            this.DealerCard1.Name = "DealerCard1";
            this.DealerCard1.Size = new System.Drawing.Size(120, 120);
            this.DealerCard1.TabIndex = 5;
            // 
            // DealerCard2
            // 
            this.DealerCard2.Location = new System.Drawing.Point(565, 27);
            this.DealerCard2.Name = "DealerCard2";
            this.DealerCard2.Size = new System.Drawing.Size(120, 120);
            this.DealerCard2.TabIndex = 6;
            // 
            // DealerCard3
            // 
            this.DealerCard3.Location = new System.Drawing.Point(702, 27);
            this.DealerCard3.Name = "DealerCard3";
            this.DealerCard3.Size = new System.Drawing.Size(120, 120);
            this.DealerCard3.TabIndex = 7;
            // 
            // DealButton
            // 
            this.DealButton.BackgroundImage = global::EasyGamePack.Properties.Resources.DealButton;
            this.DealButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DealButton.Location = new System.Drawing.Point(362, 646);
            this.DealButton.Name = "DealButton";
            this.DealButton.Size = new System.Drawing.Size(259, 82);
            this.DealButton.TabIndex = 8;
            this.DealButton.Text = "  ";
            this.DealButton.UseVisualStyleBackColor = true;
            this.DealButton.Click += new System.EventHandler(this.DealButton_Click);
            // 
            // HitButton
            // 
            this.HitButton.BackgroundImage = global::EasyGamePack.Properties.Resources.HitButtonDisabled;
            this.HitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HitButton.Location = new System.Drawing.Point(280, 547);
            this.HitButton.Name = "HitButton";
            this.HitButton.Size = new System.Drawing.Size(200, 80);
            this.HitButton.TabIndex = 9;
            this.HitButton.Text = "  ";
            this.HitButton.UseVisualStyleBackColor = true;
            this.HitButton.Click += new System.EventHandler(this.HitButton_Click);
            // 
            // StandButton
            // 
            this.StandButton.BackgroundImage = global::EasyGamePack.Properties.Resources.StandButtonDisabled;
            this.StandButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StandButton.Location = new System.Drawing.Point(498, 547);
            this.StandButton.Name = "StandButton";
            this.StandButton.Size = new System.Drawing.Size(200, 80);
            this.StandButton.TabIndex = 10;
            this.StandButton.Text = "  ";
            this.StandButton.UseVisualStyleBackColor = true;
            this.StandButton.Click += new System.EventHandler(this.StandButton_Click);
            // 
            // NextRoundButton
            // 
            this.NextRoundButton.BackgroundImage = global::EasyGamePack.Properties.Resources.NextRoundButton;
            this.NextRoundButton.Location = new System.Drawing.Point(362, 545);
            this.NextRoundButton.Name = "NextRoundButton";
            this.NextRoundButton.Size = new System.Drawing.Size(259, 82);
            this.NextRoundButton.TabIndex = 11;
            this.NextRoundButton.Text = "  ";
            this.NextRoundButton.UseVisualStyleBackColor = true;
            this.NextRoundButton.Click += new System.EventHandler(this.NextRoundButton_Click);
            // 
            // PlayerCount
            // 
            this.PlayerCount.AutoSize = true;
            this.PlayerCount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCount.ForeColor = System.Drawing.Color.White;
            this.PlayerCount.Location = new System.Drawing.Point(473, 291);
            this.PlayerCount.Name = "PlayerCount";
            this.PlayerCount.Size = new System.Drawing.Size(81, 29);
            this.PlayerCount.TabIndex = 12;
            this.PlayerCount.Text = "label1";
            // 
            // DealerCount
            // 
            this.DealerCount.AutoSize = true;
            this.DealerCount.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DealerCount.ForeColor = System.Drawing.Color.White;
            this.DealerCount.Location = new System.Drawing.Point(476, 161);
            this.DealerCount.Name = "DealerCount";
            this.DealerCount.Size = new System.Drawing.Size(81, 29);
            this.DealerCount.TabIndex = 13;
            this.DealerCount.Text = "label1";
            // 
            // BlackJackMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::EasyGamePack.Properties.Resources.GameBoardBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.DealerCount);
            this.Controls.Add(this.PlayerCount);
            this.Controls.Add(this.NextRoundButton);
            this.Controls.Add(this.StandButton);
            this.Controls.Add(this.HitButton);
            this.Controls.Add(this.DealButton);
            this.Controls.Add(this.DealerCard3);
            this.Controls.Add(this.DealerCard2);
            this.Controls.Add(this.DealerCard1);
            this.Controls.Add(this.PlayerCard4);
            this.Controls.Add(this.PlayerCard3);
            this.Controls.Add(this.PlayerCard2);
            this.Controls.Add(this.PlayerCard1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BlackJackMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJackMain";
            this.Load += new System.EventHandler(this.BlackJackMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PlayerCard1;
        private System.Windows.Forms.Panel PlayerCard2;
        private System.Windows.Forms.Panel PlayerCard3;
        private System.Windows.Forms.Panel PlayerCard4;
        private System.Windows.Forms.Panel DealerCard1;
        private System.Windows.Forms.Panel DealerCard2;
        private System.Windows.Forms.Panel DealerCard3;
        private System.Windows.Forms.Button DealButton;
        private System.Windows.Forms.Button HitButton;
        private System.Windows.Forms.Button StandButton;
        private System.Windows.Forms.Button NextRoundButton;
        private System.Windows.Forms.Label PlayerCount;
        private System.Windows.Forms.Label DealerCount;
    }
}