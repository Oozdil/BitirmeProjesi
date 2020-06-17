namespace TalkToMePharmaDashBoard
{
    partial class DrugDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlDrugDetails = new System.Windows.Forms.TabControl();
            this.tabPageTextDetails = new System.Windows.Forms.TabPage();
            this.comboBoxActive = new System.Windows.Forms.ComboBox();
            this.groupBoxEsdeger = new System.Windows.Forms.GroupBox();
            this.labelForEsdegerBarkod = new System.Windows.Forms.Label();
            this.buttonEsdegerKaydet = new System.Windows.Forms.Button();
            this.textBoxEsdegerBarkod = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelForActive = new System.Windows.Forms.Label();
            this.textBoxCreationDate = new System.Windows.Forms.TextBox();
            this.labelForCreationDate = new System.Windows.Forms.Label();
            this.pictureBoxBarcode = new System.Windows.Forms.PictureBox();
            this.textBoxRRSStatus = new System.Windows.Forms.TextBox();
            this.labelForRRSStatus = new System.Windows.Forms.Label();
            this.textBoxRRSUpdateDate = new System.Windows.Forms.TextBox();
            this.labelForRRsUpdateDate = new System.Windows.Forms.Label();
            this.textBoxRRSCreationDate = new System.Windows.Forms.TextBox();
            this.labelForRRSCreationDate = new System.Windows.Forms.Label();
            this.textBoxTitckCode = new System.Windows.Forms.TextBox();
            this.labelForTitckCode = new System.Windows.Forms.Label();
            this.textBoxSGKCode = new System.Windows.Forms.TextBox();
            this.labelForSGKCode = new System.Windows.Forms.Label();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.labelForDrugName = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.labelForBarcode = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelForID = new System.Windows.Forms.Label();
            this.tabPageNameDetails = new System.Windows.Forms.TabPage();
            this.buttonCreateNameSound = new System.Windows.Forms.Button();
            this.textBoxAudioFilePath = new System.Windows.Forms.TextBox();
            this.labelForAudioFilePath = new System.Windows.Forms.Label();
            this.buttonListenToNameSound = new System.Windows.Forms.Button();
            this.textBoxNameSpelling = new System.Windows.Forms.TextBox();
            this.labelForNameSpelling = new System.Windows.Forms.Label();
            this.textBoxDrugName2 = new System.Windows.Forms.TextBox();
            this.labelForDrugName2 = new System.Windows.Forms.Label();
            this.tabPageDescriptionDetails = new System.Windows.Forms.TabPage();
            this.labelTextLen = new System.Windows.Forms.Label();
            this.buttonCreateDescriptionFile = new System.Windows.Forms.Button();
            this.labelForDescriptionAudioFilePath = new System.Windows.Forms.Label();
            this.textBoxDescriptionAudioFilePath = new System.Windows.Forms.TextBox();
            this.groupBoxChangeText = new System.Windows.Forms.GroupBox();
            this.buttonAllToLower = new System.Windows.Forms.Button();
            this.buttonChangeText = new System.Windows.Forms.Button();
            this.labelForReplaceText = new System.Windows.Forms.Label();
            this.textBoxReplaceText = new System.Windows.Forms.TextBox();
            this.labelForOriginalText = new System.Windows.Forms.Label();
            this.textBoxOrijinalText = new System.Windows.Forms.TextBox();
            this.buttonListenDescription = new System.Windows.Forms.Button();
            this.buttonChangeKtLink = new System.Windows.Forms.Button();
            this.richTextBoxKTText = new System.Windows.Forms.RichTextBox();
            this.webBrowserTitck = new System.Windows.Forms.WebBrowser();
            this.textBoxTitckLink = new System.Windows.Forms.TextBox();
            this.labelForKTLink = new System.Windows.Forms.Label();
            this.labelDrugNameHeader = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.timerDrugDetails = new System.Windows.Forms.Timer(this.components);
            this.tabControlDrugDetails.SuspendLayout();
            this.tabPageTextDetails.SuspendLayout();
            this.groupBoxEsdeger.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).BeginInit();
            this.tabPageNameDetails.SuspendLayout();
            this.tabPageDescriptionDetails.SuspendLayout();
            this.groupBoxChangeText.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlDrugDetails
            // 
            this.tabControlDrugDetails.Controls.Add(this.tabPageTextDetails);
            this.tabControlDrugDetails.Controls.Add(this.tabPageNameDetails);
            this.tabControlDrugDetails.Controls.Add(this.tabPageDescriptionDetails);
            this.tabControlDrugDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlDrugDetails.Location = new System.Drawing.Point(9, 43);
            this.tabControlDrugDetails.Name = "tabControlDrugDetails";
            this.tabControlDrugDetails.SelectedIndex = 0;
            this.tabControlDrugDetails.Size = new System.Drawing.Size(1096, 574);
            this.tabControlDrugDetails.TabIndex = 0;
            this.tabControlDrugDetails.SelectedIndexChanged += new System.EventHandler(this.tabControlDrugDetails_SelectedIndexChanged);
            this.tabControlDrugDetails.TabIndexChanged += new System.EventHandler(this.tabControlDrugDetails_TabIndexChanged);
            // 
            // tabPageTextDetails
            // 
            this.tabPageTextDetails.BackColor = System.Drawing.Color.Navy;
            this.tabPageTextDetails.Controls.Add(this.comboBoxActive);
            this.tabPageTextDetails.Controls.Add(this.groupBoxEsdeger);
            this.tabPageTextDetails.Controls.Add(this.buttonCancel);
            this.tabPageTextDetails.Controls.Add(this.buttonSave);
            this.tabPageTextDetails.Controls.Add(this.labelForActive);
            this.tabPageTextDetails.Controls.Add(this.textBoxCreationDate);
            this.tabPageTextDetails.Controls.Add(this.labelForCreationDate);
            this.tabPageTextDetails.Controls.Add(this.pictureBoxBarcode);
            this.tabPageTextDetails.Controls.Add(this.textBoxRRSStatus);
            this.tabPageTextDetails.Controls.Add(this.labelForRRSStatus);
            this.tabPageTextDetails.Controls.Add(this.textBoxRRSUpdateDate);
            this.tabPageTextDetails.Controls.Add(this.labelForRRsUpdateDate);
            this.tabPageTextDetails.Controls.Add(this.textBoxRRSCreationDate);
            this.tabPageTextDetails.Controls.Add(this.labelForRRSCreationDate);
            this.tabPageTextDetails.Controls.Add(this.textBoxTitckCode);
            this.tabPageTextDetails.Controls.Add(this.labelForTitckCode);
            this.tabPageTextDetails.Controls.Add(this.textBoxSGKCode);
            this.tabPageTextDetails.Controls.Add(this.labelForSGKCode);
            this.tabPageTextDetails.Controls.Add(this.textBoxDrugName);
            this.tabPageTextDetails.Controls.Add(this.labelForDrugName);
            this.tabPageTextDetails.Controls.Add(this.textBoxBarcode);
            this.tabPageTextDetails.Controls.Add(this.labelForBarcode);
            this.tabPageTextDetails.Controls.Add(this.textBoxID);
            this.tabPageTextDetails.Controls.Add(this.labelForID);
            this.tabPageTextDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageTextDetails.Name = "tabPageTextDetails";
            this.tabPageTextDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextDetails.Size = new System.Drawing.Size(1088, 545);
            this.tabPageTextDetails.TabIndex = 0;
            this.tabPageTextDetails.Text = "İlaç Detayları";
            // 
            // comboBoxActive
            // 
            this.comboBoxActive.FormattingEnabled = true;
            this.comboBoxActive.Items.AddRange(new object[] {
            "Aktif",
            "Pasif"});
            this.comboBoxActive.Location = new System.Drawing.Point(239, 373);
            this.comboBoxActive.Name = "comboBoxActive";
            this.comboBoxActive.Size = new System.Drawing.Size(423, 24);
            this.comboBoxActive.TabIndex = 29;
            this.comboBoxActive.SelectedIndexChanged += new System.EventHandler(this.comboBoxActive_SelectedIndexChanged);
            // 
            // groupBoxEsdeger
            // 
            this.groupBoxEsdeger.Controls.Add(this.labelForEsdegerBarkod);
            this.groupBoxEsdeger.Controls.Add(this.buttonEsdegerKaydet);
            this.groupBoxEsdeger.Controls.Add(this.textBoxEsdegerBarkod);
            this.groupBoxEsdeger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxEsdeger.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxEsdeger.Location = new System.Drawing.Point(545, 426);
            this.groupBoxEsdeger.Name = "groupBoxEsdeger";
            this.groupBoxEsdeger.Size = new System.Drawing.Size(440, 92);
            this.groupBoxEsdeger.TabIndex = 28;
            this.groupBoxEsdeger.TabStop = false;
            this.groupBoxEsdeger.Text = "Aynı Bilgilerle Eşdeğer Ekle";
            // 
            // labelForEsdegerBarkod
            // 
            this.labelForEsdegerBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForEsdegerBarkod.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForEsdegerBarkod.Location = new System.Drawing.Point(8, 39);
            this.labelForEsdegerBarkod.Name = "labelForEsdegerBarkod";
            this.labelForEsdegerBarkod.Size = new System.Drawing.Size(97, 20);
            this.labelForEsdegerBarkod.TabIndex = 27;
            this.labelForEsdegerBarkod.Text = "YENİ BARKOD :";
            this.labelForEsdegerBarkod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEsdegerKaydet
            // 
            this.buttonEsdegerKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEsdegerKaydet.Location = new System.Drawing.Point(259, 32);
            this.buttonEsdegerKaydet.Name = "buttonEsdegerKaydet";
            this.buttonEsdegerKaydet.Size = new System.Drawing.Size(175, 34);
            this.buttonEsdegerKaydet.TabIndex = 24;
            this.buttonEsdegerKaydet.Text = "Eşdeğer Oluştur";
            this.buttonEsdegerKaydet.UseVisualStyleBackColor = true;
            this.buttonEsdegerKaydet.Click += new System.EventHandler(this.buttonEsdegerKaydet_Click);
            // 
            // textBoxEsdegerBarkod
            // 
            this.textBoxEsdegerBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxEsdegerBarkod.Location = new System.Drawing.Point(109, 39);
            this.textBoxEsdegerBarkod.Name = "textBoxEsdegerBarkod";
            this.textBoxEsdegerBarkod.Size = new System.Drawing.Size(127, 23);
            this.textBoxEsdegerBarkod.TabIndex = 25;
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCancel.Location = new System.Drawing.Point(399, 439);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(119, 79);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "VAZGEÇ";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(239, 439);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(128, 79);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "KAYDET";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelForActive
            // 
            this.labelForActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForActive.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForActive.Location = new System.Drawing.Point(66, 372);
            this.labelForActive.Name = "labelForActive";
            this.labelForActive.Size = new System.Drawing.Size(163, 20);
            this.labelForActive.TabIndex = 20;
            this.labelForActive.Text = "AKTİF Mİ ?";
            this.labelForActive.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxCreationDate
            // 
            this.textBoxCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCreationDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxCreationDate.Location = new System.Drawing.Point(239, 343);
            this.textBoxCreationDate.Name = "textBoxCreationDate";
            this.textBoxCreationDate.Size = new System.Drawing.Size(423, 23);
            this.textBoxCreationDate.TabIndex = 19;
            // 
            // labelForCreationDate
            // 
            this.labelForCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForCreationDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForCreationDate.Location = new System.Drawing.Point(66, 344);
            this.labelForCreationDate.Name = "labelForCreationDate";
            this.labelForCreationDate.Size = new System.Drawing.Size(163, 20);
            this.labelForCreationDate.TabIndex = 18;
            this.labelForCreationDate.Text = "OLUŞTURULMA";
            this.labelForCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBoxBarcode
            // 
            this.pictureBoxBarcode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxBarcode.Location = new System.Drawing.Point(735, 145);
            this.pictureBoxBarcode.Name = "pictureBoxBarcode";
            this.pictureBoxBarcode.Size = new System.Drawing.Size(250, 250);
            this.pictureBoxBarcode.TabIndex = 16;
            this.pictureBoxBarcode.TabStop = false;
            // 
            // textBoxRRSStatus
            // 
            this.textBoxRRSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRRSStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRRSStatus.Location = new System.Drawing.Point(239, 314);
            this.textBoxRRSStatus.Name = "textBoxRRSStatus";
            this.textBoxRRSStatus.Size = new System.Drawing.Size(423, 23);
            this.textBoxRRSStatus.TabIndex = 15;
            // 
            // labelForRRSStatus
            // 
            this.labelForRRSStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForRRSStatus.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForRRSStatus.Location = new System.Drawing.Point(66, 316);
            this.labelForRRSStatus.Name = "labelForRRSStatus";
            this.labelForRRSStatus.Size = new System.Drawing.Size(163, 20);
            this.labelForRRSStatus.TabIndex = 14;
            this.labelForRRSStatus.Text = "RRS DURUMU";
            this.labelForRRSStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRRSUpdateDate
            // 
            this.textBoxRRSUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRRSUpdateDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRRSUpdateDate.Location = new System.Drawing.Point(239, 285);
            this.textBoxRRSUpdateDate.Name = "textBoxRRSUpdateDate";
            this.textBoxRRSUpdateDate.Size = new System.Drawing.Size(423, 23);
            this.textBoxRRSUpdateDate.TabIndex = 13;
            // 
            // labelForRRsUpdateDate
            // 
            this.labelForRRsUpdateDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForRRsUpdateDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForRRsUpdateDate.Location = new System.Drawing.Point(66, 287);
            this.labelForRRsUpdateDate.Name = "labelForRRsUpdateDate";
            this.labelForRRsUpdateDate.Size = new System.Drawing.Size(163, 20);
            this.labelForRRsUpdateDate.TabIndex = 12;
            this.labelForRRsUpdateDate.Text = "RRS GÜNCELLEME";
            this.labelForRRsUpdateDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxRRSCreationDate
            // 
            this.textBoxRRSCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxRRSCreationDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxRRSCreationDate.Location = new System.Drawing.Point(239, 256);
            this.textBoxRRSCreationDate.Name = "textBoxRRSCreationDate";
            this.textBoxRRSCreationDate.Size = new System.Drawing.Size(423, 23);
            this.textBoxRRSCreationDate.TabIndex = 11;
            // 
            // labelForRRSCreationDate
            // 
            this.labelForRRSCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForRRSCreationDate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForRRSCreationDate.Location = new System.Drawing.Point(66, 257);
            this.labelForRRSCreationDate.Name = "labelForRRSCreationDate";
            this.labelForRRSCreationDate.Size = new System.Drawing.Size(163, 20);
            this.labelForRRSCreationDate.TabIndex = 10;
            this.labelForRRSCreationDate.Text = "RRS OLUŞTURMA";
            this.labelForRRSCreationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTitckCode
            // 
            this.textBoxTitckCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTitckCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTitckCode.Location = new System.Drawing.Point(239, 227);
            this.textBoxTitckCode.Name = "textBoxTitckCode";
            this.textBoxTitckCode.Size = new System.Drawing.Size(423, 23);
            this.textBoxTitckCode.TabIndex = 9;
            // 
            // labelForTitckCode
            // 
            this.labelForTitckCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForTitckCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForTitckCode.Location = new System.Drawing.Point(66, 227);
            this.labelForTitckCode.Name = "labelForTitckCode";
            this.labelForTitckCode.Size = new System.Drawing.Size(163, 20);
            this.labelForTitckCode.TabIndex = 8;
            this.labelForTitckCode.Text = "TITCK KODU";
            this.labelForTitckCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxSGKCode
            // 
            this.textBoxSGKCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSGKCode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxSGKCode.Location = new System.Drawing.Point(239, 198);
            this.textBoxSGKCode.Name = "textBoxSGKCode";
            this.textBoxSGKCode.Size = new System.Drawing.Size(423, 23);
            this.textBoxSGKCode.TabIndex = 7;
            // 
            // labelForSGKCode
            // 
            this.labelForSGKCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForSGKCode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForSGKCode.Location = new System.Drawing.Point(66, 199);
            this.labelForSGKCode.Name = "labelForSGKCode";
            this.labelForSGKCode.Size = new System.Drawing.Size(163, 20);
            this.labelForSGKCode.TabIndex = 6;
            this.labelForSGKCode.Text = "SGK KODU";
            this.labelForSGKCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDrugName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDrugName.Location = new System.Drawing.Point(239, 90);
            this.textBoxDrugName.Multiline = true;
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(746, 44);
            this.textBoxDrugName.TabIndex = 5;
            // 
            // labelForDrugName
            // 
            this.labelForDrugName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForDrugName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForDrugName.Location = new System.Drawing.Point(66, 100);
            this.labelForDrugName.Name = "labelForDrugName";
            this.labelForDrugName.Size = new System.Drawing.Size(163, 20);
            this.labelForDrugName.TabIndex = 4;
            this.labelForDrugName.Text = "İSİM";
            this.labelForDrugName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxBarcode.Location = new System.Drawing.Point(239, 169);
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.ReadOnly = true;
            this.textBoxBarcode.Size = new System.Drawing.Size(423, 23);
            this.textBoxBarcode.TabIndex = 3;
            // 
            // labelForBarcode
            // 
            this.labelForBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForBarcode.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForBarcode.Location = new System.Drawing.Point(66, 169);
            this.labelForBarcode.Name = "labelForBarcode";
            this.labelForBarcode.Size = new System.Drawing.Size(163, 20);
            this.labelForBarcode.TabIndex = 2;
            this.labelForBarcode.Text = "BARKOD";
            this.labelForBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxID.Location = new System.Drawing.Point(239, 140);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.ReadOnly = true;
            this.textBoxID.Size = new System.Drawing.Size(423, 23);
            this.textBoxID.TabIndex = 1;
            // 
            // labelForID
            // 
            this.labelForID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForID.Location = new System.Drawing.Point(66, 137);
            this.labelForID.Name = "labelForID";
            this.labelForID.Size = new System.Drawing.Size(163, 23);
            this.labelForID.TabIndex = 0;
            this.labelForID.Text = "ID";
            this.labelForID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPageNameDetails
            // 
            this.tabPageNameDetails.BackColor = System.Drawing.Color.Navy;
            this.tabPageNameDetails.Controls.Add(this.buttonCreateNameSound);
            this.tabPageNameDetails.Controls.Add(this.textBoxAudioFilePath);
            this.tabPageNameDetails.Controls.Add(this.labelForAudioFilePath);
            this.tabPageNameDetails.Controls.Add(this.buttonListenToNameSound);
            this.tabPageNameDetails.Controls.Add(this.textBoxNameSpelling);
            this.tabPageNameDetails.Controls.Add(this.labelForNameSpelling);
            this.tabPageNameDetails.Controls.Add(this.textBoxDrugName2);
            this.tabPageNameDetails.Controls.Add(this.labelForDrugName2);
            this.tabPageNameDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageNameDetails.Name = "tabPageNameDetails";
            this.tabPageNameDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNameDetails.Size = new System.Drawing.Size(1088, 545);
            this.tabPageNameDetails.TabIndex = 1;
            this.tabPageNameDetails.Text = "İsim Detayları";
            // 
            // buttonCreateNameSound
            // 
            this.buttonCreateNameSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateNameSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateNameSound.Location = new System.Drawing.Point(749, 111);
            this.buttonCreateNameSound.Name = "buttonCreateNameSound";
            this.buttonCreateNameSound.Size = new System.Drawing.Size(198, 150);
            this.buttonCreateNameSound.TabIndex = 15;
            this.buttonCreateNameSound.Text = "İSİM DOSYASINI OLUŞTUR VEYA DÜZELT";
            this.buttonCreateNameSound.UseVisualStyleBackColor = true;
            this.buttonCreateNameSound.Click += new System.EventHandler(this.buttonCreateNameSound_Click);
            // 
            // textBoxAudioFilePath
            // 
            this.textBoxAudioFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAudioFilePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxAudioFilePath.Location = new System.Drawing.Point(186, 392);
            this.textBoxAudioFilePath.Multiline = true;
            this.textBoxAudioFilePath.Name = "textBoxAudioFilePath";
            this.textBoxAudioFilePath.ReadOnly = true;
            this.textBoxAudioFilePath.Size = new System.Drawing.Size(546, 36);
            this.textBoxAudioFilePath.TabIndex = 13;
            // 
            // labelForAudioFilePath
            // 
            this.labelForAudioFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForAudioFilePath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForAudioFilePath.Location = new System.Drawing.Point(186, 365);
            this.labelForAudioFilePath.Name = "labelForAudioFilePath";
            this.labelForAudioFilePath.Size = new System.Drawing.Size(198, 20);
            this.labelForAudioFilePath.TabIndex = 12;
            this.labelForAudioFilePath.Text = "İSİM AUDİO DOSYA YOLU";
            this.labelForAudioFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonListenToNameSound
            // 
            this.buttonListenToNameSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListenToNameSound.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonListenToNameSound.Location = new System.Drawing.Point(749, 392);
            this.buttonListenToNameSound.Name = "buttonListenToNameSound";
            this.buttonListenToNameSound.Size = new System.Drawing.Size(198, 36);
            this.buttonListenToNameSound.TabIndex = 10;
            this.buttonListenToNameSound.Text = "İSİM DOSYASINI DİNLE";
            this.buttonListenToNameSound.UseVisualStyleBackColor = true;
            this.buttonListenToNameSound.Click += new System.EventHandler(this.buttonListenToNameSound_Click);
            // 
            // textBoxNameSpelling
            // 
            this.textBoxNameSpelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxNameSpelling.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxNameSpelling.Location = new System.Drawing.Point(186, 186);
            this.textBoxNameSpelling.Multiline = true;
            this.textBoxNameSpelling.Name = "textBoxNameSpelling";
            this.textBoxNameSpelling.Size = new System.Drawing.Size(546, 75);
            this.textBoxNameSpelling.TabIndex = 9;
            // 
            // labelForNameSpelling
            // 
            this.labelForNameSpelling.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForNameSpelling.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForNameSpelling.Location = new System.Drawing.Point(186, 163);
            this.labelForNameSpelling.Name = "labelForNameSpelling";
            this.labelForNameSpelling.Size = new System.Drawing.Size(163, 20);
            this.labelForNameSpelling.TabIndex = 8;
            this.labelForNameSpelling.Text = "İSİM OKUNUŞU";
            this.labelForNameSpelling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDrugName2
            // 
            this.textBoxDrugName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDrugName2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDrugName2.Location = new System.Drawing.Point(186, 111);
            this.textBoxDrugName2.Multiline = true;
            this.textBoxDrugName2.Name = "textBoxDrugName2";
            this.textBoxDrugName2.ReadOnly = true;
            this.textBoxDrugName2.Size = new System.Drawing.Size(546, 44);
            this.textBoxDrugName2.TabIndex = 7;
            // 
            // labelForDrugName2
            // 
            this.labelForDrugName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForDrugName2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForDrugName2.Location = new System.Drawing.Point(186, 86);
            this.labelForDrugName2.Name = "labelForDrugName2";
            this.labelForDrugName2.Size = new System.Drawing.Size(163, 20);
            this.labelForDrugName2.TabIndex = 6;
            this.labelForDrugName2.Text = "İSİM";
            this.labelForDrugName2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPageDescriptionDetails
            // 
            this.tabPageDescriptionDetails.BackColor = System.Drawing.Color.Navy;
            this.tabPageDescriptionDetails.Controls.Add(this.labelTextLen);
            this.tabPageDescriptionDetails.Controls.Add(this.buttonCreateDescriptionFile);
            this.tabPageDescriptionDetails.Controls.Add(this.labelForDescriptionAudioFilePath);
            this.tabPageDescriptionDetails.Controls.Add(this.textBoxDescriptionAudioFilePath);
            this.tabPageDescriptionDetails.Controls.Add(this.groupBoxChangeText);
            this.tabPageDescriptionDetails.Controls.Add(this.buttonListenDescription);
            this.tabPageDescriptionDetails.Controls.Add(this.buttonChangeKtLink);
            this.tabPageDescriptionDetails.Controls.Add(this.richTextBoxKTText);
            this.tabPageDescriptionDetails.Controls.Add(this.webBrowserTitck);
            this.tabPageDescriptionDetails.Controls.Add(this.textBoxTitckLink);
            this.tabPageDescriptionDetails.Controls.Add(this.labelForKTLink);
            this.tabPageDescriptionDetails.Location = new System.Drawing.Point(4, 25);
            this.tabPageDescriptionDetails.Name = "tabPageDescriptionDetails";
            this.tabPageDescriptionDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDescriptionDetails.Size = new System.Drawing.Size(1088, 545);
            this.tabPageDescriptionDetails.TabIndex = 2;
            this.tabPageDescriptionDetails.Text = "Kullanma Talimatı Detayları";
            // 
            // labelTextLen
            // 
            this.labelTextLen.AutoSize = true;
            this.labelTextLen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTextLen.Location = new System.Drawing.Point(868, 382);
            this.labelTextLen.Name = "labelTextLen";
            this.labelTextLen.Size = new System.Drawing.Size(52, 17);
            this.labelTextLen.TabIndex = 25;
            this.labelTextLen.Text = "label1";
            // 
            // buttonCreateDescriptionFile
            // 
            this.buttonCreateDescriptionFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateDescriptionFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonCreateDescriptionFile.Location = new System.Drawing.Point(864, 419);
            this.buttonCreateDescriptionFile.Name = "buttonCreateDescriptionFile";
            this.buttonCreateDescriptionFile.Size = new System.Drawing.Size(213, 103);
            this.buttonCreateDescriptionFile.TabIndex = 24;
            this.buttonCreateDescriptionFile.Text = "KT DOSYASINI  OLUŞTUR-DÜZENLE";
            this.buttonCreateDescriptionFile.UseVisualStyleBackColor = true;
            this.buttonCreateDescriptionFile.Click += new System.EventHandler(this.buttonCreateDescriptionFile_Click);
            // 
            // labelForDescriptionAudioFilePath
            // 
            this.labelForDescriptionAudioFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForDescriptionAudioFilePath.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForDescriptionAudioFilePath.Location = new System.Drawing.Point(10, 40);
            this.labelForDescriptionAudioFilePath.Name = "labelForDescriptionAudioFilePath";
            this.labelForDescriptionAudioFilePath.Size = new System.Drawing.Size(127, 25);
            this.labelForDescriptionAudioFilePath.TabIndex = 22;
            this.labelForDescriptionAudioFilePath.Text = "KT AUDIO YOLU";
            this.labelForDescriptionAudioFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxDescriptionAudioFilePath
            // 
            this.textBoxDescriptionAudioFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDescriptionAudioFilePath.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxDescriptionAudioFilePath.Location = new System.Drawing.Point(143, 41);
            this.textBoxDescriptionAudioFilePath.Multiline = true;
            this.textBoxDescriptionAudioFilePath.Name = "textBoxDescriptionAudioFilePath";
            this.textBoxDescriptionAudioFilePath.ReadOnly = true;
            this.textBoxDescriptionAudioFilePath.Size = new System.Drawing.Size(714, 25);
            this.textBoxDescriptionAudioFilePath.TabIndex = 23;
            // 
            // groupBoxChangeText
            // 
            this.groupBoxChangeText.Controls.Add(this.buttonAllToLower);
            this.groupBoxChangeText.Controls.Add(this.buttonChangeText);
            this.groupBoxChangeText.Controls.Add(this.labelForReplaceText);
            this.groupBoxChangeText.Controls.Add(this.textBoxReplaceText);
            this.groupBoxChangeText.Controls.Add(this.labelForOriginalText);
            this.groupBoxChangeText.Controls.Add(this.textBoxOrijinalText);
            this.groupBoxChangeText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxChangeText.Location = new System.Drawing.Point(864, 117);
            this.groupBoxChangeText.Name = "groupBoxChangeText";
            this.groupBoxChangeText.Size = new System.Drawing.Size(222, 244);
            this.groupBoxChangeText.TabIndex = 18;
            this.groupBoxChangeText.TabStop = false;
            this.groupBoxChangeText.Text = "Metin Düzenleme";
            // 
            // buttonAllToLower
            // 
            this.buttonAllToLower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAllToLower.Location = new System.Drawing.Point(12, 190);
            this.buttonAllToLower.Name = "buttonAllToLower";
            this.buttonAllToLower.Size = new System.Drawing.Size(192, 40);
            this.buttonAllToLower.TabIndex = 22;
            this.buttonAllToLower.Text = "Hepsini Küçük Harf Yap";
            this.buttonAllToLower.UseVisualStyleBackColor = true;
            this.buttonAllToLower.Click += new System.EventHandler(this.buttonAllToLower_Click);
            // 
            // buttonChangeText
            // 
            this.buttonChangeText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeText.Location = new System.Drawing.Point(12, 144);
            this.buttonChangeText.Name = "buttonChangeText";
            this.buttonChangeText.Size = new System.Drawing.Size(192, 40);
            this.buttonChangeText.TabIndex = 19;
            this.buttonChangeText.Text = "Değiştir";
            this.buttonChangeText.UseVisualStyleBackColor = true;
            this.buttonChangeText.Click += new System.EventHandler(this.buttonChangeText_Click);
            // 
            // labelForReplaceText
            // 
            this.labelForReplaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForReplaceText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForReplaceText.Location = new System.Drawing.Point(12, 80);
            this.labelForReplaceText.Name = "labelForReplaceText";
            this.labelForReplaceText.Size = new System.Drawing.Size(192, 20);
            this.labelForReplaceText.TabIndex = 20;
            this.labelForReplaceText.Text = "Şunula değiştir";
            this.labelForReplaceText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxReplaceText
            // 
            this.textBoxReplaceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxReplaceText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxReplaceText.Location = new System.Drawing.Point(12, 102);
            this.textBoxReplaceText.Multiline = true;
            this.textBoxReplaceText.Name = "textBoxReplaceText";
            this.textBoxReplaceText.Size = new System.Drawing.Size(192, 27);
            this.textBoxReplaceText.TabIndex = 21;
            // 
            // labelForOriginalText
            // 
            this.labelForOriginalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForOriginalText.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForOriginalText.Location = new System.Drawing.Point(12, 21);
            this.labelForOriginalText.Name = "labelForOriginalText";
            this.labelForOriginalText.Size = new System.Drawing.Size(192, 20);
            this.labelForOriginalText.TabIndex = 19;
            this.labelForOriginalText.Text = "Orjinal metin";
            this.labelForOriginalText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxOrijinalText
            // 
            this.textBoxOrijinalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxOrijinalText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxOrijinalText.Location = new System.Drawing.Point(12, 42);
            this.textBoxOrijinalText.Multiline = true;
            this.textBoxOrijinalText.Name = "textBoxOrijinalText";
            this.textBoxOrijinalText.Size = new System.Drawing.Size(192, 27);
            this.textBoxOrijinalText.TabIndex = 19;
            // 
            // buttonListenDescription
            // 
            this.buttonListenDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListenDescription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonListenDescription.Location = new System.Drawing.Point(863, 40);
            this.buttonListenDescription.Name = "buttonListenDescription";
            this.buttonListenDescription.Size = new System.Drawing.Size(214, 56);
            this.buttonListenDescription.TabIndex = 17;
            this.buttonListenDescription.Text = "KT DOSYASINI DİNLE";
            this.buttonListenDescription.UseVisualStyleBackColor = true;
            this.buttonListenDescription.Click += new System.EventHandler(this.buttonListenDescription_Click);
            // 
            // buttonChangeKtLink
            // 
            this.buttonChangeKtLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeKtLink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeKtLink.Location = new System.Drawing.Point(863, 7);
            this.buttonChangeKtLink.Name = "buttonChangeKtLink";
            this.buttonChangeKtLink.Size = new System.Drawing.Size(214, 27);
            this.buttonChangeKtLink.TabIndex = 16;
            this.buttonChangeKtLink.Text = "LİNKE GİT";
            this.buttonChangeKtLink.UseVisualStyleBackColor = true;
            this.buttonChangeKtLink.Click += new System.EventHandler(this.buttonChangeKtLink_Click);
            // 
            // richTextBoxKTText
            // 
            this.richTextBoxKTText.Location = new System.Drawing.Point(460, 80);
            this.richTextBoxKTText.Name = "richTextBoxKTText";
            this.richTextBoxKTText.Size = new System.Drawing.Size(397, 442);
            this.richTextBoxKTText.TabIndex = 15;
            this.richTextBoxKTText.Text = "";
            this.richTextBoxKTText.TextChanged += new System.EventHandler(this.richTextBoxKTText_TextChanged);
            // 
            // webBrowserTitck
            // 
            this.webBrowserTitck.Location = new System.Drawing.Point(9, 80);
            this.webBrowserTitck.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserTitck.Name = "webBrowserTitck";
            this.webBrowserTitck.ScriptErrorsSuppressed = true;
            this.webBrowserTitck.Size = new System.Drawing.Size(445, 442);
            this.webBrowserTitck.TabIndex = 14;
            // 
            // textBoxTitckLink
            // 
            this.textBoxTitckLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxTitckLink.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxTitckLink.Location = new System.Drawing.Point(143, 7);
            this.textBoxTitckLink.Multiline = true;
            this.textBoxTitckLink.Name = "textBoxTitckLink";
            this.textBoxTitckLink.Size = new System.Drawing.Size(714, 27);
            this.textBoxTitckLink.TabIndex = 13;
            // 
            // labelForKTLink
            // 
            this.labelForKTLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForKTLink.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelForKTLink.Location = new System.Drawing.Point(10, 14);
            this.labelForKTLink.Name = "labelForKTLink";
            this.labelForKTLink.Size = new System.Drawing.Size(127, 20);
            this.labelForKTLink.TabIndex = 12;
            this.labelForKTLink.Text = "KT TİTCK LİNKİ";
            this.labelForKTLink.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDrugNameHeader
            // 
            this.labelDrugNameHeader.AutoSize = true;
            this.labelDrugNameHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDrugNameHeader.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelDrugNameHeader.Location = new System.Drawing.Point(12, 10);
            this.labelDrugNameHeader.Name = "labelDrugNameHeader";
            this.labelDrugNameHeader.Size = new System.Drawing.Size(86, 20);
            this.labelDrugNameHeader.TabIndex = 1;
            this.labelDrugNameHeader.Text = "DrugName";
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClose.Location = new System.Drawing.Point(1078, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(29, 29);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // timerDrugDetails
            // 
            this.timerDrugDetails.Enabled = true;
            this.timerDrugDetails.Tick += new System.EventHandler(this.timerDrugDetails_Tick);
            // 
            // DrugDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1111, 629);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelDrugNameHeader);
            this.Controls.Add(this.tabControlDrugDetails);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrugDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DrugDetailForm";
            this.Load += new System.EventHandler(this.DrugDetailForm_Load);
            this.tabControlDrugDetails.ResumeLayout(false);
            this.tabPageTextDetails.ResumeLayout(false);
            this.tabPageTextDetails.PerformLayout();
            this.groupBoxEsdeger.ResumeLayout(false);
            this.groupBoxEsdeger.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBarcode)).EndInit();
            this.tabPageNameDetails.ResumeLayout(false);
            this.tabPageNameDetails.PerformLayout();
            this.tabPageDescriptionDetails.ResumeLayout(false);
            this.tabPageDescriptionDetails.PerformLayout();
            this.groupBoxChangeText.ResumeLayout(false);
            this.groupBoxChangeText.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlDrugDetails;
        private System.Windows.Forms.TabPage tabPageTextDetails;
        private System.Windows.Forms.TabPage tabPageNameDetails;
        private System.Windows.Forms.TabPage tabPageDescriptionDetails;
        private System.Windows.Forms.PictureBox pictureBoxBarcode;
        private System.Windows.Forms.TextBox textBoxRRSStatus;
        private System.Windows.Forms.Label labelForRRSStatus;
        private System.Windows.Forms.TextBox textBoxRRSUpdateDate;
        private System.Windows.Forms.Label labelForRRsUpdateDate;
        private System.Windows.Forms.TextBox textBoxRRSCreationDate;
        private System.Windows.Forms.Label labelForRRSCreationDate;
        private System.Windows.Forms.TextBox textBoxTitckCode;
        private System.Windows.Forms.Label labelForTitckCode;
        private System.Windows.Forms.TextBox textBoxSGKCode;
        private System.Windows.Forms.Label labelForSGKCode;
        private System.Windows.Forms.TextBox textBoxDrugName;
        private System.Windows.Forms.Label labelForDrugName;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.Label labelForBarcode;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelForID;
        private System.Windows.Forms.Label labelDrugNameHeader;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.TextBox textBoxCreationDate;
        private System.Windows.Forms.Label labelForCreationDate;
        private System.Windows.Forms.Label labelForActive;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelForEsdegerBarkod;
        private System.Windows.Forms.TextBox textBoxEsdegerBarkod;
        private System.Windows.Forms.Button buttonEsdegerKaydet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.GroupBox groupBoxEsdeger;
        private System.Windows.Forms.TextBox textBoxNameSpelling;
        private System.Windows.Forms.Label labelForNameSpelling;
        private System.Windows.Forms.TextBox textBoxDrugName2;
        private System.Windows.Forms.Label labelForDrugName2;
        private System.Windows.Forms.Button buttonListenToNameSound;
        private System.Windows.Forms.RichTextBox richTextBoxKTText;
        private System.Windows.Forms.WebBrowser webBrowserTitck;
        private System.Windows.Forms.TextBox textBoxTitckLink;
        private System.Windows.Forms.Label labelForKTLink;
        private System.Windows.Forms.TextBox textBoxAudioFilePath;
        private System.Windows.Forms.Label labelForAudioFilePath;
        private System.Windows.Forms.ComboBox comboBoxActive;
        private System.Windows.Forms.Button buttonCreateNameSound;
        private System.Windows.Forms.Timer timerDrugDetails;
        private System.Windows.Forms.Label labelForDescriptionAudioFilePath;
        private System.Windows.Forms.TextBox textBoxDescriptionAudioFilePath;
        private System.Windows.Forms.GroupBox groupBoxChangeText;
        private System.Windows.Forms.Button buttonChangeText;
        private System.Windows.Forms.Label labelForReplaceText;
        private System.Windows.Forms.TextBox textBoxReplaceText;
        private System.Windows.Forms.Label labelForOriginalText;
        private System.Windows.Forms.TextBox textBoxOrijinalText;
        private System.Windows.Forms.Button buttonListenDescription;
        private System.Windows.Forms.Button buttonChangeKtLink;
        private System.Windows.Forms.Button buttonCreateDescriptionFile;
        private System.Windows.Forms.Button buttonAllToLower;
        private System.Windows.Forms.Label labelTextLen;
    }
}