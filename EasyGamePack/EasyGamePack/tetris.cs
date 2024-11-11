using System;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisGame
{
    public class Tetris
    {
        public const int Width = 10;
        public const int Height = 20;
        private const int HiddenRows = 4; // 보이지 않는 상단 여유 공간

        private int[,] board;
        private int currentBlock = 0;
        private int nextBlockType = 0;
        private int currentDirection = 0;
        private int currentX = 4;
        private int currentY = 0;

        private Random random = new Random();
        private Panel gamePanel;

        // 테트리스 블록 색상 정의
        private readonly Color[] blockColors = new Color[]
        {
            Color.Cyan,      // I 블록
            Color.Yellow,    // O 블록
            Color.Purple,    // T 블록
            Color.Blue,      // J 블록
            Color.Orange,    // L 블록
            Color.Green,     // S 블록
            Color.Red        // Z 블록
        };

        public Tetris(Panel gamePanel)
        {
            this.gamePanel = gamePanel;
            board = new int[Width, Height + HiddenRows];
            InitializeBoard();
            SetRandomNextBlock();
        }

        private void InitializeBoard()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height + HiddenRows; y++)
                {
                    board[x, y] = 0;
                }
            }
        }

        public void NewBlock()
        {
            currentBlock = nextBlockType;
            SetRandomNextBlock();
            currentDirection = 0;
            currentX = 4;
            currentY = 0;

            if (!CanPlace(currentBlock, currentDirection, currentX, currentY))
            {
                // 게임 오버 상태
                return;
            }

            PlaceBlock();
        }

        private void SetRandomNextBlock()
        {
            nextBlockType = random.Next(7); // 0-6 사이의 랜덤 블록
        }

        public bool MoveDown()
        {
            RemoveBlock();

            if (CanPlace(currentBlock, currentDirection, currentX, currentY + 1))
            {
                currentY++;
                PlaceBlock();
                return true;
            }

            PlaceBlock();
            FixBlock();
            return false;
        }

        public void MoveLeft()
        {
            RemoveBlock();
            if (CanPlace(currentBlock, currentDirection, currentX - 1, currentY))
            {
                currentX--;
            }
            PlaceBlock();
        }

        public void MoveRight()
        {
            RemoveBlock();
            if (CanPlace(currentBlock, currentDirection, currentX + 1, currentY))
            {
                currentX++;
            }
            PlaceBlock();
        }

        public void NextDirection()
        {
            RemoveBlock();
            int nextDir = (currentDirection + 1) % 4;
            if (CanPlace(currentBlock, nextDir, currentX, currentY))
            {
                currentDirection = nextDir;
            }
            PlaceBlock();
        }

        private void RemoveBlock()
        {
            var shape = GetBlockShape(currentBlock, currentDirection);
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    if (shape[i, j] == 1)
                    {
                        int boardX = currentX + i;
                        int boardY = currentY + j;
                        if (IsInBoard(boardX, boardY))
                        {
                            board[boardX, boardY] = 0;
                        }
                    }
                }
            }
        }

        private void PlaceBlock()
        {
            var shape = GetBlockShape(currentBlock, currentDirection);
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    if (shape[i, j] == 1)
                    {
                        int boardX = currentX + i;
                        int boardY = currentY + j;
                        if (IsInBoard(boardX, boardY))
                        {
                            board[boardX, boardY] = currentBlock + 1;
                        }
                    }
                }
            }
        }

        private void FixBlock()
        {
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height + HiddenRows; y++)
                {
                    if (board[x, y] > 0)
                    {
                        board[x, y] = 8; // 고정된 블록은 8로 표시
                    }
                }
            }
        }

        public int ClearLines()
        {
            int linesCleared = 0;
            for (int y = Height + HiddenRows - 1; y >= 0; y--)
            {
                if (IsLineFull(y))
                {
                    ClearLine(y);
                    ShiftLinesDown(y);
                    y++; // 다시 같은 줄 검사
                    linesCleared++;
                }
            }
            return linesCleared;
        }

        private bool IsLineFull(int y)
        {
            for (int x = 0; x < Width; x++)
            {
                if (board[x, y] == 0)
                    return false;
            }
            return true;
        }

        private void ClearLine(int y)
        {
            for (int x = 0; x < Width; x++)
            {
                board[x, y] = 0;
            }
        }

        private void ShiftLinesDown(int clearedLine)
        {
            for (int y = clearedLine; y > 0; y--)
            {
                for (int x = 0; x < Width; x++)
                {
                    board[x, y] = board[x, y - 1];
                }
            }
        }

        private bool CanPlace(int block, int direction, int posX, int posY)
        {
            var shape = GetBlockShape(block, direction);
            for (int i = 0; i < shape.GetLength(0); i++)
            {
                for (int j = 0; j < shape.GetLength(1); j++)
                {
                    if (shape[i, j] == 1)
                    {
                        int boardX = posX + i;
                        int boardY = posY + j;

                        if (!IsInBoard(boardX, boardY) || board[boardX, boardY] == 8)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        private bool IsInBoard(int x, int y)
        {
            return x >= 0 && x < Width && y >= 0 && y < Height + HiddenRows;
        }

        public bool IsGameOver()
        {
            // 상단 4줄에 고정된 블록이 있으면 게임 오버
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < HiddenRows; y++)
                {
                    if (board[x, y] == 8)
                        return true;
                }
            }
            return false;
        }

        public void DrawBoard(Panel panel)
        {
            using (BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(
                panel.CreateGraphics(), panel.ClientRectangle))
            {
                Graphics g = bg.Graphics;
                g.Clear(panel.BackColor);

                // 블록 크기 계산 - 패널 크기에 맞춰 조정
                int blockSize = Math.Min((panel.Height - 4) / Height, (panel.Width - 4) / Width);

                // 보드의 시작 위치를 중앙으로 조정
                int startX = (panel.Width - (blockSize * Width)) / 2;
                int startY = (panel.Height - (blockSize * Height)) / 2;

                // 게임 보드 그리기
                for (int x = 0; x < Width; x++)
                {
                    for (int y = HiddenRows; y < Height + HiddenRows; y++)
                    {
                        int drawX = startX + (x * blockSize);
                        int drawY = startY + ((y - HiddenRows) * blockSize);

                        // 그리드 그리기
                        using (Pen gridPen = new Pen(Color.FromArgb(40, 255, 255, 255)))
                        {
                            g.DrawRectangle(gridPen, drawX, drawY, blockSize, blockSize);
                        }

                        if (board[x, y] > 0)
                        {
                            Color blockColor = board[x, y] == 8 ?
                                Color.Gray : blockColors[board[x, y] - 1];

                            DrawBlock(g, drawX, drawY, blockColor, blockSize);
                        }
                    }
                }

                bg.Render();
            }
        }

        public void DrawNextBlock(Panel panel)
        {
            using (BufferedGraphics bg = BufferedGraphicsManager.Current.Allocate(
                panel.CreateGraphics(), panel.ClientRectangle))
            {
                Graphics g = bg.Graphics;
                g.Clear(panel.BackColor);

                var shape = GetBlockShape(nextBlockType, 0);
                int blockSize = 25; // 다음 블록은 좀 더 작게 표시

                // 다음 블록을 패널 중앙에 위치시키기
                int offsetX = (panel.Width - (shape.GetLength(0) * blockSize)) / 2;
                int offsetY = (panel.Height - (shape.GetLength(1) * blockSize)) / 2;

                for (int i = 0; i < shape.GetLength(0); i++)
                {
                    for (int j = 0; j < shape.GetLength(1); j++)
                    {
                        if (shape[i, j] == 1)
                        {
                            DrawBlock(g, offsetX + (i * blockSize),
                                    offsetY + (j * blockSize),
                                    blockColors[nextBlockType],
                                    blockSize);
                        }
                    }
                }

                bg.Render();
            }
        }

        private void DrawBlock(Graphics g, int x, int y, Color color, int size)
        {
            Rectangle rect = new Rectangle(x, y, size - 1, size - 1);

            // 블록 내부 채우기
            using (SolidBrush brush = new SolidBrush(color))
            {
                g.FillRectangle(brush, rect);
            }

            // 블록 테두리
            using (Pen borderPen = new Pen(Color.FromArgb(100, 0, 0, 0)))
            {
                g.DrawRectangle(borderPen, rect);
            }

            // 하이라이트 효과
            using (Pen lightPen = new Pen(Color.FromArgb(100, 255, 255, 255)))
            {
                g.DrawLine(lightPen, x + 1, y + 1, x + size - 2, y + 1);
                g.DrawLine(lightPen, x + 1, y + 1, x + 1, y + size - 2);
            }
        }

        private int[,] GetBlockShape(int block, int direction)
        {
            switch (block)
            {
                case 0: // I
                    return direction % 2 == 0 ?
                        new int[,] { { 0, 0, 0, 0 }, { 1, 1, 1, 1 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } } :
                        new int[,] { { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 }, { 0, 0, 1, 0 } };

                case 1: // O
                    return new int[,] { { 1, 1 }, { 1, 1 } };

                case 2: // T
                    switch (direction)
                    {
                        case 0: return new int[,] { { 0, 1, 0 }, { 1, 1, 1 }, { 0, 0, 0 } };
                        case 1: return new int[,] { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 1, 0 } };
                        case 2: return new int[,] { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 1, 0 } };
                        case 3: return new int[,] { { 0, 1, 0 }, { 1, 1, 0 }, { 0, 1, 0 } };
                    }
                    break;

                case 3: // J
                    switch (direction)
                    {
                        case 0: return new int[,] { { 1, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 } };
                        case 1: return new int[,] { { 0, 1, 1 }, { 0, 1, 0 }, { 0, 1, 0 } };
                        case 2: return new int[,] { { 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 1 } };
                        case 3: return new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 1, 1, 0 } };
                    }
                    break;

                case 4: // L
                    switch (direction)
                    {
                        case 0: return new int[,] { { 0, 0, 1 }, { 1, 1, 1 }, { 0, 0, 0 } };
                        case 1: return new int[,] { { 0, 1, 0 }, { 0, 1, 0 }, { 0, 1, 1 } };
                        case 2: return new int[,] { { 0, 0, 0 }, { 1, 1, 1 }, { 1, 0, 0 } };
                        case 3: return new int[,] { { 1, 1, 0 }, { 0, 1, 0 }, { 0, 1, 0 } };
                    }
                    break;

                case 5: // S
                    return direction % 2 == 0 ?
                        new int[,] { { 0, 1, 1 }, { 1, 1, 0 }, { 0, 0, 0 } } :
                        new int[,] { { 0, 1, 0 }, { 0, 1, 1 }, { 0, 0, 1 } };

                case 6: // Z
                    return direction % 2 == 0 ?
                        new int[,] { { 1, 1, 0 }, { 0, 1, 1 }, { 0, 0, 0 } } :
                        new int[,] { { 0, 0, 1 }, { 0, 1, 1 }, { 0, 1, 0 } };
            }
            return null;  // 기본값으로 null 반환
        }
    }
}