using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EasyGamePack
{
    public partial class StartForm : Form
    {
        private Timer pulseTimer;
        private int pulseValue = 0;
        private bool pulseIncreasing = true;

        public StartForm()
        {
            InitializeComponent();

            // Paint 이벤트 핸들러 등록
            this.Paint += StartForm_Paint;

            // 버튼 둥글게 만들기
            MakeButtonRound();

            // 버튼 펄스 효과 설정
            SetupPulseEffect();

            try
            {
                picLogo.Image = Image.FromFile("icons/gamepad.png");
            }
            catch (System.IO.FileNotFoundException)
            {
                // 이미지 파일이 없는 경우 무시
            }
        }

        private void StartForm_Paint(object sender, PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(
                this.ClientRectangle,
                Color.FromArgb(48, 51, 107),  // 진한 남색
                Color.FromArgb(218, 62, 82),   // 진한 빨강
                45F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void MakeButtonRound()
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, btnStart.Width, btnStart.Height);
            btnStart.Region = new Region(path);
        }

        private void SetupPulseEffect()
        {
            pulseTimer = new Timer();
            pulseTimer.Interval = 50;
            pulseTimer.Tick += (sender, e) => {
                if (pulseIncreasing)
                {
                    pulseValue += 2;
                    if (pulseValue >= 15)
                        pulseIncreasing = false;
                }
                else
                {
                    pulseValue -= 2;
                    if (pulseValue <= 0)
                        pulseIncreasing = true;
                }

                int baseSize = 140;  // 버튼의 기본 크기
                btnStart.Size = new Size(baseSize + pulseValue, baseSize + pulseValue);
                btnStart.Location = new Point(
                    (this.ClientSize.Width - btnStart.Width) / 2,  // 수평 중앙
                    325 - pulseValue / 2  // 수직 위치 조정
                );
                MakeButtonRound();  // 크기가 변경될 때마다 둥근 모양 유지
            };
            pulseTimer.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pulseTimer.Stop();
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnStart_MouseEnter(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromArgb(241, 196, 15);  // 밝은 노란색
        }

        private void btnStart_MouseLeave(object sender, EventArgs e)
        {
            btnStart.BackColor = Color.FromArgb(243, 156, 18);  // 원래 노란색
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // 타이머가 실행 중이면 중지
            if (pulseTimer != null && pulseTimer.Enabled)
            {
                pulseTimer.Stop();
                pulseTimer.Dispose();
            }
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblGameList_Click(object sender, EventArgs e)
        {

        }
    }
}