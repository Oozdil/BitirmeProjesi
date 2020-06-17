namespace TalkToMePharmaDashBoard
{
    partial class MessagesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewDrugList = new System.Windows.Forms.DataGridView();
            this.BARKOD_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ILAC_ADI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MESAJSAYISI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TAMAMLANMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelSelectedDrug = new System.Windows.Forms.Label();
            this.buttonDrugDetails = new System.Windows.Forms.Button();
            this.timerMessages = new System.Windows.Forms.Timer(this.components);
            this.labelRemainingToRefresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugList)).BeginInit();
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDrugList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewDrugList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDrugList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BARKOD_ID,
            this.Message,
            this.ILAC_ADI,
            this.MESAJSAYISI,
            this.TAMAMLANMA,
            this.DateOfCreate});
            this.dataGridViewDrugList.EnableHeadersVisualStyles = false;
            this.dataGridViewDrugList.Location = new System.Drawing.Point(45, 38);
            this.dataGridViewDrugList.Name = "dataGridViewDrugList";
            this.dataGridViewDrugList.ReadOnly = true;
            this.dataGridViewDrugList.RowHeadersVisible = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewDrugList.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewDrugList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDrugList.Size = new System.Drawing.Size(954, 500);
            this.dataGridViewDrugList.TabIndex = 1;
            this.dataGridViewDrugList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDrugList_CellContentClick);
            this.dataGridViewDrugList.SelectionChanged += new System.EventHandler(this.dataGridViewDrugList_SelectionChanged);
            // 
            // BARKOD_ID
            // 
            this.BARKOD_ID.HeaderText = "BARKOD ID";
            this.BARKOD_ID.Name = "BARKOD_ID";
            this.BARKOD_ID.ReadOnly = true;
            this.BARKOD_ID.Width = 110;
            // 
            // Message
            // 
            this.Message.HeaderText = "BARKOD";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            this.Message.Width = 150;
            // 
            // ILAC_ADI
            // 
            this.ILAC_ADI.HeaderText = "İLAÇ ADI";
            this.ILAC_ADI.Name = "ILAC_ADI";
            this.ILAC_ADI.ReadOnly = true;
            this.ILAC_ADI.Width = 315;
            // 
            // MESAJSAYISI
            // 
            this.MESAJSAYISI.HeaderText = "MESAJ SAYISI";
            this.MESAJSAYISI.Name = "MESAJSAYISI";
            this.MESAJSAYISI.ReadOnly = true;
            // 
            // TAMAMLANMA
            // 
            this.TAMAMLANMA.HeaderText = "TAMAMLANMA";
            this.TAMAMLANMA.Name = "TAMAMLANMA";
            this.TAMAMLANMA.ReadOnly = true;
            this.TAMAMLANMA.Width = 110;
            // 
            // DateOfCreate
            // 
            this.DateOfCreate.HeaderText = "Date Of Create";
            this.DateOfCreate.Name = "DateOfCreate";
            this.DateOfCreate.ReadOnly = true;
            this.DateOfCreate.Width = 150;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(47, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(192, 23);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Tamamlanmışları Göster";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // labelSelectedDrug
            // 
            this.labelSelectedDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSelectedDrug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSelectedDrug.Location = new System.Drawing.Point(255, 7);
            this.labelSelectedDrug.Name = "labelSelectedDrug";
            this.labelSelectedDrug.Size = new System.Drawing.Size(580, 24);
            this.labelSelectedDrug.TabIndex = 3;
            this.labelSelectedDrug.Text = "label1";
            this.labelSelectedDrug.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDrugDetails
            // 
            this.buttonDrugDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrugDetails.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDrugDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrugDetails.Location = new System.Drawing.Point(841, 9);
            this.buttonDrugDetails.Name = "buttonDrugDetails";
            this.buttonDrugDetails.Size = new System.Drawing.Size(138, 23);
            this.buttonDrugDetails.TabIndex = 4;
            this.buttonDrugDetails.Text = "İlaç Detayına Git";
            this.buttonDrugDetails.UseVisualStyleBackColor = true;
            this.buttonDrugDetails.Click += new System.EventHandler(this.buttonDrugDetails_Click);
            // 
            // timerMessages
            // 
            this.timerMessages.Enabled = true;
            this.timerMessages.Interval = 1000;
            this.timerMessages.Tick += new System.EventHandler(this.timerMessages_Tick);
            // 
            // labelRemainingToRefresh
            // 
            this.labelRemainingToRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelRemainingToRefresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelRemainingToRefresh.Location = new System.Drawing.Point(417, 541);
            this.labelRemainingToRefresh.Name = "labelRemainingToRefresh";
            this.labelRemainingToRefresh.Size = new System.Drawing.Size(580, 24);
            this.labelRemainingToRefresh.TabIndex = 5;
            this.labelRemainingToRefresh.Text = "Remaining Time To Refresh : ";
            this.labelRemainingToRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MessagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.labelRemainingToRefresh);
            this.Controls.Add(this.buttonDrugDetails);
            this.Controls.Add(this.labelSelectedDrug);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dataGridViewDrugList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagesForm";
            this.Text = "MessagesForm";
            this.Load += new System.EventHandler(this.MessagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDrugList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDrugList;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BARKOD_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.DataGridViewTextBoxColumn ILAC_ADI;
        private System.Windows.Forms.DataGridViewTextBoxColumn MESAJSAYISI;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAMAMLANMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreate;
        private System.Windows.Forms.Label labelSelectedDrug;
        private System.Windows.Forms.Button buttonDrugDetails;
        private System.Windows.Forms.Timer timerMessages;
        private System.Windows.Forms.Label labelRemainingToRefresh;
    }
}