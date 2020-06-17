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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DisplayTimeAndDate();
            SetUserInfo();
            MenuButtonClick(0);
            //MessageBox.Show("MainForm"+User.FullName);
                
      
        }
        DrugListForm drugListForm = new DrugListForm();        
        NewDrugForm newDrugForm = new NewDrugForm();
        MessagesForm messagesForm = new MessagesForm();
        StatisticsForm statisticsForm = new StatisticsForm();
        AboutForm aboutForm = new AboutForm();
        AddUserForm addUserForm = new AddUserForm();
        public AdminUser User;
        

        private void SetUserInfo()
        {
            labelUser.Text = User.FullName;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timerMainForm_Tick(object sender, EventArgs e)
        {
            DisplayTimeAndDate();            
        }

        private void DisplayTimeAndDate()
        {
            labelTime.Text = DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString();
        }
        public void MenuButtonClick(int buttonIndex)
        {
           
            panelBody.Controls.Clear();
            switch (buttonIndex)
            { 
                case 0:                    
                    drugListForm.TopLevel = false;
                    drugListForm.Left = 0;
                    drugListForm.Top = 0;
                    drugListForm.User = User;                   
                    panelBody.Controls.Add(drugListForm);
                    drugListForm.Show();
                    labelPageInfo.Text = "İlaç Listesi";
                    break;
                case 1:                    
                    newDrugForm.TopLevel = false;
                    newDrugForm.Left = 0;
                    newDrugForm.Top = 0;
                    newDrugForm.ResetForm();
                    newDrugForm.User = User;                    
                    panelBody.Controls.Add(newDrugForm);                    
                    newDrugForm.Show();
                    labelPageInfo.Text = "Yeni İlaç Ekleme ";
                    break;
                case 2:                   
                    messagesForm.TopLevel = false;
                    messagesForm.Left = 0;
                    messagesForm.Top = 0;
                    messagesForm.User = User;                   
                    panelBody.Controls.Add(messagesForm);
                    messagesForm.Show();
                    labelPageInfo.Text = "Mesajlar";
                    break;
                case 3:                   
                    statisticsForm.TopLevel = false;
                    statisticsForm.Left = 0;
                    statisticsForm.Top = 0;
                    statisticsForm.User = User;
                    statisticsForm.timerStatistics.Enabled = true;
                    panelBody.Controls.Add(statisticsForm);
                    statisticsForm.Show();
                    labelPageInfo.Text = "İstatistikler";
                    break;
                case 4:                   
                    addUserForm.TopLevel = false;
                    addUserForm.Left = 0;
                    addUserForm.Top = 0;                    
                    addUserForm.User = User;
                    panelBody.Controls.Add(addUserForm);
                    addUserForm.Show();
                    labelPageInfo.Text = "Kullanıcı Ekleme";
                    break;
                case 5:                   
                    aboutForm.TopLevel = false;
                    aboutForm.Left = 0;
                    aboutForm.Top = 0;
                    aboutForm.User = User;
                    panelBody.Controls.Add(aboutForm);
                    aboutForm.Show();
                    labelPageInfo.Text = "Proje Hakkında";
                    break;
                
            
            
            }


        
        }

        private void buttonDrugListPage_Click(object sender, EventArgs e)
        {
            MenuButtonClick(0);
        }

        private void buttonNewDrugPage_Click(object sender, EventArgs e)
        {
            MenuButtonClick(1);
        }

        private void buttonMessagesPage_Click(object sender, EventArgs e)
        {
            MenuButtonClick(2);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            MenuButtonClick(3);
        }

        private void buttonAddNewUserPage_Click(object sender, EventArgs e)
        {
            MenuButtonClick(4);
        }

        private void buttonAboutPage_Click(object sender, EventArgs e)
        {
            MenuButtonClick(5);
        }
    }
}
