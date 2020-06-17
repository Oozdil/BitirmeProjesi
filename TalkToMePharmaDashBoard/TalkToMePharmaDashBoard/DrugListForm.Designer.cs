namespace TalkToMePharmaDashBoard
{
    partial class DrugListForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDrugList = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RRS_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFileExists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescFileExists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TitckLinkExists = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelSelectedDrug = new System.Windows.Forms.Label();
            this.textBoxSearchBar = new System.Windows.Forms.TextBox();
            this.buttonDrugDetail = new System.Windows.Forms.Button();
            this.labelSearch = new System.Windows.Forms.Label();
            this.labelForSelectedDrug = new System.Windows.Forms.Label();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonPrevPage = new System.Windows.Forms.Button();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.labelNavigation = new System.Windows.Forms.Label();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.checkBoxRRSPasif = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugList)).BeginInit();
            this.panelNavigation.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewDrugList
            // 
            this.dataGridViewDrugList.AllowUserToAddRows = false;
            this.dataGridViewDrugList.AllowUserToDeleteRows = false;
            this.dataGridViewDrugList.AllowUserToResizeColumns = false;
            this.dataGridViewDrugList.AllowUserToResizeRows = false;
            this.dataGridViewDrugList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewDrugList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Barcode,
            this.DrugName,
            this.RRS_Status,
            this.NameFileExists,
            this.DescFileExists,
            this.TitckLinkExists,
            this.Active,
            this.DateOfCreate});
            this.dataGridViewDrugList.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugList.Location = new System.Drawing.Point(0, 44);
            this.dataGridViewDrugList.MultiSelect = false;
            this.dataGridViewDrugList.Name = "dataGridViewDrugList";
            this.dataGridViewDrugList.ReadOnly = true;
            this.dataGridViewDrugList.RowHeadersVisible = false;
            this.dataGridViewDrugList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewDrugList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDrugList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugList.Size = new System.Drawing.Size(1023, 497);
            this.dataGridViewDrugList.TabIndex = 0;
            this.dataGridViewDrugList.SelectionChanged += new System.EventHandler(this.dataGridViewDrugList_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 60;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 110;
            // 
            // DrugName
            // 
            this.DrugName.HeaderText = "Drug Name";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            this.DrugName.Width = 340;
            // 
            // RRS_Status
            // 
            this.RRS_Status.HeaderText = "RRS Status";
            this.RRS_Status.Name = "RRS_Status";
            this.RRS_Status.ReadOnly = true;
            this.RRS_Status.Width = 75;
            // 
            // NameFileExists
            // 
            this.NameFileExists.HeaderText = "Name File Exists";
            this.NameFileExists.Name = "NameFileExists";
            this.NameFileExists.ReadOnly = true;
            this.NameFileExists.Width = 75;
            // 
            // DescFileExists
            // 
            this.DescFileExists.HeaderText = "Description File Exists";
            this.DescFileExists.Name = "DescFileExists";
            this.DescFileExists.ReadOnly = true;
            this.DescFileExists.Width = 75;
            // 
            // TitckLinkExists
            // 
            this.TitckLinkExists.HeaderText = "Titck Link Exists";
            this.TitckLinkExists.Name = "TitckLinkExists";
            this.TitckLinkExists.ReadOnly = true;
            this.TitckLinkExists.Width = 75;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 75;
            // 
            // DateOfCreate
            // 
            this.DateOfCreate.HeaderText = "Date Of Create";
            this.DateOfCreate.Name = "DateOfCreate";
            this.DateOfCreate.ReadOnly = true;
            this.DateOfCreate.Width = 115;
            // 
            // labelSelectedDrug
            // 
            this.labelSelectedDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSelectedDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectedDrug.Location = new System.Drawing.Point(112, 544);
            this.labelSelectedDrug.Name = "labelSelectedDrug";
            this.labelSelectedDrug.Size = new System.Drawing.Size(707, 36);
            this.labelSelectedDrug.TabIndex = 1;
            this.labelSelectedDrug.Text = "label1";
            this.labelSelectedDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxSearchBar
            // 
            this.textBoxSearchBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSearchBar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxSearchBar.Location = new System.Drawing.Point(235, 8);
            this.textBoxSearchBar.Name = "textBoxSearchBar";
            this.textBoxSearchBar.Size = new System.Drawing.Size(327, 23);
            this.textBoxSearchBar.TabIndex = 4;
            this.textBoxSearchBar.TextChanged += new System.EventHandler(this.textBoxSearchBar_TextChanged);
            // 
            // buttonDrugDetail
            // 
            this.buttonDrugDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrugDetail.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDrugDetail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrugDetail.Location = new System.Drawing.Point(830, 544);
            this.buttonDrugDetail.Name = "buttonDrugDetail";
            this.buttonDrugDetail.Size = new System.Drawing.Size(190, 37);
            this.buttonDrugDetail.TabIndex = 5;
            this.buttonDrugDetail.Text = "İlaç Detayına Git";
            this.buttonDrugDetail.UseVisualStyleBackColor = true;
            this.buttonDrugDetail.Click += new System.EventHandler(this.buttonDrugDetail_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSearch.Location = new System.Drawing.Point(6, 11);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(223, 17);
            this.labelSearch.TabIndex = 6;
            this.labelSearch.Text = "İsim,  Barkod veya ID İle Ara :";
            // 
            // labelForSelectedDrug
            // 
            this.labelForSelectedDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForSelectedDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForSelectedDrug.Location = new System.Drawing.Point(12, 547);
            this.labelForSelectedDrug.Name = "labelForSelectedDrug";
            this.labelForSelectedDrug.Size = new System.Drawing.Size(87, 32);
            this.labelForSelectedDrug.TabIndex = 7;
            this.labelForSelectedDrug.Text = "Seçili İlaç :";
            this.labelForSelectedDrug.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirstPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonFirstPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFirstPage.Location = new System.Drawing.Point(8, 4);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(38, 28);
            this.buttonFirstPage.TabIndex = 6;
            this.buttonFirstPage.Text = "<<";
            this.buttonFirstPage.UseVisualStyleBackColor = true;
            this.buttonFirstPage.Click += new System.EventHandler(this.buttonFirstPage_Click);
            // 
            // buttonPrevPage
            // 
            this.buttonPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPrevPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrevPage.Location = new System.Drawing.Point(52, 4);
            this.buttonPrevPage.Name = "buttonPrevPage";
            this.buttonPrevPage.Size = new System.Drawing.Size(38, 28);
            this.buttonPrevPage.TabIndex = 7;
            this.buttonPrevPage.Text = "<";
            this.buttonPrevPage.UseVisualStyleBackColor = true;
            this.buttonPrevPage.Click += new System.EventHandler(this.buttonPrevPage_Click);
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNextPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNextPage.Location = new System.Drawing.Point(208, 4);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(38, 28);
            this.buttonNextPage.TabIndex = 8;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = true;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLastPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonLastPage.Location = new System.Drawing.Point(250, 4);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(38, 28);
            this.buttonLastPage.TabIndex = 9;
            this.buttonLastPage.Text = ">>";
            this.buttonLastPage.UseVisualStyleBackColor = true;
            this.buttonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);
            // 
            // labelNavigation
            // 
            this.labelNavigation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelNavigation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNavigation.Location = new System.Drawing.Point(95, 11);
            this.labelNavigation.Name = "labelNavigation";
            this.labelNavigation.Size = new System.Drawing.Size(107, 17);
            this.labelNavigation.TabIndex = 9;
            this.labelNavigation.Text = "000 /000";
            this.labelNavigation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.panelNavigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelNavigation.Controls.Add(this.labelNavigation);
            this.panelNavigation.Controls.Add(this.buttonLastPage);
            this.panelNavigation.Controls.Add(this.buttonNextPage);
            this.panelNavigation.Controls.Add(this.buttonPrevPage);
            this.panelNavigation.Controls.Add(this.buttonFirstPage);
            this.panelNavigation.Location = new System.Drawing.Point(729, 1);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(294, 38);
            this.panelNavigation.TabIndex = 8;
            // 
            // checkBoxRRSPasif
            // 
            this.checkBoxRRSPasif.AutoSize = true;
            this.checkBoxRRSPasif.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxRRSPasif.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxRRSPasif.Location = new System.Drawing.Point(570, 7);
            this.checkBoxRRSPasif.Name = "checkBoxRRSPasif";
            this.checkBoxRRSPasif.Size = new System.Drawing.Size(153, 23);
            this.checkBoxRRSPasif.TabIndex = 9;
            this.checkBoxRRSPasif.Text = "RRS Pasifleri Göster";
            this.checkBoxRRSPasif.UseVisualStyleBackColor = true;
            this.checkBoxRRSPasif.CheckedChanged += new System.EventHandler(this.checkBoxRRSPasif_CheckedChanged);
            // 
            // DrugListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.checkBoxRRSPasif);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.labelForSelectedDrug);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.buttonDrugDetail);
            this.Controls.Add(this.textBoxSearchBar);
            this.Controls.Add(this.labelSelectedDrug);
            this.Controls.Add(this.dataGridViewDrugList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrugListForm";
            this.Text = "DrugListForm";
            this.Load += new System.EventHandler(this.DrugListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugList)).EndInit();
            this.panelNavigation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDrugList;
        private System.Windows.Forms.Label labelSelectedDrug;
        private System.Windows.Forms.TextBox textBoxSearchBar;
        private System.Windows.Forms.Button buttonDrugDetail;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Label labelForSelectedDrug;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RRS_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFileExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescFileExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitckLinkExists;
        private System.Windows.Forms.DataGridViewTextBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreate;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonPrevPage;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Label labelNavigation;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.CheckBox checkBoxRRSPasif;

    }
}