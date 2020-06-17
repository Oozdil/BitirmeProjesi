namespace TalkToMePharmaDashBoard
{
    partial class NewDrugForm
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
            this.labelBarcode = new System.Windows.Forms.Label();
            this.textBoxBarcode = new System.Windows.Forms.TextBox();
            this.textBoxDrugName = new System.Windows.Forms.TextBox();
            this.labelForDrugName = new System.Windows.Forms.Label();
            this.tabControlNewDrug = new System.Windows.Forms.TabControl();
            this.tabPageAddManually = new System.Windows.Forms.TabPage();
            this.labelDrugID = new System.Windows.Forms.Label();
            this.labelDrugIdInfo = new System.Windows.Forms.Label();
            this.buttonDrugDetail = new System.Windows.Forms.Button();
            this.buttonNewRecord = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.tabPageRRS = new System.Windows.Forms.TabPage();
            this.buttonChangeUrl = new System.Windows.Forms.Button();
            this.textBoxRRSUrl = new System.Windows.Forms.TextBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.webBrowserRRS = new System.Windows.Forms.WebBrowser();
            this.timerRRS = new System.Windows.Forms.Timer(this.components);
            this.tabControlNewDrug.SuspendLayout();
            this.tabPageAddManually.SuspendLayout();
            this.tabPageRRS.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBarcode.Location = new System.Drawing.Point(215, 193);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(62, 19);
            this.labelBarcode.TabIndex = 0;
            this.labelBarcode.Text = "Barkod :";
            // 
            // textBoxBarcode
            // 
            this.textBoxBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBarcode.Location = new System.Drawing.Point(298, 190);
            this.textBoxBarcode.MaxLength = 250;
            this.textBoxBarcode.Name = "textBoxBarcode";
            this.textBoxBarcode.Size = new System.Drawing.Size(308, 26);
            this.textBoxBarcode.TabIndex = 1;
            // 
            // textBoxDrugName
            // 
            this.textBoxDrugName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxDrugName.Location = new System.Drawing.Point(298, 222);
            this.textBoxDrugName.MaxLength = 250;
            this.textBoxDrugName.Name = "textBoxDrugName";
            this.textBoxDrugName.Size = new System.Drawing.Size(308, 26);
            this.textBoxDrugName.TabIndex = 3;
            // 
            // labelForDrugName
            // 
            this.labelForDrugName.AutoSize = true;
            this.labelForDrugName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForDrugName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForDrugName.Location = new System.Drawing.Point(215, 225);
            this.labelForDrugName.Name = "labelForDrugName";
            this.labelForDrugName.Size = new System.Drawing.Size(63, 19);
            this.labelForDrugName.TabIndex = 2;
            this.labelForDrugName.Text = "İlaç Adı :";
            // 
            // tabControlNewDrug
            // 
            this.tabControlNewDrug.Controls.Add(this.tabPageAddManually);
            this.tabControlNewDrug.Controls.Add(this.tabPageRRS);
            this.tabControlNewDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlNewDrug.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlNewDrug.Location = new System.Drawing.Point(0, 0);
            this.tabControlNewDrug.Name = "tabControlNewDrug";
            this.tabControlNewDrug.SelectedIndex = 0;
            this.tabControlNewDrug.Size = new System.Drawing.Size(1035, 583);
            this.tabControlNewDrug.TabIndex = 12;
            // 
            // tabPageAddManually
            // 
            this.tabPageAddManually.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tabPageAddManually.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPageAddManually.Controls.Add(this.labelDrugID);
            this.tabPageAddManually.Controls.Add(this.labelDrugIdInfo);
            this.tabPageAddManually.Controls.Add(this.buttonDrugDetail);
            this.tabPageAddManually.Controls.Add(this.buttonNewRecord);
            this.tabPageAddManually.Controls.Add(this.buttonSave);
            this.tabPageAddManually.Controls.Add(this.labelHeader);
            this.tabPageAddManually.Controls.Add(this.labelBarcode);
            this.tabPageAddManually.Controls.Add(this.textBoxBarcode);
            this.tabPageAddManually.Controls.Add(this.labelForDrugName);
            this.tabPageAddManually.Controls.Add(this.textBoxDrugName);
            this.tabPageAddManually.Location = new System.Drawing.Point(4, 31);
            this.tabPageAddManually.Name = "tabPageAddManually";
            this.tabPageAddManually.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddManually.Size = new System.Drawing.Size(1027, 548);
            this.tabPageAddManually.TabIndex = 0;
            this.tabPageAddManually.Text = "Manuel İlaç Ekle";
            // 
            // labelDrugID
            // 
            this.labelDrugID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDrugID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDrugID.Location = new System.Drawing.Point(298, 162);
            this.labelDrugID.Name = "labelDrugID";
            this.labelDrugID.Size = new System.Drawing.Size(80, 25);
            this.labelDrugID.TabIndex = 9;
            // 
            // labelDrugIdInfo
            // 
            this.labelDrugIdInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDrugIdInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelDrugIdInfo.Location = new System.Drawing.Point(216, 162);
            this.labelDrugIdInfo.Name = "labelDrugIdInfo";
            this.labelDrugIdInfo.Size = new System.Drawing.Size(80, 25);
            this.labelDrugIdInfo.TabIndex = 8;
            this.labelDrugIdInfo.Text = "İlaç ID :";
            // 
            // buttonDrugDetail
            // 
            this.buttonDrugDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrugDetail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDrugDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrugDetail.Location = new System.Drawing.Point(621, 189);
            this.buttonDrugDetail.Name = "buttonDrugDetail";
            this.buttonDrugDetail.Size = new System.Drawing.Size(188, 59);
            this.buttonDrugDetail.TabIndex = 7;
            this.buttonDrugDetail.Text = "İlaç Detayına Git";
            this.buttonDrugDetail.UseVisualStyleBackColor = true;
            this.buttonDrugDetail.Click += new System.EventHandler(this.buttonDrugDetail_Click);
            // 
            // buttonNewRecord
            // 
            this.buttonNewRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewRecord.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewRecord.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNewRecord.Location = new System.Drawing.Point(220, 274);
            this.buttonNewRecord.Name = "buttonNewRecord";
            this.buttonNewRecord.Size = new System.Drawing.Size(169, 59);
            this.buttonNewRecord.TabIndex = 6;
            this.buttonNewRecord.Text = "Yeni Kayıt / Vazgeç";
            this.buttonNewRecord.UseVisualStyleBackColor = true;
            this.buttonNewRecord.Click += new System.EventHandler(this.buttonNewRecord_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Location = new System.Drawing.Point(495, 274);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(111, 59);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "Kaydet";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point(215, 115);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(136, 25);
            this.labelHeader.TabIndex = 4;
            this.labelHeader.Text = "Yeni İlaç Ekle";
            // 
            // tabPageRRS
            // 
            this.tabPageRRS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tabPageRRS.Controls.Add(this.buttonChangeUrl);
            this.tabPageRRS.Controls.Add(this.textBoxRRSUrl);
            this.tabPageRRS.Controls.Add(this.buttonRefresh);
            this.tabPageRRS.Controls.Add(this.webBrowserRRS);
            this.tabPageRRS.Location = new System.Drawing.Point(4, 31);
            this.tabPageRRS.Name = "tabPageRRS";
            this.tabPageRRS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageRRS.Size = new System.Drawing.Size(1027, 548);
            this.tabPageRRS.TabIndex = 1;
            this.tabPageRRS.Text = "Renkli Reçete Sisteminde İlaç Girişi";
            // 
            // buttonChangeUrl
            // 
            this.buttonChangeUrl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangeUrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangeUrl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonChangeUrl.Location = new System.Drawing.Point(849, 4);
            this.buttonChangeUrl.Name = "buttonChangeUrl";
            this.buttonChangeUrl.Size = new System.Drawing.Size(149, 27);
            this.buttonChangeUrl.TabIndex = 6;
            this.buttonChangeUrl.Text = "URL Değiştir";
            this.buttonChangeUrl.UseVisualStyleBackColor = true;
            // 
            // textBoxRRSUrl
            // 
            this.textBoxRRSUrl.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRRSUrl.Location = new System.Drawing.Point(134, 6);
            this.textBoxRRSUrl.Name = "textBoxRRSUrl";
            this.textBoxRRSUrl.Size = new System.Drawing.Size(709, 26);
            this.textBoxRRSUrl.TabIndex = 5;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRefresh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonRefresh.Location = new System.Drawing.Point(24, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(89, 25);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Yenile";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // webBrowserRRS
            // 
            this.webBrowserRRS.Location = new System.Drawing.Point(24, 37);
            this.webBrowserRRS.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserRRS.Name = "webBrowserRRS";
            this.webBrowserRRS.ScriptErrorsSuppressed = true;
            this.webBrowserRRS.Size = new System.Drawing.Size(975, 515);
            this.webBrowserRRS.TabIndex = 0;
            // 
            // timerRRS
            // 
            this.timerRRS.Enabled = true;
            this.timerRRS.Interval = 1000;
            this.timerRRS.Tick += new System.EventHandler(this.timerRRS_Tick);
            // 
            // NewDrugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.tabControlNewDrug);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewDrugForm";
            this.Text = "NewDrugForm";
            this.Load += new System.EventHandler(this.NewDrugForm_Load);
            this.tabControlNewDrug.ResumeLayout(false);
            this.tabPageAddManually.ResumeLayout(false);
            this.tabPageAddManually.PerformLayout();
            this.tabPageRRS.ResumeLayout(false);
            this.tabPageRRS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.TextBox textBoxBarcode;
        private System.Windows.Forms.TextBox textBoxDrugName;
        private System.Windows.Forms.Label labelForDrugName;
        private System.Windows.Forms.TabControl tabControlNewDrug;
        private System.Windows.Forms.TabPage tabPageAddManually;
        private System.Windows.Forms.TabPage tabPageRRS;
        private System.Windows.Forms.WebBrowser webBrowserRRS;
        private System.Windows.Forms.Button buttonChangeUrl;
        private System.Windows.Forms.TextBox textBoxRRSUrl;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonDrugDetail;
        private System.Windows.Forms.Button buttonNewRecord;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelDrugIdInfo;
        private System.Windows.Forms.Timer timerRRS;
        private System.Windows.Forms.Label labelDrugID;
    }
}