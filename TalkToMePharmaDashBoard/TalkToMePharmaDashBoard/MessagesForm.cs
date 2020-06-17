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
    public partial class MessagesForm : Form
    {
        public AdminUser User;
        Api.WebApi api = new Api.WebApi();
        public MessagesForm()
        {
            InitializeComponent();
        }

        private void MessagesForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("MessagesForm" + User.FullName);
            LoadMessages();
            remainingTimeToRefresh = 30;
           
        }
        int remainingTimeToRefresh;
        private void LoadMessages()
        {
           
            var messageList = api.MessagesList(User);
            dataGridViewDrugList.Rows.Clear();

            foreach (var message in messageList)
            {                
                dataGridViewDrugList.Rows.Add(message.BarcodeID,message.Barcode,message.DrugName,message.MessageCount,message.IsComplete,message.LastDate);
            }

            FilterCompleted();
        }

        private void FilterCompleted()
        {
            if (checkBox1.Checked)
            {
                foreach (DataGridViewRow row in dataGridViewDrugList.Rows)
                {                    
                    row.Visible = true;
                }
            }
            else
            {
                foreach (DataGridViewRow row in dataGridViewDrugList.Rows)
                {
                    if (row.Cells[4].Value.ToString() == "TO DO")
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            }
         

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            FilterCompleted();
        }

        private void dataGridViewDrugList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDrugList.SelectedRows.Count > 0)
                labelSelectedDrug.Text = dataGridViewDrugList.SelectedRows[0].Cells[1].Value.ToString() + "-" +
                    dataGridViewDrugList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridViewDrugList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonDrugDetails_Click(object sender, EventArgs e)
        {
            DrugDetailForm drugDetailForm = new DrugDetailForm();
            drugDetailForm.barcode = dataGridViewDrugList.SelectedRows[0].Cells[1].Value.ToString();
            drugDetailForm.ShowDialog();
        }

        private void timerMessages_Tick(object sender, EventArgs e)
        {
            remainingTimeToRefresh--;
            if(remainingTimeToRefresh==0)
            {
                LoadMessages();
                remainingTimeToRefresh = 30;
            }
            labelRemainingToRefresh.Text="Remaining Time To Refresh : "+remainingTimeToRefresh.ToString()+" seconds";
        }
    }
}
