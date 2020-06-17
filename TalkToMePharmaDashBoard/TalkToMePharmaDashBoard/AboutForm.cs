using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkToMePharmaDashBoard.Api;

namespace TalkToMePharmaDashBoard
{
    public partial class AboutForm : Form
    {
        public AdminUser User;
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {          
            Api.WebApi api = new Api.WebApi();
            //MessageBox.Show("AboutForm" + User.FullName);
            string aboutText = api.AboutText(User);
            webBrowserAbout.DocumentText = "<body style='background:#181818 url(https://ubs.cbu.edu.tr/images/tulip.png) 50% no-repeat fixed;color:white;'><div style='text-align: justify;font-size: 20px;'>" +
            aboutText
            +"</div></body>";

           
        }
    }
}
