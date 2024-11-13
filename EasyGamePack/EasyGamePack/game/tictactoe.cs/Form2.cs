using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WindowsFormsApp7
{
    public partial class Form2 : Form
    {
        public enum Player
        {
            // 아래는 두 개의 값을 갖는 플레이어 클래스
            // X와 O
            // 이렇게 하면 플레이어와 AI 심볼을 제어함
            X, O
        }
        Player currentPlayer; // 플레이어 클래스 호출
        List<Button> buttons; // 버튼의 리스트 생성
        Random rand = new Random(); //랜덤 함수 클래스 가져오기
        int playerWins = 0; // 플레이어 승리를 o로 설정
        int computerWins = 0; // 컴퓨터 승리를 o로 설정
        public Form2()
        {
            InitializeComponent();
            resetGame();//게임 설정 함수 호출
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // 어떤 버튼 클릭인지 찾기
            currentPlayer = Player.X; // 플레이어를 x로 설정
            button.Text = currentPlayer.ToString(); // 버튼 텍스트를 플레이어 X로 변경
            button.Enabled = false; // 버튼 비활성화
            button.BackColor = System.Drawing.Color.Cyan; // 플레이어 색상을 Cyan 으로 변경
            buttons.Remove(button); //AI가 클릭할 수 없도록 버튼 목록에서 버튼을 제거함
            Check(); //플레이어가 이겼는지 확인
            AImoves.Start(); // ai타이머 시작
        }

        private void AImove(object sender, EventArgs e)
        {
            // CPU는 목록에서 무작위로 버튼을 선택해 클릭한다.
            // 배열이 0보다 큰 경우 CPU가 게임에서 작동합니다.
            // 배열이 0보다 작으면 재생이 중지됩니다.
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); // 사용 가능한 버튼 수 내에서 난수 생성
                buttons[index].Enabled = false; // 버튼에 번호를 할당
                // 난수가 생성되면 목록을 살펴보기
                // 그 숫자가 무엇인지 알아보기 위해 해당 버튼을 선택
                // ex)숫자가 8인 경우
                // 그런 다음 목록에서 8번째 버튼을 선택
                currentPlayer = Player.O; //AI를 o로 설정
                buttons[index].Text = currentPlayer.ToString(); // 버튼에 O 표시
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; // 버튼의 배경을 DarkSalmon색 으로 변경
                buttons.RemoveAt(index); //목록에서 해당 버튼 제거
                Check(); // AI가 뭐 얻었는지 확인
                AImoves.Stop(); // AI 타이머 중지
            }
        }

        private void restartGame(object sender, EventArgs e)
        {
            // 리셋버튼과 연결
            resetGame();
        }
        private void loadbuttons()
        {// 모든 버튼을 목록으로 정의
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
        }
        private void resetGame()
        {
            //각 버튼에 play 태그가 있는지 확인
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // 모두 다시 활성화 또는 클릭 가능하게 변경
                    ((Button)X).Text = "?"; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // 배경색을 기본버튼 색상으로 변경
                }
            }
            loadbuttons(); //모든 버튼이 배열에 다시 삽입되도록 load buttons 함수를 실행
        }
        private void Check()
        {

            {
                // 플레이어 X가 이겼는지 확인
                if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                   || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                   || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                   || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                   || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                   || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                   || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                   || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
                {
                    AImoves.Stop();
                    MessageBox.Show("인간 승리!");
                    playerWins++;
                    label1.Text = "인간 승리 - " + playerWins;
                    resetGame();
                    return; // 게임 종료
                }

                // AI O가 이겼는지 확인
                if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                   || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                   || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                   || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                   || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                   || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                   || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                   || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
                {
                    AImoves.Stop();
                    MessageBox.Show("AI 승리!");
                    computerWins++;
                    label2.Text = "AI 승리 - " + computerWins;
                    resetGame();
                    return; // 게임 종료
                }

                // 무승부 조건 확인: 승리 조건이 충족되지 않고 버튼이 모두 사용되었을 때
                if (buttons.Count == 0)
                {
                    AImoves.Stop();
                    MessageBox.Show("무승부입니다!");
                    resetGame();
                }
            }

        }
    }
}

