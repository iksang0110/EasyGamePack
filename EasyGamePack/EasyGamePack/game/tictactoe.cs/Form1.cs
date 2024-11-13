using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int count = 0;

        void checkWinner(string symbol)
        {
            {
                string winnerName = symbol == "0" ? player1Name : player2Name;

                if (button1.Text == symbol && button2.Text == symbol && button3.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button4.Text == symbol && button5.Text == symbol && button6.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button7.Text == symbol && button8.Text == symbol && button9.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button1.Text == symbol && button4.Text == symbol && button7.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button2.Text == symbol && button5.Text == symbol && button8.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button3.Text == symbol && button6.Text == symbol && button9.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button1.Text == symbol && button5.Text == symbol && button9.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
                else if (button3.Text == symbol && button5.Text == symbol && button7.Text == symbol)
                {
                    MessageBox.Show($"{winnerName}이 게임에서 이겼습니다!");
                }
            }


        }


        void fnsybol(object senderobj)
        {
            {
                // 게임 시작 여부 확인
                if (!isGameStarted)
                {
                    MessageBox.Show("게임 시작 버튼을 눌러주세요!");
                    return;
                }

                string buttontxt = ((Button)senderobj).Text;
                if (buttontxt == "")
                {
                    if (count % 2 == 0)
                    {
                        ((Button)senderobj).Text = "0";
                    }
                    else
                    {
                        ((Button)senderobj).Text = "x";
                    }
                    count++;

                    // 승자 확인
                    checkWinner("0");
                    checkWinner("x");

                    // 무승부 확인
                    if (count == 9) // 버튼 9개가 모두 채워졌을 때
                    {
                        if (!isWinner()) // 승자가 없으면
                        {
                            MessageBox.Show("무승부입니다 다시하기 버튼을 누르세요!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("잘못된 클릭입니다");
                }
            }

        }

        // 승자가 있는지 확인하는 메서드 추가
        bool isWinner()
        {
            // 승리 조건에 해당하는 경우 true 반환
            return (button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "") ||
                   (button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "") ||
                   (button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "") ||
                   (button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "") ||
                   (button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "") ||
                   (button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "") ||
                   (button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "") ||
                   (button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            fnsybol(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            {
                // 1. 각 버튼의 텍스트 초기화
                button1.Text = "";
                button2.Text = "";
                button3.Text = "";
                button4.Text = "";
                button5.Text = "";
                button6.Text = "";
                button7.Text = "";
                button8.Text = "";
                button9.Text = "";

                // 2. 게임 진행 상태 초기화
                count = 0;
                isGameStarted = false; // 게임 시작 상태 초기화

                // 3. 텍스트 박스 초기화
                textBox1.Text = "";
                textBox2.Text = "";

                // 4. 메시지 박스 출력 (선택 사항)
                MessageBox.Show("게임이 다시 시작되었습니다!");
            }

        }
        string player1Name = "플레이어 1";
        string player2Name = "플레이어 2";
        private void button11_Click(object sender, EventArgs e)
        {
            {
                player1Name = textBox1.Text == "" ? "플레이어 1" : textBox1.Text;
                player2Name = textBox2.Text == "" ? "플레이어 2" : textBox2.Text;

                isGameStarted = true; // 게임 시작 상태로 설정
                MessageBox.Show($"{player1Name}과 {player2Name}의 게임이 시작되었습니다!");
            }

        }
        private bool isGameStarted = false;  // 게임 시작 여부 플래그

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !isGameStarted)
            {
                button11_Click(sender, e);
                isGameStarted = true;  // 게임이 시작되었음을 표시
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && !isGameStarted)
            {
                button11_Click(sender, e);
                isGameStarted = true;  // 게임이 시작되었음을 표시
                e.Handled = true;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();

            // 새 폼을 모달로 띄우기
            newForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
