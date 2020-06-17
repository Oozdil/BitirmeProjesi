using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TalkToMePharmaDashBoard.Api;
using ZXing;



namespace TalkToMePharmaDashBoard
{
    public partial class DrugDetailForm : Form
    {
        public DrugDetailForm()
        {
            InitializeComponent();
        }
        public AdminUser User;
        Api.WebApi api = new Api.WebApi();


        #region formDragg
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        # endregion

        public string barcode;
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        Drug drug;

        private void DrugDetailForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("DrugDetailForm" + User.FullName);
            LoadForm();
            CheckForIllegalCrossThreadCalls = false;
            labelTextLen.Text = "Kalan karakter : "+(30000-richTextBoxKTText.Text.Length).ToString();
        }

        private void LoadForm()
        {

            drug = api.GetDrugByBarcode(barcode, User);

            //tab1
            textBoxID.Text = drug.ID;
            textBoxBarcode.Text = drug.Barcode;
            textBoxDrugName.Text = drug.DrugName;
            labelDrugNameHeader.Text = drug.DrugName;
            textBoxSGKCode.Text = drug.SGK_Code;
            textBoxTitckCode.Text = drug.TITCK_Code;
            textBoxRRSCreationDate.Text = drug.RRS_CreationDate;
            textBoxRRSUpdateDate.Text = drug.RRS_UpdateDate;
            textBoxRRSStatus.Text = drug.RRS_Status;
            textBoxCreationDate.Text = drug.DateOfCreate;
            comboBoxActive.SelectedIndex = 0;
            if (drug.Aktive == "1")
                comboBoxActive.SelectedIndex = 1;
            DrawBarcode(drug.Barcode);



            //tab2
            textBoxDrugName2.Text = drug.DrugName;
            textBoxNameSpelling.Text = drug.NameTextFilePath;
            textBoxAudioFilePath.Text = drug.NameAudioFilePath;

            //tab3
            textBoxTitckLink.Text = drug.TitckLink;
            textBoxDescriptionAudioFilePath.Text = drug.DescriptionAudioFilePath;
            richTextBoxKTText.Text = drug.DescriptionTextFilePath;
            webBrowserTitck.Navigate(drug.TitckLink);
        }
        private void DrawBarcode(string _barcode)
        {
            var barcodeWriter = new BarcodeWriter();

            try
            {
                barcodeWriter.Format = BarcodeFormat.EAN_13;
                var image = barcodeWriter.Write(_barcode);
                pictureBoxBarcode.BackgroundImage = image;
                pictureBoxBarcode.Height = 150;
            }
            catch
            {
                barcodeWriter.Format = BarcodeFormat.DATA_MATRIX;
                var image2 = barcodeWriter.Write(_barcode);
                pictureBoxBarcode.BackgroundImage = image2;
                pictureBoxBarcode.Height = 300;
            }
        }
        private void buttonListenToNameSound_Click(object sender, EventArgs e)
        {
            string url = "https://orcun-ozdil.site/FinalYearProject/Files/" + textBoxAudioFilePath.Text;


            wplayer.URL = url;
            wplayer.controls.play();
        }
        private void buttonClose_Click(object sender, EventArgs e)
        {
            wplayer.controls.stop();
            this.Close();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveDrugInfo();
            LoadForm();
        }
        private void buttonEsdegerKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxEsdegerBarkod.Text.Trim() == "")
            {
                MessageBox.Show("Barkod boş olamaz!");
                return;
            }

            Drug existingDrug = GetDrugByBarcode(textBoxEsdegerBarkod.Text);

            if (existingDrug.DrugName.Trim() != "")
            {

                MessageBox.Show("Bu barkod, \n" + existingDrug.DrugName + " \nadlı ilaca kayıtlı");
                return;
            }


            InsertDrug();
        }
        private void comboBoxActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControlDrugDetails.Focus();
        }
        private void buttonCreateNameSound_Click(object sender, EventArgs e)
        {
            textBoxAudioFilePath.Text = "NameAudioFiles/" + drug.Barcode + ".mp3";

            CreateSoundFileForm createSoundFileForm = new CreateSoundFileForm();
            createSoundFileForm.User = User;
            createSoundFileForm.barcode = drug.Barcode;
            createSoundFileForm.type = 0;
            createSoundFileForm.text = textBoxNameSpelling.Text;
            createSoundFileForm.ShowDialog();

            SaveDrugInfo();
        }
        private void timerDrugDetails_Tick(object sender, EventArgs e)
        {
            if (wplayer.playState.ToString().Trim() == "wmppsPlaying" || wplayer.playState.ToString().Trim() == "wmppsTransitioning")
            {
                buttonListenToNameSound.Visible = false;
                buttonListenDescription.Visible = false;
            }
            else
            {
                buttonListenToNameSound.Visible = true;
                buttonListenDescription.Visible = true;
            }
        }
        private void buttonCreateDescriptionFile_Click(object sender, EventArgs e)
        {
            textBoxDescriptionAudioFilePath.Text = "DescriptionAudioFiles/" + drug.Barcode + ".mp3";

            int maxLen = 30000;
            if (richTextBoxKTText.Text.Length >= maxLen)
            {
                MessageBox.Show(maxLen.ToString()+" sınırını aştınız, lütfen kısaltma yoluna gidiniz...");
                return;
            }

            CreateSoundFileForm createSoundFileForm = new CreateSoundFileForm();
            createSoundFileForm.User = User;
            createSoundFileForm.barcode = drug.Barcode;
            createSoundFileForm.type = 1;
            createSoundFileForm.text = richTextBoxKTText.Text;
            createSoundFileForm.ShowDialog();
            SaveDrugInfo();
        }
        private void buttonListenDescription_Click(object sender, EventArgs e)
        {
            string url = "https://orcun-ozdil.site/FinalYearProject/Files/" + textBoxDescriptionAudioFilePath.Text;


            wplayer.URL = url;
            wplayer.controls.play();
        }
        private void buttonChangeKtLink_Click(object sender, EventArgs e)
        {
            webBrowserTitck.Navigate(textBoxTitckLink.Text);
        }
        private void buttonChangeText_Click(object sender, EventArgs e)
        {
            string originalText = textBoxOrijinalText.Text.Trim();
            string newText = textBoxReplaceText.Text;


            string fullText = richTextBoxKTText.Text.Trim();
            int countBefore = Regex.Matches(fullText, originalText).Count;


            fullText = fullText.Replace(originalText, newText);
            richTextBoxKTText.Text = fullText;

            int countAfter = Regex.Matches(fullText, originalText).Count;
            MessageBox.Show((countBefore - countAfter).ToString() + " adet değişiklik yapıldı");
        }
        private void buttonAllToLower_Click(object sender, EventArgs e)
        {
            string fullText = richTextBoxKTText.Text.Trim();
            fullText = fullText.ToLower();
            richTextBoxKTText.Text = fullText;
        }


        private void SaveDrugInfo()
        {

            Drug drugToUpdate = new Drug()
            {
                ID = drug.ID,
                Barcode = drug.Barcode,
                DrugName = textBoxDrugName.Text,
                DateOfCreate = textBoxCreationDate.Text,
                NameAudioFilePath = textBoxAudioFilePath.Text,
                DescriptionAudioFilePath = textBoxDescriptionAudioFilePath.Text,
                DescriptionTextFilePath = richTextBoxKTText.Text,
                NameTextFilePath = textBoxNameSpelling.Text,
                RRS_CreationDate = textBoxRRSCreationDate.Text,
                RRS_Status = textBoxRRSStatus.Text,
                RRS_UpdateDate = textBoxRRSUpdateDate.Text,
                SGK_Code = textBoxSGKCode.Text,
                TITCK_Code = textBoxTitckCode.Text,
                TitckLink = textBoxTitckLink.Text,
                Aktive = comboBoxActive.SelectedIndex.ToString()
            };

            
            // var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(drugToUpdate);
            // var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<Drug>(jsonString);


            api.UpdateFullDrug(drugToUpdate, User);
            MessageBox.Show(drugToUpdate.DrugName+" bilgileri güncellendi...");


        }
        private Drug GetDrugByBarcode(string barcode)
        {

            Drug drug = api.GetDrugByBarcode(barcode, User);
            return drug;
        }
        private void InsertDrug()
        {
            string barcode = textBoxEsdegerBarkod.Text;

            string insertedID = (api.InsertDrug(barcode, drug.DrugName, User)).ID;

            Drug drugToFullAdd = new Drug()
            {
                ID = insertedID,
                Barcode = drug.Barcode,
                DrugName = textBoxDrugName.Text,
                DateOfCreate = textBoxCreationDate.Text,
                NameAudioFilePath = textBoxAudioFilePath.Text,
                DescriptionAudioFilePath = textBoxDescriptionAudioFilePath.Text,
                DescriptionTextFilePath = richTextBoxKTText.Text,
                NameTextFilePath = textBoxNameSpelling.Text,
                RRS_CreationDate = textBoxRRSCreationDate.Text,
                RRS_Status = textBoxRRSStatus.Text,
                RRS_UpdateDate = textBoxRRSUpdateDate.Text,
                SGK_Code = textBoxSGKCode.Text,
                TITCK_Code = textBoxTitckCode.Text,
                TitckLink = textBoxTitckLink.Text,
                Aktive = comboBoxActive.SelectedIndex.ToString()
            };


            api.UpdateFullDrug(drugToFullAdd, User);

            MessageBox.Show("Eşdeğer İlac Eklendi");


        }




        private void buttonCancel_Click(object sender, EventArgs e)
        {
            LoadForm();
        }

        private void tabControlDrugDetails_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControlDrugDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            wplayer.controls.stop();
        }

        private void richTextBoxKTText_TextChanged(object sender, EventArgs e)
        {
            labelTextLen.Text = "Kalan karakter : " + (30000 - richTextBoxKTText.Text.Length).ToString();
        }





















    }
}
