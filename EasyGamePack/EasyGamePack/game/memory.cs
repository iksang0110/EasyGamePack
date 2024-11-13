using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MemoryGame
{
    public partial class Form1 : Form
    {
        private const int ROWS = 4;
        private const int COLS = 4;
        private const int CARD_SIZE = 100;
        private const int CARD_MARGIN = 10;

        private List<Card> cards;
        private Card firstCard;
        private Card secondCard;
        private bool canClick = true;

        private Player player1;
        private Player player2;
        private Player currentPlayer;

        private Timer turnTimer;
        private int turnTime = 5; // 5초

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            // 기존 카드가 있다면 제거
            if (cards != null)
            {
                foreach (var card in cards)
                {
                    panelGame.Controls.Remove(card);
                    card.Dispose();
                }
            }

            // 플레이어 초기화
            player1 = new Player("Player 1");
            player2 = new Player("Player 2");
            currentPlayer = player1;
            UpdatePlayerLabels();

            // 카드 생성 및 셔플
            cards = new List<Card>();
            List<int> numbers = new List<int>();

            Random random = new Random();
            while (numbers.Count < 16)
            {
                int num = random.Next(1, 100);
                if (!numbers.Contains(num))
                {
                    numbers.Add(num);
                    numbers.Add(num);
                }
            }

            numbers = numbers.OrderBy(x => random.Next()).ToList();

            // 카드 크기 계산
            int cardWidth = (panelGame.Width - (COLS + 1) * CARD_MARGIN) / COLS;
            int cardHeight = (panelGame.Height - (ROWS + 1) * CARD_MARGIN) / ROWS;
            int cardSize = Math.Min(cardWidth, cardHeight);

            // 카드 생성
            for (int row = 0; row < ROWS; row++)
            {
                for (int col = 0; col < COLS; col++)
                {
                    int index = row * COLS + col;
                    Card card = new Card();
                    card.Number = numbers[index];
                    card.Size = new Size(cardSize, cardSize);
                    card.Location = new Point(
                        col * (cardSize + CARD_MARGIN) + CARD_MARGIN,
                        row * (cardSize + CARD_MARGIN) + CARD_MARGIN
                    );
                    card.BackColor = Color.RoyalBlue;
                    card.ForeColor = Color.White;
                    card.Font = new Font("맑은 고딕", cardSize / 3, FontStyle.Bold);
                    card.FlatStyle = FlatStyle.Flat;
                    card.FlatAppearance.BorderSize = 0;
                    card.Click += Card_Click;

                    cards.Add(card);
                    panelGame.Controls.Add(card);
                }
            }

            // 게임 상태 초기화
            firstCard = null;
            secondCard = null;
            canClick = true;

            // 타이머 초기화
            turnTimer = new Timer();
            turnTimer.Interval = 1000; // 1초마다 타이머 틱
            turnTimer.Tick += TurnTimer_Tick;

            StartTurnTimer(); // 첫 번째 턴 시작
        }

        private void Card_Click(object sender, EventArgs e)
        {
            if (!canClick) return;  // 클릭이 허용되지 않으면 아무 작업도 안 함

            Card clickedCard = sender as Card;
            if (clickedCard.IsFlipped) return;  // 이미 뒤집힌 카드는 클릭하지 않음

            clickedCard.Flip();

            if (firstCard == null)
            {
                firstCard = clickedCard;
            }
            else if (secondCard == null && firstCard != clickedCard)
            {
                secondCard = clickedCard;
                canClick = false;  // 두 번째 카드가 클릭되면 클릭 불가 상태로 설정
                CheckMatch();  // 매치 체크
            }

            ResetTurnTimer(); // 카드 클릭 시 타이머 리셋
        }

        private void CheckMatch()
        {
            if (firstCard.Number == secondCard.Number)
            {
                // 매치 성공
                currentPlayer.Score += 2;
                UpdatePlayerLabels();

                // 게임 종료 확인
                if (cards.All(c => c.IsFlipped))
                {
                    string winner = player1.Score > player2.Score ? "Player 1" :
                                    player2.Score > player1.Score ? "Player 2" : "무승부";
                    MessageBox.Show($"게임 종료!\n{winner} 승리!", "게임 결과",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // 매칭 성공 후 바로 카드를 클릭할 수 있도록 한다.
                firstCard = null;
                secondCard = null;
                canClick = true;  // 클릭 가능하도록 설정
            }
            else
            {
                // 매치 실패 시 타이머로 1초 후 카드 뒤집기
                Timer flipTimer = new Timer();
                flipTimer.Interval = 1000;  // 1초 후에 실행
                flipTimer.Tick += (s, e) =>
                {
                    // 카드 다시 뒤집기
                    firstCard.Flip();
                    secondCard.Flip();

                    // 카드 상태 초기화
                    firstCard = null;
                    secondCard = null;
                    canClick = true;  // 다시 클릭 가능하도록 설정

                    flipTimer.Stop();  // 타이머 종료
                };
                flipTimer.Start();

                // 플레이어 차례 변경
                currentPlayer = (currentPlayer == player1) ? player2 : player1;
                UpdatePlayerLabels();
            }

            // 타이머 리셋
            ResetTurnTimer();
        }


        private void TurnTimer_Tick(object sender, EventArgs e)
        {
            turnTime--;  // 남은 시간 1초씩 차감

            // 남은 시간 표시 업데이트
            labelCurrentPlayer.Text = $"현재 차례: {(currentPlayer == player1 ? "Player 1" : "Player 2")} - 남은 시간: {turnTime}초";

            // 시간이 0이 되면 턴을 넘기고 타이머를 리셋
            if (turnTime <= 0)
            {
                currentPlayer = (currentPlayer == player1) ? player2 : player1;  // 턴을 넘김
                UpdatePlayerLabels();
                ResetTurnTimer();  // 타이머 리셋
            }
        }


        private void ResetTurnTimer()
        {
            turnTime = 5; // 5초로 리셋
            labelCurrentPlayer.Text = $"현재 차례: {(currentPlayer == player1 ? "Player 1" : "Player 2")} - 남은 시간: {turnTime}초";
        }

        private void StartTurnTimer()
        {
            turnTime = 5; // 5초로 초기화
            turnTimer.Start();
        }

        private void UpdatePlayerLabels()
        {
            labelPlayer1.Text = $"Player 1: {player1.Score}";
            labelPlayer2.Text = $"Player 2: {player2.Score}";
            labelCurrentPlayer.Text = $"현재 차례: {(currentPlayer == player1 ? "Player 1" : "Player 2")}";

            // 현재 차례인 플레이어의 레이블 색상 강조
            labelPlayer1.ForeColor = currentPlayer == player1 ? Color.Red : Color.Black;
            labelPlayer2.ForeColor = currentPlayer == player2 ? Color.Red : Color.Black;
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            InitializeGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 폼 로드 시 필요한 설정이 있을 경우 처리
        }
    }

    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
        }
    }

    public class Card : Button
    {
        public int Number { get; set; }
        public bool IsFlipped { get; private set; }

        public void Flip()
        {
            IsFlipped = !IsFlipped;
            Text = IsFlipped ? Number.ToString() : "";
            BackColor = IsFlipped ? Color.White : Color.RoyalBlue;
            ForeColor = IsFlipped ? Color.RoyalBlue : Color.White;
        }
    }
}
