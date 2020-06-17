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
    public partial class NewDrugForm : Form
    {
        public AdminUser User;
        Api.WebApi api = new Api.WebApi();
        public NewDrugForm()
        {
            InitializeComponent();
        }
        string RRS_Url = "https://recetem.enabiz.gov.tr/";
        string lastRRS_PageContent;


        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPage();

        }

        private void RefreshPage()
        {
            webBrowserRRS.Navigate(RRS_Url);
        }
        public void LockControls()
        {
            textBoxDrugName.Enabled = false;
            textBoxDrugName.BackColor = Color.LightPink;
            textBoxBarcode.Enabled = false;
            textBoxBarcode.BackColor = Color.LightPink;
            buttonSave.Visible = false;
            buttonDrugDetail.Visible = true;
            labelDrugIdInfo.Visible = true;
        }
        public void ResetForm()
        {
            textBoxDrugName.Clear();
            textBoxDrugName.Enabled = true;
            textBoxDrugName.BackColor = Color.White;
            textBoxBarcode.Clear();
            textBoxBarcode.Enabled = true;
            textBoxBarcode.BackColor = Color.White;
            buttonSave.Visible = true;
            buttonDrugDetail.Visible = false;
            labelDrugIdInfo.Visible = false;
            lastRRS_PageContent = "";
            labelDrugID.Text = "";

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textBoxBarcode.Text.Trim() == "" || textBoxDrugName.Text.Trim() == "")
            {
                MessageBox.Show("Barkod veya İlaç Adı boş olamaz!");
                return;
            }

            Drug existingDrug = GetDrugByBarcode(textBoxBarcode.Text);

            if (existingDrug.DrugName.Trim() != "")
            {

                MessageBox.Show("Bu barkod, " + existingDrug.DrugName + " adlı ilaca kayıtlı");
                labelDrugID.Text = existingDrug.ID;
                textBoxDrugName.Text = existingDrug.DrugName;
                LockControls();
                return;
            }


            InsertDrug();

        }

        private Drug GetDrugByBarcode(string barcode)
        {

            Drug drug = api.GetDrugByBarcode(barcode, User);
            return drug;
        }

        private void InsertDrug()
        {
            string barcode = textBoxBarcode.Text;
            string name = textBoxDrugName.Text;

            Drug drug = api.InsertDrug(barcode, name, User);
            labelDrugID.Text = drug.ID;
            LockControls();

            try
            {
                DrugListForm druglistform = (DrugListForm)Application.OpenForms[2];
                druglistform.GetDrugs(false, "");
            }
            catch
            { }


        }

        private void NewDrugForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("NewDrugForm" + User.FullName);
            ResetForm();
            RefreshPage();
            textBoxRRSUrl.Text = RRS_Url;

        }

        private void buttonNewRecord_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void timerRRS_Tick(object sender, EventArgs e)
        {
            try
            {
                if (lastRRS_PageContent != webBrowserRRS.Document.Body.InnerHtml)
                {
                    PageChanged(webBrowserRRS.Document.Body.InnerHtml);
                }

            }
            catch
            {

            }
        }

        private void PageChanged(string content)
        {
            lastRRS_PageContent = content;


            if (webBrowserRRS.Url.ToString() == "https://recetem.enabiz.gov.tr/EBS/Drug")
            {
                try
                {
                    HtmlElement drugsTable = webBrowserRRS.Document.GetElementById("datatable_ajax_wrapper").GetElementsByTagName("tbody")[0];
                    UpdateDrugsTable(drugsTable);
                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());

                }
            }
        }

        private void UpdateDrugsTable(HtmlElement drugsTable)
        {

            timerRRS.Enabled = false;
            ((Control)webBrowserRRS).Enabled = false;


            foreach (HtmlElement row in drugsTable.GetElementsByTagName("tr"))
            {
                HtmlElementCollection cells = row.GetElementsByTagName("td");
                Drug drug = new Drug()
                {
                    Barcode = cells[0].InnerText,
                    DrugName = cells[1].InnerText,
                    SGK_Code = cells[2].InnerText,
                    TITCK_Code = cells[3].InnerText,
                    RRS_CreationDate = cells[4].InnerText,
                    RRS_UpdateDate = cells[5].InnerText,
                    RRS_Status = cells[6].InnerText
                };


                if (cells[6].GetElementsByTagName("span").Count == 0)
                {

                    int updateResult = api.UpdateRRSDrug(drug, User);

                    switch (updateResult)
                    {
                        case 0:
                            cells[6].InnerHtml += "<br><span style='background-color:#ff8080;color:white'>ok</span>";
                            break;
                        case 1:
                            cells[6].InnerHtml += "<br><span style='background-color:#80dfff;color:black'>updated</span>";
                            break;
                        case 2:
                            cells[6].InnerHtml += "<br><span style='background-color:#80ffbf;color:black'>new</span>";
                            break;

                    }
                }


            }



            timerRRS.Enabled = true;
            ((Control)webBrowserRRS).Enabled = true;
        }

        private void buttonDrugDetail_Click(object sender, EventArgs e)
        {
            DrugDetailForm drugDetailForm = new DrugDetailForm();
            drugDetailForm.User = User;
            drugDetailForm.barcode = textBoxBarcode.Text.Trim();
            drugDetailForm.ShowDialog();
        }
    }
}
