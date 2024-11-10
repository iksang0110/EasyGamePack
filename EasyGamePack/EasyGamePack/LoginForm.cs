using System;
using System.Drawing;
using System.Windows.Forms;

namespace EasyGamePack
{
    public partial class LoginForm : Form
    {
        private const string CORRECT_ID = "원광대학교";
        private const string CORRECT_PW = "6";

        public LoginForm()
        {
            InitializeComponent();
            this.Text = "이지게임팩 - 로그인";
            this.StartPosition = FormStartPosition.CenterScreen;

            // Paint 이벤트 핸들러 등록
            this.panelMain.Paint += PanelMain_Paint;
        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panelMain.ClientRectangle,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid,
                Color.FromArgb(230, 230, 230), 1, ButtonBorderStyle.Solid);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtId.Text == CORRECT_ID && txtPassword.Text == CORRECT_PW)
            {
                MainForm mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("아이디 또는 비밀번호가 올바르지 않습니다.", "로그인 실패",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtId.Focus();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}