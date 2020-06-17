using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkToMePharmaDashBoard.Api;

namespace TalkToMePharmaDashBoard
{
    public partial class DrugListForm : Form
    {
        public AdminUser User;
        Api.WebApi api = new Api.WebApi();
        public DrugListForm()
        {
            InitializeComponent();
        }

        private void buttonDrugDetail_Click(object sender, EventArgs e)
        {
            DrugDetailForm drugDetailForm = new DrugDetailForm();
            drugDetailForm.User = User;
            drugDetailForm.barcode = dataGridViewDrugList.SelectedRows[0].Cells[1].Value.ToString();
            drugDetailForm.ShowDialog();
        }

        private void DrugListForm_Load(object sender, EventArgs e)
        {
           // MessageBox.Show("DrugListForm" + User.FullName);
            GetDrugs(false,"");
          
        }


        List<Api.Drug> druglist;
        int totalPages;
        int currentPage;
        public void GetDrugs(bool showPassive,string searchTerm)
        {
          
            druglist = api.DrugList(showPassive, searchTerm,User);
            
           totalPages =Convert.ToInt32( Math.Ceiling( druglist.Count /100.0).ToString());


           if (totalPages > 0)
           {
               currentPage = 1;
               pageNavigate(0);
           }
           else
           {
               dataGridViewDrugList.Rows.Clear();
               labelNavigation.Text = "Kayıt Yok";
           }
        }


        private void pageNavigate(int navigator)
        {
            currentPage += navigator;
            labelNavigation.Text = currentPage.ToString() + " / " + totalPages.ToString();


            buttonFirstPage.Enabled = true;
            buttonPrevPage.Enabled = true;
            buttonNextPage.Enabled = true;
            buttonLastPage.Enabled = true;

            if(currentPage==totalPages)
            {
                buttonNextPage.Enabled = false;
                buttonLastPage.Enabled = false;
            }

            if (currentPage == 1)
            {
                buttonFirstPage.Enabled = false;
                buttonPrevPage.Enabled = false;
            }

            ShowDataGridViewByPageNumber(currentPage);
        }

        private void ShowDataGridViewByPageNumber(int currentPage)
        {
           
            dataGridViewDrugList.Rows.Clear();
            int first=(currentPage-1)*100;
            for (int i =first; i < first+100; i++)
            {
               
                if (i < druglist.Count)
                {
                    
                    Drug drug = druglist[i];
                    dataGridViewDrugList.Rows.Add(drug.ID, drug.Barcode, drug.DrugName, drug.RRS_Status, drug.NameAudioFileExists, drug.DescriptionAudioFileExists,
                       drug.TitckLinkExists, drug.Aktive, drug.DateOfCreate);
                }
            }

        }

        private void dataGridViewDrugList_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewDrugList.SelectedRows.Count > 0)
                labelSelectedDrug.Text = dataGridViewDrugList.SelectedRows[0].Cells[1].Value.ToString() + "-" +
                    dataGridViewDrugList.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void dataGridViewDrugList_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = textBoxSearchBar.Text.ToUpper();
            textBoxSearchBar.Text = searchTerm;
            textBoxSearchBar.SelectionStart = textBoxSearchBar.Text.Length;
            textBoxSearchBar.SelectionLength = 0;

            bool showPassif = false;
            if (checkBoxRRSPasif.Checked)
                showPassif = true;

            if(searchTerm.Length==0 || searchTerm.Length>2)
            GetDrugs(showPassif,searchTerm);

           
        }

     

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            pageNavigate(1-currentPage);
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            pageNavigate(-1);
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            pageNavigate(1);
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            pageNavigate(totalPages- currentPage);
        }

        private void checkBoxRRSPasif_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxRRSPasif.Checked)
            {
                GetDrugs(true, textBoxSearchBar.Text);
            }
            else
            {
                GetDrugs(false, textBoxSearchBar.Text);
            }
        }
    }
}
