namespace EasyGamePack.game.BlackJack
{
    partial class BlackJack
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
            this.StartButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackgroundImage = global::EasyGamePack.Properties.Resources.PlayButton;
            this.StartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartButton.Location = new System.Drawing.Point(371, 530);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(259, 82);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "  ";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            this.StartButton.MouseLeave += new System.EventHandler(this.StartButton_MouseLeave);
            this.StartButton.MouseHover += new System.EventHandler(this.StartButton_MouseHover);
            // 
            // BlackJack
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::EasyGamePack.Properties.Resources.BlackJackOpeningScreenBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.StartButton);
            this.Name = "BlackJack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BlackJack";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
    }
}