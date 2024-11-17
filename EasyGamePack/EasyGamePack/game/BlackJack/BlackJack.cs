using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyGamePack.game.BlackJack
{
    public partial class BlackJack : Form
    {
        public BlackJack()
        {
            InitializeComponent();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            // BlackJackMain 폼을 생성하고 열기
            EasyGamePack.game.BlackJack.BlackJackMain blackjackMainForm = new EasyGamePack.game.BlackJack.BlackJackMain();
            blackjackMainForm.Show(); // BlackJackMain 폼을 표시

            // 현재 폼 (BlackJack.cs)을 숨기기
            this.Hide(); // BlackJack 폼을 숨깁니다.
        }

        private void StartButton_MouseHover(object sender, EventArgs e)
        {
            // 리소스에서 이미지를 가져와서 버튼에 설정
            StartButton.BackgroundImage = Properties.Resources.PlayButtonHover;
        }

        private void StartButton_MouseLeave(object sender, EventArgs e)
        {
            // 리소스에서 원본 이미지를 가져와서 버튼에 설정
            StartButton.BackgroundImage = Properties.Resources.PlayButton;
        }
    }
}
