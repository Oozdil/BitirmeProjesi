using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkToMePharmaDashBoard.Api;

namespace TalkToMePharmaDashBoard
{
    public partial class LoginForm : Form
    {
        Api.WebApi api = new Api.WebApi();


        public LoginForm()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            buttonLogin.Visible = false;
            labelErrorMessage.Text ="";
            string username = textBoxUserName.Text;
            string password = textBoxPassWord.Text;
            password = HashingPassWord(password);
            TryToLogin(username,password);
          
        }

        private void TryToLogin(string username, string password)
        {
            try
            {
                AdminUser adminUser = api.LoginUser(username, password);

                if (adminUser.UserID == "0")
                {
                    labelErrorMessage.Text = "Kullanıcı Adı veya Şifreniz Hatalı!";
                    buttonLogin.Visible = true;
                }
                else
                {
                    buttonLogin.Visible = true;
                    MainForm mainForm = new MainForm();
                    mainForm.User = adminUser;
                    mainForm.Show();                
                    this.Hide();
                }
            }
            catch
            {

            }
        }
        private string HashingPassWord(string inputString)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            string outputString = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(inputString)));
            return outputString;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Test amaçlı
            textBoxUserName.Text = "eczorcun";
            textBoxPassWord.Text = "123";

            labelErrorMessage.Text = "";
            this.ActiveControl = panelContainer;
        }
    }
}
