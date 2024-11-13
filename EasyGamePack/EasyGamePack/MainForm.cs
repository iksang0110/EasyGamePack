using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EasyGamePack
{
    public partial class MainForm : Form
    {
        private Color gradientStart = Color.FromArgb(36, 37, 42);
        private Color gradientEnd = Color.FromArgb(48, 50, 62);

        public MainForm()
        {
            InitializeComponent();
            this.Text = "이지게임팩 - 게임 선택";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Paint 이벤트 핸들러 등록
            this.panelMain.Paint += PanelMain_Paint;
            this.panelTop.Paint += PanelTop_Paint;

            InitializeGameIcons();
            SetupHoverEffects();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // 스크롤바 커스터마이징을 위한 설정
            flowGames.MouseWheel += (sender, args) =>
            {
                int scrollValue = args.Delta > 0 ? -50 : 50;
                int newScrollPosition = flowGames.HorizontalScroll.Value + scrollValue;

                if (newScrollPosition < 0)
                    newScrollPosition = 0;
                if (newScrollPosition > flowGames.HorizontalScroll.Maximum)
                    newScrollPosition = flowGames.HorizontalScroll.Maximum;

                flowGames.HorizontalScroll.Value = newScrollPosition;
            };
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                panelMain.ClientRectangle,
                gradientStart,
                gradientEnd,
                45F))
            {
                e.Graphics.FillRectangle(brush, panelMain.ClientRectangle);
            }
        }

        private void PanelTop_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(
                new Pen(Color.FromArgb(60, 63, 65)),
                0, panelTop.Height - 1,
                panelTop.Width, panelTop.Height - 1
            );
        }

        private void InitializeGameIcons()
        {
            try
            {
                picOmok.Image = Image.FromFile("icons/omok.png");
                picTicTacToe.Image = Image.FromFile("icons/tictactoe.png");
                picTetris.Image = Image.FromFile("icons/tetris.png");
                picBlackjack.Image = Image.FromFile("icons/blackjack.png");
                picMemory.Image = Image.FromFile("icons/memory.png");
            }
            catch (System.IO.FileNotFoundException)
            {
                // 이미지 파일이 없는 경우 기본 아이콘 사용
            }
        }

        private void SetupHoverEffects()
        {
            // 오목 패널 호버 효과
            panelOmok.MouseEnter += (s, e) => {
                panelOmok.BackColor = Color.FromArgb(55, 58, 64);
                btnOmok.BackColor = Color.FromArgb(0, 122, 204);
                btnOmok.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            panelOmok.MouseLeave += (s, e) => {
                panelOmok.BackColor = Color.FromArgb(45, 48, 54);
                btnOmok.BackColor = Color.FromArgb(55, 58, 64);
                btnOmok.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };
            // 오목 버튼 호버 효과 추가
            btnOmok.MouseEnter += (s, e) => {
                panelOmok.BackColor = Color.FromArgb(55, 58, 64);
                btnOmok.BackColor = Color.FromArgb(0, 122, 204);
                btnOmok.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            btnOmok.MouseLeave += (s, e) => {
                panelOmok.BackColor = Color.FromArgb(45, 48, 54);
                btnOmok.BackColor = Color.FromArgb(55, 58, 64);
                btnOmok.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };

            // 틱택톡 패널 호버 효과
            panelTicTacToe.MouseEnter += (s, e) => {
                panelTicTacToe.BackColor = Color.FromArgb(55, 58, 64);
                btnTicTacToe.BackColor = Color.FromArgb(0, 122, 204);
                btnTicTacToe.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            panelTicTacToe.MouseLeave += (s, e) => {
                panelTicTacToe.BackColor = Color.FromArgb(45, 48, 54);
                btnTicTacToe.BackColor = Color.FromArgb(55, 58, 64);
                btnTicTacToe.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };
            // 틱택톡 버튼 호버 효과 추가
            btnTicTacToe.MouseEnter += (s, e) => {
                panelTicTacToe.BackColor = Color.FromArgb(55, 58, 64);
                btnTicTacToe.BackColor = Color.FromArgb(0, 122, 204);
                btnTicTacToe.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            btnTicTacToe.MouseLeave += (s, e) => {
                panelTicTacToe.BackColor = Color.FromArgb(45, 48, 54);
                btnTicTacToe.BackColor = Color.FromArgb(55, 58, 64);
                btnTicTacToe.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };

            // 테트리스 패널 호버 효과
            panelTetris.MouseEnter += (s, e) => {
                panelTetris.BackColor = Color.FromArgb(55, 58, 64);
                btnTetris.BackColor = Color.FromArgb(0, 122, 204);
                btnTetris.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            panelTetris.MouseLeave += (s, e) => {
                panelTetris.BackColor = Color.FromArgb(45, 48, 54);
                btnTetris.BackColor = Color.FromArgb(55, 58, 64);
                btnTetris.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };
            // 테트리스 버튼 호버 효과 추가
            btnTetris.MouseEnter += (s, e) => {
                panelTetris.BackColor = Color.FromArgb(55, 58, 64);
                btnTetris.BackColor = Color.FromArgb(0, 122, 204);
                btnTetris.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            btnTetris.MouseLeave += (s, e) => {
                panelTetris.BackColor = Color.FromArgb(45, 48, 54);
                btnTetris.BackColor = Color.FromArgb(55, 58, 64);
                btnTetris.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };

            // 블랙잭 패널 호버 효과
            panelBlackjack.MouseEnter += (s, e) => {
                panelBlackjack.BackColor = Color.FromArgb(55, 58, 64);
                btnBlackjack.BackColor = Color.FromArgb(0, 122, 204);
                btnBlackjack.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            panelBlackjack.MouseLeave += (s, e) => {
                panelBlackjack.BackColor = Color.FromArgb(45, 48, 54);
                btnBlackjack.BackColor = Color.FromArgb(55, 58, 64);
                btnBlackjack.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };
            // 블랙잭 버튼 호버 효과 추가
            btnBlackjack.MouseEnter += (s, e) => {
                panelBlackjack.BackColor = Color.FromArgb(55, 58, 64);
                btnBlackjack.BackColor = Color.FromArgb(0, 122, 204);
                btnBlackjack.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            btnBlackjack.MouseLeave += (s, e) => {
                panelBlackjack.BackColor = Color.FromArgb(45, 48, 54);
                btnBlackjack.BackColor = Color.FromArgb(55, 58, 64);
                btnBlackjack.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };

            // 기억력게임 패널 호버 효과
            panelMemory.MouseEnter += (s, e) => {
                panelMemory.BackColor = Color.FromArgb(55, 58, 64);
                btnMemory.BackColor = Color.FromArgb(0, 122, 204);
                btnMemory.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            panelMemory.MouseLeave += (s, e) => {
                panelMemory.BackColor = Color.FromArgb(45, 48, 54);
                btnMemory.BackColor = Color.FromArgb(55, 58, 64);
                btnMemory.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };
            // 기억력게임 버튼 호버 효과 추가
            btnMemory.MouseEnter += (s, e) => {
                panelMemory.BackColor = Color.FromArgb(55, 58, 64);
                btnMemory.BackColor = Color.FromArgb(0, 122, 204);
                btnMemory.FlatAppearance.BorderColor = Color.FromArgb(0, 122, 204);
            };
            btnMemory.MouseLeave += (s, e) => {
                panelMemory.BackColor = Color.FromArgb(45, 48, 54);
                btnMemory.BackColor = Color.FromArgb(55, 58, 64);
                btnMemory.FlatAppearance.BorderColor = Color.FromArgb(65, 68, 74);
            };
        }

        private void btnOmok_Click(object sender, EventArgs e)
        {
            Omok.Form1 omokForm = new Omok.Form1();
            this.Hide();
            omokForm.ShowDialog();
            this.Show();
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            WindowsFormsApp7.Form1 tictactoeForm = new WindowsFormsApp7.Form1();
            this.Hide();
            tictactoeForm.ShowDialog();
            this.Show();
        }

        private void btnTetris_Click(object sender, EventArgs e)
        {
            TetrisGame.Form1 TetrisGameForm = new TetrisGame.Form1();
            this.Hide();
            TetrisGameForm.ShowDialog();   
            this.Show();
        }

        private void btnBlackjack_Click(object sender, EventArgs e)
        {
            MessageBox.Show("블랙잭 게임이 준비 중입니다.", "알림",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnMemory_Click(object sender, EventArgs e)
        {
            MemoryGame.Form1 MemoryGameForm = new MemoryGame.Form1();
            this.Hide();
            MemoryGameForm.ShowDialog();
            this.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("로그아웃 하시겠습니까?", "로그아웃",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                this.Hide();
                loginForm.ShowDialog();
                this.Close();
            }
        }

        private void panelTop_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void lblOmokDesc_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelTop_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void flowGames_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picTetris_Click(object sender, EventArgs e)
        {

        }
    }
}