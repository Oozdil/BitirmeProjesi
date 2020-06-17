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

    public partial class AddUserForm : Form
    {
        public AdminUser User;
        Api.WebApi api = new Api.WebApi();

        public AddUserForm()
        {
            InitializeComponent();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("AddUserForm" + User.FullName);
            FillAdminCombobox();
            
           
        }
        List<AdminUser> adminList;
        private void FillAdminCombobox()
        {
          
            adminList = api.AdminList(User);
            AdminUser newAdmin = new AdminUser() { UserID = "0", Title = "YENİ", Name = "ADMİN", Surname = "KAYDI" };
            adminList.Insert(0, newAdmin);
            comboBoxUsers.ValueMember = "UserID";
            comboBoxUsers.DisplayMember = "FullName";
            comboBoxUsers.DataSource = adminList;
           





        }

     

        private void comboBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Parent.Focus();

            if (comboBoxUsers.SelectedIndex == 0)
            {
                NewRecord();
            }
            else
            {
                UpdateRecord();
            }
        }

        private void UpdateRecord()
        {
            int index = comboBoxUsers.SelectedIndex;
            AdminUser admin = adminList[index];
            labelID.Text = admin.UserID;
            textBoxName.Text = admin.Name;
            textBoxSurname.Text = admin.Surname;
            textBoxTitle.Text = admin.Title;
            textBoxUserName.Text = admin.Username;
            textBoxPass.Text = admin.Password;
            textBoxPassRepeat.Text = "";

            checkBoxActive.Checked = false;
            if (admin.Active == "1")
                checkBoxActive.Checked = true;
        }

        private void NewRecord()
        {
            labelID.Text = "0";
            checkBoxActive.Checked = true;
            textBoxName.Text = "";
            textBoxSurname.Text = "";
            textBoxTitle.Text = "";
            textBoxUserName.Text = "";
            textBoxPass.Text = "";
            textBoxPassRepeat.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<TextBox> InputFields = new List<TextBox>() { textBoxName,textBoxSurname,textBoxUserName,
                textBoxTitle,textBoxPass,textBoxPassRepeat};
            bool fieldIsEmpty = false;
            foreach (var tx in InputFields)
            {
                if (tx.Text.Trim() == "")
                {
                    fieldIsEmpty = true;

                }
            }

            if (fieldIsEmpty)
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }




            if (InputFields[4].Text != InputFields[5].Text)
            {
                MessageBox.Show("Şifreler eşleşmiyor!");
                return;
            }

            SaveOrInsertAdmin();
        }

        private void SaveOrInsertAdmin()
        {
            if (labelID.Text == "0")
            {
                AdminUser newAdmin = new AdminUser()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Title = textBoxTitle.Text,
                    Username = textBoxUserName.Text,
                    Password = HashingPassWord(textBoxPass.Text)

                };
               
                newAdmin = api.InsertAdmin(newAdmin,User);
                labelID.Text = newAdmin.UserID;
                FillAdminCombobox();
                MessageBox.Show(newAdmin.FullName+" için kayıt tamamlandı!");
            }
            else
            {
                bool active = checkBoxActive.Checked;
                string activeString = "0";
                if (active)
                    activeString = "1";

                AdminUser newAdmin = new AdminUser()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Title = textBoxTitle.Text,
                    Username = textBoxUserName.Text,
                    Password = textBoxPass.Text,
                    UserID = labelID.Text,
                    Active = activeString

                };
               
                api.UpdateAdmin(newAdmin,User);
               
                labelID.Text = newAdmin.UserID;
                FillAdminCombobox();
                MessageBox.Show(newAdmin.FullName + " için düzenleme tamamlandı!");
            }
        }

        private string HashingPassWord(string inputString)
        {
            SHA1 sha = new SHA1CryptoServiceProvider();
            string outputString = Convert.ToBase64String(sha.ComputeHash(Encoding.UTF8.GetBytes(inputString)));
            return outputString;
        }
    }
}
