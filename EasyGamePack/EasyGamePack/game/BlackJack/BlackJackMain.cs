using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace EasyGamePack.game.BlackJack
{
    public partial class BlackJackMain : Form
    {
        public BlackJackMain()
        {
            InitializeComponent();
        }

        private Random random = new Random();
        private List<Card> cardDeck;
        private List<Card> playerCards;
        private List<Card> dealerCards;

        private void BlackJackTable_Click(object sender, EventArgs e)
        {
           
        }
        // 카드 Value 바인딩
        public class Card
        {
            public string Suit { get; set; }     // 카드의 모양 (예: "c", "d", "h", "s")
            public int Value { get; set; }       // 카드의 값 (1, 2, ..., 10, 11(=J), 12(=Q), 13(=K))
            public string ResourceName => $"{Suit}{Value:D2}"; // 리소스 이름 (예: "c01")

            public int GetBlackjackValue()
            {
                if (Value >= 10) return 10; // J, Q, K는 10으로
                return Value == 1 ? 11 : Value; // A는 기본적으로 11로 반환
            }
        }

        private void BlackJackMain_Load(object sender, EventArgs e)
        {
            InitializeDeck();
            playerCards = new List<Card>();
            dealerCards = new List<Card>();

            // Next Round 버튼 숨기기
            NextRoundButton.Visible = false;
            NextRoundButton.Enabled = false;

            // Label 배경을 투명하게 설정
            PlayerCount.BackColor = Color.Transparent;
            DealerCount.BackColor = Color.Transparent;

            // 라벨 숨기기
            PlayerCount.Visible = false;
            DealerCount.Visible = false;

            // 패널 숨기기
            PlayerCard2.Visible = false;
            DealerCard2.Visible = false;
            PlayerCard3.Visible = false;
            DealerCard3.Visible = false;
            PlayerCard4.Visible = false;
        }

        private void InitializeDeck()
        {
            cardDeck = new List<Card>();
            string[] suits = { "c", "d", "h", "s" };

            for (int i = 1; i <= 13; i++)
            {
                foreach (var suit in suits)
                {
                    cardDeck.Add(new Card { Suit = suit, Value = i });
                }
            }
        }

        private void DealButton_Click(object sender, EventArgs e)
        {
            // DealButton을 처음 클릭하면 비활성화
            DealButton.Visible = false;

            // StandButton 활성화
            StandButton.Enabled = true;

            // StandButton 이미지 업데이트
            StandButton.BackgroundImage = Properties.Resources.StandButton; // StandButton.png 이미지 설정
            StandButton.BackgroundImageLayout = ImageLayout.Stretch;

            // 새 게임 시작 시 플레이어와 딜러 카드 목록 초기화
            playerCards.Clear();
            dealerCards.Clear();

            // 각 패널에 카드 설정 및 플레이어와 딜러 카드 리스트에 추가
            playerCards.Add(SetRandomCard(PlayerCard1));
            playerCards.Add(SetRandomCard(PlayerCard2));
            dealerCards.Add(SetRandomCard(DealerCard1));
            dealerCards.Add(SetRandomCard(DealerCard2));

            // PlayerCard2 및 DealerCard2 패널 표시
            PlayerCard2.Visible = true;
            DealerCard2.Visible = true;

            // 라벨 보이기
            PlayerCount.Visible = true;
            DealerCount.Visible = true;

            // 카드 합계 레이블 업데이트
            UpdateCardCounts();

            // 다음 게임을 위해 카드 덱을 다시 초기화
            InitializeDeck();

            // HitButton 활성화 상태 업데이트
            UpdateHitButtonState();
        }

        private Card SetRandomCard(Panel panel)
        {
            int index = random.Next(cardDeck.Count);
            Card card = cardDeck[index];

            // 리소스에서 해당 카드 이미지를 Panel의 BackgroundImage로 설정
            panel.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(card.ResourceName);
            panel.BackgroundImageLayout = ImageLayout.Stretch;

            // 사용된 카드는 덱에서 제거
            cardDeck.RemoveAt(index);

            return card; // 카드 반환하여 플레이어 또는 딜러 카드 리스트에 추가
        }

        private void UpdateCardCounts()
        {
            // 플레이어와 딜러 카드 합계 계산
            int playerTotal = playerCards.Sum(card => card.GetBlackjackValue());
            int dealerTotal = dealerCards.Sum(card => card.GetBlackjackValue());

            // 레이블에 합계 표시
            PlayerCount.Text = playerTotal.ToString();
            DealerCount.Text = dealerTotal.ToString();

            // HitButton 활성화 상태 업데이트
            UpdateHitButtonState();

            // 플레이어의 카드 합계가 21을 초과하면 Bust 메시지 표시
            if (playerTotal > 21)
            {
                MessageBox.Show("Bust!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                EndGame(); // 게임 종료 처리
            }
        }


        private void UpdateHitButtonState()
        {
            // 플레이어의 카드 합계가 21 이하일 때만 HitButton 활성화
            int playerTotal = playerCards.Sum(card => card.GetBlackjackValue());
            HitButton.Enabled = playerTotal <= 21;

            // HitButton의 이미지 업데이트
            if (HitButton.Enabled)
            {
                HitButton.BackgroundImage = Properties.Resources.HitButton; // HitButton 이미지로 변경
            }
            else
            {
                HitButton.BackgroundImage = Properties.Resources.HitButtonDisabled; // 비활성화 시 다른 이미지
            }

            HitButton.BackgroundImageLayout = ImageLayout.Stretch; // 이미지 크기 맞춤
        }


        private void HitButton_Click(object sender, EventArgs e)
        {
            // 플레이어 카드 합계 계산
            int playerTotal = playerCards.Sum(card => card.GetBlackjackValue());

            // PlayerCard3에 랜덤 카드 설정 및 합계 업데이트
            if (!PlayerCard3.Visible)
            {
                playerCards.Add(SetRandomCard(PlayerCard3));
                PlayerCard3.Visible = true; // PlayerCard3 패널 표시
            }
            else if (!PlayerCard4.Visible && playerTotal <= 21)
            {
                playerCards.Add(SetRandomCard(PlayerCard4));
                PlayerCard4.Visible = true; // PlayerCard4 패널 표시
            }

            // 카드 합계 레이블 업데이트
            UpdateCardCounts();
        }


        private void EndGame()
        {
            // 모든 버튼 숨기기
            HitButton.Visible = false;
            StandButton.Visible = false;
            DealButton.Visible = false;

            // Next Round 버튼 활성화 및 표시
            NextRoundButton.Visible = true;
            NextRoundButton.Enabled = true;
        }



        private void StandButton_Click(object sender, EventArgs e)
        {
            // 플레이어와 딜러 카드 합계 계산
            int playerTotal = playerCards.Sum(card => card.GetBlackjackValue());
            int dealerTotal = dealerCards.Sum(card => card.GetBlackjackValue());

            // 딜러는 카드 합계가 17 미만일 경우 추가 카드 받기
            while (dealerTotal < 17)
            {
                dealerCards.Add(SetRandomCard(DealerCard3)); // DealerCard3에 랜덤 카드 설정
                DealerCard3.Visible = true; // DealerCard3 패널 표시
                dealerTotal = dealerCards.Sum(card => card.GetBlackjackValue());

                // 카드 합계 레이블 업데이트
                UpdateCardCounts();
            }

            // 21에 더 가까운 사람이 승리
            string result;
            if (playerTotal > 21)
            {
                result = "Player Bust! Press New Game";
            }
            else if (dealerTotal > 21)
            {
                result = "Dealer Bust! Press New Game";
            }
            else if (playerTotal > dealerTotal)
            {
                result = "Player Win!";
            }
            else if (playerTotal < dealerTotal)
            {
                result = "Dealer Win!";
            }
            else if(playerTotal==21)
            {
                result = "Player BlackJack!";
            }
            else if(dealerTotal==21)
            {
                result = "Dealer BlackJack!";
            }
            else
            {
                result = "Push!";
            }

            // 결과 모달 창 표시
            MessageBox.Show(result, "Game Result", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // 게임 종료 처리
            EndGame();
        }


        private void NextRoundButton_Click(object sender, EventArgs e)
        {
            // 1. 버튼 초기화
            HitButton.Visible = true;
            HitButton.Enabled = false; // 새 게임 시작 시 비활성화
            HitButton.BackgroundImage = Properties.Resources.HitButton; // 활성화 이미지
            HitButton.BackgroundImageLayout = ImageLayout.Stretch;

            StandButton.Visible = true;
            StandButton.Enabled = false; // 새 게임 시작 시 비활성화
            StandButton.BackgroundImage = Properties.Resources.StandButton; // 활성화 이미지
            StandButton.BackgroundImageLayout = ImageLayout.Stretch;

            DealButton.Visible = true; // Deal 버튼 표시
            DealButton.Enabled = true; // Deal 버튼 활성화

            NextRoundButton.Visible = false; // NextRound 버튼 숨기기
            NextRoundButton.Enabled = false;

            // 2. 라벨 초기화
            PlayerCount.Text = "0";
            DealerCount.Text = "0";
            PlayerCount.Visible = false;
            DealerCount.Visible = false;

            // 3. 카드 패널 초기화
            PlayerCard1.BackgroundImage = Properties.Resources.b1fv; // PlayerCard1 배경 설정
            PlayerCard1.BackgroundImageLayout = ImageLayout.Stretch;

            DealerCard1.BackgroundImage = Properties.Resources.b2fv; // DealerCard1 배경 설정
            DealerCard1.BackgroundImageLayout = ImageLayout.Stretch;

            PlayerCard2.BackgroundImage = null;
            PlayerCard3.BackgroundImage = null;
            PlayerCard4.BackgroundImage = null;
         
            DealerCard2.BackgroundImage = null;
            DealerCard3.BackgroundImage = null;

            PlayerCard1.Visible = true; // PlayerCard1과 DealerCard1은 항상 표시
            DealerCard1.Visible = true;
            PlayerCard2.Visible = false;
            PlayerCard3.Visible = false;
            PlayerCard4.Visible = false; // PlayerCard4 숨기기
            DealerCard2.Visible = false;
            DealerCard3.Visible = false;

            // 4. 카드 리스트 초기화
            playerCards.Clear();
            dealerCards.Clear();

            // 5. 카드 덱 초기화
            InitializeDeck();

            // 6. 사용자에게 새 게임 메시지 표시
            MessageBox.Show("New game Started!.", "New Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 기존 NextRoundButton_Click 메서드를 호출하여 새로운 게임 상태로 초기화
            NextRoundButton_Click(sender, e);
        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 블랙잭 룰 설명 모달 창
            string rules = "블랙잭 룰:\n\n" +
                           "1. 목표는 카드 합계를 21에 최대한 가깝게 만드는 것입니다.\n" +
                           "2. 각 카드는 다음과 같이 점수가 계산됩니다:\n" +
                           "   - 숫자 카드: 숫자 그대로 점수로 계산.\n" +
                           "   - J, Q, K: 각각 10점.\n" +
                           "   - A: 1점 또는 11점으로 계산 (플레이어가 유리하도록).\n" +
                           "3. 플레이어와 딜러 모두 초기 2장의 카드를 받습니다.\n" +
                           "4. 'Hit' 버튼을 눌러 카드를 추가로 받을 수 있습니다.\n" +
                           "5. 'Stand' 버튼을 누르면 딜러 차례로 넘어갑니다.\n" +
                           "6. 딜러는 카드 합계가 17 미만일 때까지 카드를 추가로 받습니다.\n" +
                           "7. 카드 합계가 21을 초과하면 'Bust'로 패배합니다.\n" +
                           "8. 플레이어와 딜러 중 합계가 21에 더 가까운 사람이 승리합니다.\n\n" +
                           "행운을 빕니다!";

            MessageBox.Show(rules, "블랙잭 룰", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 링크 열기
            string url = "https://m.blog.naver.com/thenaeunc/222982054215";
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"링크를 열 수 없습니다. 오류: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
