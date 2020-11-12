using Helper;
using Helper.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdministratorManagementSystem
{
    public partial class LoginForm : Form
    {
        private SoundPlayer _player = new SoundPlayer(Properties.Resources.mymusic);
        private bool _isMusicPlayed { get; set; } = false;
        private string _vCode { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            VerificationCode();
            //PlayMusic();
            panel1.BackColor = Color.FromArgb(170, Color.White);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text.Equals("") || textBoxPassword.Text.Equals(""))
            {
                VerificationCode();
                MessageBox.Show("用户名或密码为空");
                return;
            }
            if (!textBoxVerificationCode.Text.Equals(labelCode.Text))
            {
                VerificationCode();
                MessageBox.Show("验证码不正确");
                return;
            }
            try
            {
                var res = AdministratorDataAccess.LoginAdministrator(textBoxUsername.Text, textBoxPassword.Text);
                MainForm mainForm = new MainForm();
                Hide();
                mainForm.ShowDialog();
                Show();
            }
            catch
            {
                VerificationCode();
                MessageBox.Show("登录失败");
            }
        }
        #region 鼠标左键移动窗口
        Point mouseOff;
        bool leftFlag = false;
        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseOff = new Point(-e.X, -e.Y);
                leftFlag = true;
            }
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                Point mouseSet = Control.MousePosition;
                mouseSet.Offset(mouseOff.X, mouseOff.Y);
                this.Location = mouseSet;
            }
        }

        private void LoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (leftFlag)
            {
                leftFlag = false;
            }
        }
        #endregion

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        
        private void VerificationCode()
        {
            Random ran = new Random();
            int number;
            char code;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                number = ran.Next();
                if (number % 2 == 0)
                    code = (char)('0' + (char)(number % 10));
                else
                    code = (char)('A' + (char)(number % 26));
                sb.Append(code.ToString());
            }
            _vCode = sb.ToString();
            labelCode.Text = _vCode;
        }

        private void labelCode_Click(object sender, EventArgs e)
        {
            _vCode = "";
            VerificationCode();
        }
        private void PlayMusic()
        {
            _player.Load();
            _player.PlayLooping();
        }

        private void StopMusic()
        {
            _player.Stop();
        }
        
        private void buttonMusic_Click(object sender, EventArgs e)
        {
            if (_isMusicPlayed == true)
            {
                StopMusic();
                _isMusicPlayed = false;
            }
            else
            {
                PlayMusic();
                _isMusicPlayed = true;
            }
        }

        // 解决闪屏问题
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}

