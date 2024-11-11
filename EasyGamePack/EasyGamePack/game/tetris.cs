using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public partial class Form1 : Form
    {
        private Tetris tetris;
        private int currentScore = 0;
        private int currentLevel = 1;
        private int clearedLines = 0;
        private bool isPaused = false;
        private bool isGameOver = false;
        private SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1, 1);

        public Form1()
        {
            InitializeComponent();

            // 키보드 입력 설정
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.Focus();

            // 더블 버퍼링 설정
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint, true);

            // 포커스 설정
            this.ActiveControl = null;

            // 폼이 닫힐 때 리소스 해제
            this.FormClosing += new FormClosingEventHandler(Form1_FormClosing);

            // 폼 로드 시 포커스 설정
            this.Load += (s, e) => {
                this.Focus();
                this.BringToFront();
            };
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (!isGameOver && !isPaused)
            {
                switch (keyData)
                {
                    case Keys.Left:
                        tetris.MoveLeft();
                        UpdateDisplay();
                        return true;
                    case Keys.Right:
                        tetris.MoveRight();
                        UpdateDisplay();
                        return true;
                    case Keys.Up:
                        tetris.NextDirection();
                        UpdateDisplay();
                        return true;
                    case Keys.Down:
                        tetris.MoveDown();
                        UpdateDisplay();
                        return true;
                    case Keys.Space:
                        while (tetris.MoveDown()) { }
                        UpdateDisplay();
                        return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGame();
            StartGame();
            this.Focus();
        }

        private void InitializeGame()
        {
            // 게임 패널 설정
            panelGame.BackColor = Color.FromArgb(26, 26, 46); // 진한 남색
            panelNextBlock.BackColor = Color.FromArgb(26, 26, 46);

            // 초기화
            currentScore = 0;
            currentLevel = 1;
            clearedLines = 0;

            // 라벨 업데이트
            labelScore.Text = "점수: 0";
            labelLevel.Text = "레벨: 1";
            labelLines.Text = "줄 수: 0";

            // 게임오버 관련 컨트롤 숨기기
            labelGameOver.Visible = false;
            buttonRestart.Visible = false;
            labelPaused.Visible = false;

            // 테트리스 인스턴스 생성
            tetris = new Tetris(panelGame);

            // 컨트롤 정보 표시
            UpdateControlsInfo();

            // 폼에 포커스 설정
            this.Focus();
        }

        private void UpdateControlsInfo()
        {
            labelControls.Text = "조작 방법:\n" +
                               "← → : 이동\n" +
                               "↑ : 회전\n" +
                               "↓ : 천천히 내리기\n" +
                               "스페이스바: 바로 내리기\n" +
                               "P: 일시정지\n" +
                               "ESC: 종료";
        }

        private async void StartGame()
        {
            isGameOver = false;
            isPaused = false;
            buttonPause.Text = "일시정지";

            tetris.NewBlock();
            await GameLoop();
        }

        private async Task GameLoop()
        {
            while (!isGameOver && !tetris.IsGameOver())
            {
                if (!isPaused)
                {
                    await semaphoreSlim.WaitAsync();
                    try
                    {
                        if (!tetris.MoveDown())
                        {
                            int newLines = tetris.ClearLines();
                            if (newLines > 0)
                            {
                                UpdateScore(newLines);
                                UpdateLines(newLines);
                            }
                            tetris.NewBlock();
                        }

                        UpdateDisplay();
                    }
                    finally
                    {
                        semaphoreSlim.Release();
                    }
                }

                // 레벨에 따른 하강 속도 조절
                int delay = Math.Max(100, 500 - (currentLevel - 1) * 50);
                await Task.Delay(delay);
            }

            GameOver();
        }

        private void UpdateDisplay()
        {
            tetris.DrawBoard(panelGame);
            tetris.DrawNextBlock(panelNextBlock);
        }

        private void UpdateScore(int clearedLines)
        {
            int points = 0;
            switch (clearedLines)
            {
                case 1:
                    points = 100;
                    break;
                case 2:
                    points = 300;
                    break;
                case 3:
                    points = 500;
                    break;
                case 4:
                    points = 800;
                    break;
                default:
                    points = 0;
                    break;
            }

            currentScore += points * currentLevel;
            labelScore.Text = $"점수: {currentScore}";

            // 1000점마다 레벨업
            int newLevel = (currentScore / 1000) + 1;
            if (newLevel != currentLevel)
            {
                currentLevel = newLevel;
                labelLevel.Text = $"레벨: {currentLevel}";
            }
        }

        private void UpdateLines(int newLines)
        {
            clearedLines += newLines;
            labelLines.Text = $"줄 수: {clearedLines}";
        }

        private void GameOver()
        {
            isGameOver = true;
            labelGameOver.Text = "게임 오버!";
            labelGameOver.Visible = true;
            buttonRestart.Visible = true;

            MessageBox.Show($"게임 오버!\n최종 점수: {currentScore}\n달성 레벨: {currentLevel}\n지운 줄 수: {clearedLines}",
                          "게임 종료",
                          MessageBoxButtons.OK,
                          MessageBoxIcon.Information);
        }

        private async void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isGameOver) return;

            await semaphoreSlim.WaitAsync();
            try
            {
                if (e.KeyCode == Keys.P)
                {
                    TogglePause();
                    return;
                }

                if (e.KeyCode == Keys.Escape)
                {
                    Close();
                    return;
                }

                if (isPaused) return;

                e.Handled = true;  // 키 이벤트가 처리되었음을 표시
            }
            finally
            {
                semaphoreSlim.Release();
            }
        }

        private void TogglePause()
        {
            isPaused = !isPaused;
            buttonPause.Text = isPaused ? "계속하기" : "일시정지";
            labelPaused.Visible = isPaused;
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            TogglePause();
            this.Focus();  // 버튼 클릭 후 폼으로 포커스 되돌리기
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            InitializeGame();
            StartGame();
            this.Focus();  // 버튼 클릭 후 폼으로 포커스 되돌리기
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (tetris != null && !isGameOver)
            {
                UpdateDisplay();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isGameOver = true;
            semaphoreSlim.Dispose();
        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            this.Focus();  // 폼이 활성화될 때마다 포커스 설정
        }
    }
}