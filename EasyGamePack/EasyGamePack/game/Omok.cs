using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Omok

{
    public partial class Form1 : Form
    {
        Unit u;
        Graphics g;
        SolidBrush brush;
        Random r = new Random();

        // 난이도 설정 (1: 쉬움, 2: 보통, 3: 어려움)
        private int difficulty = 2;

        // 게임 상태
        private bool gameStarted = false;
        private int blackWins = 0;
        private int whiteWins = 0;

        // 돌들의 위치가 저장될 값
        int[,] Stons = new int[19, 19];
        int[,] Black = new int[19, 19];

        // 게임판 시작 위치와 크기
        private const int BOARD_START_X = 250;  // 게임판 시작 X 좌표
        private const int BOARD_START_Y = 80;   // 게임판 시작 Y 좌표
        private const int CELL_SIZE = 40;      // 각 칸의 크기
        private const int STONE_SIZE = 36;     // 돌의 크기

        public Form1()
        {
            InitializeComponent();

            u = new Unit() { One_size = CELL_SIZE, Stone_size = STONE_SIZE };

            // 폼 크기 설정
            this.Size = new Size(1000, 1000);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "오목 게임";
            this.BackColor = Color.FromArgb(237, 196, 145); // 나무색 배경

            // MouseDown 이벤트 등록
            this.MouseDown += Form1_MouseDown;

            InitializeGame();
        }

        private void InitializeGame()
        {
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    Stons[i, j] = 0;
                    Black[i, j] = 0;
                }
            }
            g = this.CreateGraphics();
            UpdateGameStatus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateGameStatus();
        }

        private void ResetGame()
        {
            InitializeGame();
            UpdateGameStatus();
            this.Invalidate();
        }

        private void UpdateGameStatus()
        {
            string difficultyText;
            if (difficulty == 1) difficultyText = "쉬움";
            else if (difficulty == 2) difficultyText = "보통";
            else difficultyText = "어려움";

            lblScore.Text = $"승점 - 흑: {blackWins} 백: {whiteWins}";
            lblDifficulty.Text = $"난이도: {difficultyText}";
            lblGameStatus.Text = gameStarted ? "게임 진행 중" : "게임 시작 전";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            g = e.Graphics;

            // 게임판 배경 그리기
            g.FillRectangle(new SolidBrush(Color.FromArgb(220, 179, 128)),
                BOARD_START_X - 20, BOARD_START_Y - 20,
                CELL_SIZE * 18 + 40, CELL_SIZE * 18 + 40);

            Pen pen = new Pen(Color.Black);

            // 게임판 그리기
            for (int i = 0; i < 19; i++)
            {
                // 가로줄
                g.DrawLine(pen,
                    BOARD_START_X, BOARD_START_Y + i * u.One_size,
                    BOARD_START_X + u.One_size * 18, BOARD_START_Y + i * u.One_size);

                // 세로줄
                g.DrawLine(pen,
                    BOARD_START_X + i * u.One_size, BOARD_START_Y,
                    BOARD_START_X + i * u.One_size, BOARD_START_Y + u.One_size * 18);
            }

            // 화점 그리기 (바둑판의 점)
            int[] starPoints = { 3, 9, 15 };
            foreach (int x in starPoints)
            {
                foreach (int y in starPoints)
                {
                    g.FillEllipse(new SolidBrush(Color.Black),
                        BOARD_START_X + x * u.One_size - 3,
                        BOARD_START_Y + y * u.One_size - 3,
                        6, 6);
                }
            }

            // 기존 돌 다시 그리기
            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (Stons[i, j] > 0)
                    {
                        Color stoneColor = Black[i, j] == 100 ? Color.Black : Color.White;
                        brush = new SolidBrush(stoneColor);
                        g.FillEllipse(brush,
                            BOARD_START_X + j * u.One_size - u.Stone_size / 2,
                            BOARD_START_Y + i * u.One_size - u.Stone_size / 2,
                            u.Stone_size, u.Stone_size);

                        // 흰 돌에는 테두리 추가
                        if (stoneColor == Color.White)
                        {
                            g.DrawEllipse(new Pen(Color.Black),
                                BOARD_START_X + j * u.One_size - u.Stone_size / 2,
                                BOARD_START_Y + i * u.One_size - u.Stone_size / 2,
                                u.Stone_size, u.Stone_size);
                        }
                    }
                }
            }
        }
        private async void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // 왼쪽 버튼 클릭 확인
            if (e.Button != MouseButtons.Left) return;
            if (!gameStarted) return;

            // 게임판 영역 체크
            if (e.X < BOARD_START_X || e.X > BOARD_START_X + u.One_size * 18 ||
                e.Y < BOARD_START_Y || e.Y > BOARD_START_Y + u.One_size * 18)
                return;

            int x = (e.Y - BOARD_START_Y + u.One_size / 2) / u.One_size;
            int y = (e.X - BOARD_START_X + u.One_size / 2) / u.One_size;

            if (x < 0 || x >= 19 || y < 0 || y >= 19) return;
            if (Stons[x, y] > 0) return;

            await DrawStone(x, y, "Black");
        }

        private async Task<int> DrawStone(int x, int y, string type)
        {
            if (type == "Black")
            {
                Black[x, y] = 100;
            }
            else
            {
                Black[x, y] = 50;
            }

            Stons[x, y] = 1000000000;
            this.Invalidate();

            await Task.Delay(100);

            // 클릭한 주위의 값들을 낮춤
            if (!(x == 0 || y == 0 || x == 18 || y == 18))
            {
                Stons[x, y - 1] -= 1;
                Stons[x + 1, y - 1] -= 1;
                Stons[x - 1, y - 1] -= 1;
                Stons[x - 1, y + 1] -= 1;
                Stons[x - 1, y] -= 1;
                Stons[x + 1, y] -= 1;
                Stons[x + 1, y + 1] -= 1;
                Stons[x, y + 1] -= 1;
            }

            int cnt1; // 가로체크 cnt
            int cnt2; // 세로체크 cnt
            int cnt3; // 대각선 ↘ cnt
            int cnt4; // 대각선 ↙ cnt

            int before1; // 가로체크 before
            int before2; // 세로체크 before
            int before3; // 대각선 ↘ before
            int before4; // 대각선 ↙ before

            for (int i = 0; i < 19; i++)
            {
                cnt1 = 1;
                cnt2 = 1;
                before1 = 10;
                before2 = 10;

                for (int j = 0; j < 19; j++)
                {
                    cnt3 = 0;
                    cnt4 = 0;

                    // 가로 우선순위 찾기
                    if (Stons[i, j] > 0 && Black[i, j] == before1)
                        cnt1++;
                    else
                        cnt1 = 1;
                    before1 = Black[i, j];

                    // 세로 우선순위 찾기
                    if (Stons[j, i] > 0 && Black[j, i] == before2)
                        cnt2++;
                    else
                        cnt2 = 1;
                    before2 = Black[j, i];

                    // 대각선 ↘ 우선순위 찾기
                    if (i + 4 <= 18 && j + 4 <= 18)
                    {
                        before3 = Black[i, j];
                        for (int k = 0; k < 5; k++)
                        {
                            if (Stons[i + k, j + k] > 0 && Black[i + k, j + k] == before3)
                                cnt3++;
                        }
                    }

                    // 대각선 ↙ 우선순위 찾기
                    if (i + 4 <= 18 && j - 4 >= 0)
                    {
                        before4 = Black[i, j];
                        for (int k = 0; k < 5; k++)
                        {
                            if (Stons[i + k, j - k] > 0 && Black[i + k, j - k] == before4)
                                cnt4++;
                        }
                    }

                    // 난이도에 따른 가중치 적용
                    int weightMultiplier = 1;
                    if (difficulty == 2) weightMultiplier = 2;
                    else if (difficulty == 3) weightMultiplier = 3;

                    // 3개를 우선순위 -10, 4개이상은 우선순위 -20
                    // 가로, 세로  j - 3 >= 0 && j + 1 <= 18 돌이 배열 범위를 벗어나는지 체크
                    if (j - 3 >= 0 && j + 1 <= 18)
                    {
                        //가로값
                        if (cnt1 == 3)
                        {
                            Stons[i, j - 3] -= 10 * weightMultiplier;
                            Stons[i, j + 1] -= 10 * weightMultiplier;
                        }
                        else if (cnt1 > 3)
                        {
                            Stons[i, j - 3] -= 20 * weightMultiplier;
                            Stons[i, j + 1] -= 20 * weightMultiplier;
                        }

                        //세로값
                        if (cnt2 == 3)
                        {
                            Stons[j - 3, i] -= 10 * weightMultiplier;
                            Stons[j + 1, i] -= 10 * weightMultiplier;
                        }
                        else if (cnt2 > 3)
                        {
                            Stons[j - 3, i] -= 20 * weightMultiplier;
                            Stons[j + 1, i] -= 20 * weightMultiplier;
                        }
                    }

                    // 대각선 ↘ 값
                    if (i + 4 <= 18 && j + 4 <= 18)
                    {
                        if (cnt3 == 3)
                        {
                            if (i - 1 >= 0 && j - 1 >= 0)
                                Stons[i - 1, j - 1] -= 10 * weightMultiplier;
                            Stons[i + 3, j + 3] -= 10 * weightMultiplier;
                        }
                        else if (cnt3 > 3)
                        {
                            if (i - 1 >= 0 && j - 1 >= 0)
                                Stons[i - 1, j - 1] -= 20 * weightMultiplier;
                            Stons[i + 4, j + 4] -= 20 * weightMultiplier;
                        }
                    }

                    // 대각선 ↙ 값
                    if (i + 4 <= 18 && j - 4 >= 0)
                    {
                        if (cnt4 == 3)
                        {
                            if (i - 1 >= 0 && j + 1 <= 18)
                                Stons[i - 1, j + 1] -= 10 * weightMultiplier;
                            Stons[i + 3, j - 3] -= 10 * weightMultiplier;
                        }
                        else if (cnt4 > 3)
                        {
                            if (i - 1 >= 0 && j + 1 <= 18)
                                Stons[i - 1, j + 1] -= 20 * weightMultiplier;
                            Stons[i + 4, j - 4] -= 20 * weightMultiplier;
                        }
                    }
                }
            }

            if (CheckWin(x, y))
            {
                string winner = Black[x, y] == 100 ? "검은돌" : "흰돌";
                if (Black[x, y] == 100) blackWins++;
                else whiteWins++;

                UpdateGameStatus();
                MessageBox.Show($"{winner} 승리!");
                gameStarted = false;
                ResetGame();
                return 1;
            }

            // 흑돌 차례 후 백돌(봇) 차례
            if (type == "Black")
            {
                await Task.Delay(difficulty == 1 ? 1000 : difficulty == 2 ? 700 : 400);
                await Bot_Click();
            }

            return 1;
        }

        private bool CheckWin(int x, int y)
        {
            int target = Black[x, y];

            // 가로, 세로, 대각선 방향 승리 체크
            int[] dx = { 1, 0, 1, 1 };
            int[] dy = { 0, 1, 1, -1 };

            for (int dir = 0; dir < 4; dir++)
            {
                int count = 1;

                // 정방향 체크
                for (int i = 1; i < 5; i++)
                {
                    int nx = x + dx[dir] * i;
                    int ny = y + dy[dir] * i;
                    if (nx < 0 || nx >= 19 || ny < 0 || ny >= 19) break;
                    if (Black[nx, ny] != target) break;
                    count++;
                }

                // 역방향 체크
                for (int i = 1; i < 5; i++)
                {
                    int nx = x - dx[dir] * i;
                    int ny = y - dy[dir] * i;
                    if (nx < 0 || nx >= 19 || ny < 0 || ny >= 19) break;
                    if (Black[nx, ny] != target) break;
                    count++;
                }

                if (count >= 5) return true;
            }

            return false;
        }

        private async Task Bot_Click()
        {
            List<Bot> location = new List<Bot>();
            int temp = 100;

            for (int i = 0; i < 19; i++)
            {
                for (int j = 0; j < 19; j++)
                {
                    if (Stons[i, j] < temp)
                    {
                        location.Clear();
                        location.Add(new Bot { X = i, Y = j });
                        temp = Stons[i, j];
                    }
                    else if (Stons[i, j] == temp)
                    {
                        location.Add(new Bot { X = i, Y = j });
                    }
                }
            }

            int length = location.Count;

            if (length == 1 || difficulty == 3)  // 어려움 난이도에서는 항상 최적의 수를 선택
            {
                await DrawStone(location[0].X, location[0].Y, "White");
            }
            else
            {
                // 난이도에 따른 랜덤성 조정
                int maxChoices;
                if (difficulty == 1) maxChoices = length;        // 쉬움: 모든 선택지 중에서 랜덤
                else maxChoices = Math.Min(3, length);          // 보통: 상위 3개 중에서 랜덤

                int rnd = r.Next(0, maxChoices);
                await DrawStone(location[rnd].X, location[rnd].Y, "White");
            }
        }

        // 버튼 이벤트 핸들러들
        private void btnStart_Click(object sender, EventArgs e)
        {
            gameStarted = true;
            ResetGame();
            UpdateGameStatus();
            this.Invalidate();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            gameStarted = false;
            ResetGame();
        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            difficulty = 1;
            UpdateGameStatus();
        }

        private void btnNormal_Click(object sender, EventArgs e)
        {
            difficulty = 2;
            UpdateGameStatus();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            difficulty = 3;
            UpdateGameStatus();
        }
    }

    class Unit
    {
        public int Stone_size { get; set; }
        public int One_size { get; set; }
    }

    class Bot
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}