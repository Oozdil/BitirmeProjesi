namespace TalkToMePharmaDashBoard
{
    partial class CreateSoundFileForm
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelForBarcode = new System.Windows.Forms.Label();
            this.labelForSoundFile = new System.Windows.Forms.Label();
            this.labelForText = new System.Windows.Forms.Label();
            this.pictureBoxLoading = new System.Windows.Forms.PictureBox();
            this.checkBoxDelete = new System.Windows.Forms.CheckBox();
            this.checkBoxCreate = new System.Windows.Forms.CheckBox();
            this.checkBoxUpdate = new System.Windows.Forms.CheckBox();
            this.labelText = new System.Windows.Forms.Label();
            this.labelSoundFile = new System.Windows.Forms.Label();
            this.labelBarcode = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.labelPleaseWait = new System.Windows.Forms.Label();
            this.timerCreateSoundFile = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorkerCreateSoundFile = new System.ComponentModel.BackgroundWorker();
            this.panelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.Navy;
            this.panelContainer.Controls.Add(this.labelPleaseWait);
            this.panelContainer.Controls.Add(this.labelInfo);
            this.panelContainer.Controls.Add(this.labelText);
            this.panelContainer.Controls.Add(this.labelSoundFile);
            this.panelContainer.Controls.Add(this.labelBarcode);
            this.panelContainer.Controls.Add(this.checkBoxUpdate);
            this.panelContainer.Controls.Add(this.checkBoxCreate);
            this.panelContainer.Controls.Add(this.checkBoxDelete);
            this.panelContainer.Controls.Add(this.pictureBoxLoading);
            this.panelContainer.Controls.Add(this.labelForText);
            this.panelContainer.Controls.Add(this.labelForSoundFile);
            this.panelContainer.Controls.Add(this.labelForBarcode);
            this.panelContainer.Location = new System.Drawing.Point(10, 8);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(333, 334);
            this.panelContainer.TabIndex = 0;
            // 
            // labelForBarcode
            // 
            this.labelForBarcode.AutoSize = true;
            this.labelForBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForBarcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForBarcode.Location = new System.Drawing.Point(19, 13);
            this.labelForBarcode.Name = "labelForBarcode";
            this.labelForBarcode.Size = new System.Drawing.Size(74, 19);
            this.labelForBarcode.TabIndex = 0;
            this.labelForBarcode.Text = "Barcode :";
            // 
            // labelForSoundFile
            // 
            this.labelForSoundFile.AutoSize = true;
            this.labelForSoundFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForSoundFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForSoundFile.Location = new System.Drawing.Point(5, 43);
            this.labelForSoundFile.Name = "labelForSoundFile";
            this.labelForSoundFile.Size = new System.Drawing.Size(88, 19);
            this.labelForSoundFile.TabIndex = 1;
            this.labelForSoundFile.Text = "Sound File :";
            // 
            // labelForText
            // 
            this.labelForText.AutoSize = true;
            this.labelForText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelForText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelForText.Location = new System.Drawing.Point(45, 72);
            this.labelForText.Name = "labelForText";
            this.labelForText.Size = new System.Drawing.Size(48, 19);
            this.labelForText.TabIndex = 2;
            this.labelForText.Text = "Text :";
            // 
            // pictureBoxLoading
            // 
            this.pictureBoxLoading.Image = global::TalkToMePharmaDashBoard.Properties.Resources.loading2;
            this.pictureBoxLoading.Location = new System.Drawing.Point(19, 203);
            this.pictureBoxLoading.Name = "pictureBoxLoading";
            this.pictureBoxLoading.Size = new System.Drawing.Size(302, 116);
            this.pictureBoxLoading.TabIndex = 3;
            this.pictureBoxLoading.TabStop = false;
            // 
            // checkBoxDelete
            // 
            this.checkBoxDelete.AutoCheck = false;
            this.checkBoxDelete.AutoSize = true;
            this.checkBoxDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDelete.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxDelete.Location = new System.Drawing.Point(19, 110);
            this.checkBoxDelete.Name = "checkBoxDelete";
            this.checkBoxDelete.Size = new System.Drawing.Size(147, 23);
            this.checkBoxDelete.TabIndex = 4;
            this.checkBoxDelete.Text = "Eski dosya silindi ...";
            this.checkBoxDelete.UseVisualStyleBackColor = true;
            // 
            // checkBoxCreate
            // 
            this.checkBoxCreate.AutoCheck = false;
            this.checkBoxCreate.AutoSize = true;
            this.checkBoxCreate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxCreate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxCreate.Location = new System.Drawing.Point(19, 139);
            this.checkBoxCreate.Name = "checkBoxCreate";
            this.checkBoxCreate.Size = new System.Drawing.Size(184, 23);
            this.checkBoxCreate.TabIndex = 5;
            this.checkBoxCreate.Text = "Ses dosyası oluşturuldu ...";
            this.checkBoxCreate.UseVisualStyleBackColor = true;
            // 
            // checkBoxUpdate
            // 
            this.checkBoxUpdate.AutoCheck = false;
            this.checkBoxUpdate.AutoSize = true;
            this.checkBoxUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxUpdate.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBoxUpdate.Location = new System.Drawing.Point(19, 168);
            this.checkBoxUpdate.Name = "checkBoxUpdate";
            this.checkBoxUpdate.Size = new System.Drawing.Size(196, 23);
            this.checkBoxUpdate.TabIndex = 6;
            this.checkBoxUpdate.Text = "Ses dosyası upload edildi ...";
            this.checkBoxUpdate.UseVisualStyleBackColor = true;
            // 
            // labelText
            // 
            this.labelText.AutoSize = true;
            this.labelText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelText.Location = new System.Drawing.Point(97, 73);
            this.labelText.Name = "labelText";
            this.labelText.Size = new System.Drawing.Size(48, 19);
            this.labelText.TabIndex = 9;
            this.labelText.Text = "Text :";
            // 
            // labelSoundFile
            // 
            this.labelSoundFile.AutoSize = true;
            this.labelSoundFile.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoundFile.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelSoundFile.Location = new System.Drawing.Point(97, 44);
            this.labelSoundFile.Name = "labelSoundFile";
            this.labelSoundFile.Size = new System.Drawing.Size(88, 19);
            this.labelSoundFile.TabIndex = 8;
            this.labelSoundFile.Text = "Sound File :";
            // 
            // labelBarcode
            // 
            this.labelBarcode.AutoSize = true;
            this.labelBarcode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBarcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBarcode.Location = new System.Drawing.Point(97, 14);
            this.labelBarcode.Name = "labelBarcode";
            this.labelBarcode.Size = new System.Drawing.Size(74, 19);
            this.labelBarcode.TabIndex = 7;
            this.labelBarcode.Text = "Barcode :";
            // 
            // labelInfo
            // 
            this.labelInfo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelInfo.ForeColor = System.Drawing.Color.Red;
            this.labelInfo.Location = new System.Drawing.Point(43, 215);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(247, 25);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "İşlem başladı";
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPleaseWait
            // 
            this.labelPleaseWait.BackColor = System.Drawing.Color.LightSteelBlue;
            this.labelPleaseWait.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelPleaseWait.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPleaseWait.ForeColor = System.Drawing.Color.Green;
            this.labelPleaseWait.Location = new System.Drawing.Point(43, 286);
            this.labelPleaseWait.Name = "labelPleaseWait";
            this.labelPleaseWait.Size = new System.Drawing.Size(247, 25);
            this.labelPleaseWait.TabIndex = 11;
            this.labelPleaseWait.Text = "İşlem sürüyor, lütfen bekleyiniz ...";
            this.labelPleaseWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPleaseWait.Visible = false;
            // 
            // timerCreateSoundFile
            // 
            this.timerCreateSoundFile.Enabled = true;
            this.timerCreateSoundFile.Interval = 1000;
            this.timerCreateSoundFile.Tick += new System.EventHandler(this.timerCreateSoundFile_Tick);
            // 
            // CreateSoundFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(352, 348);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateSoundFileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateSoundFileForm";
            this.Load += new System.EventHandler(this.CreateSoundFileForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLoading)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBoxLoading;
        private System.Windows.Forms.Label labelForText;
        private System.Windows.Forms.Label labelForSoundFile;
        private System.Windows.Forms.Label labelForBarcode;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label labelText;
        private System.Windows.Forms.Label labelSoundFile;
        private System.Windows.Forms.Label labelBarcode;
        private System.Windows.Forms.CheckBox checkBoxUpdate;
        private System.Windows.Forms.CheckBox checkBoxCreate;
        private System.Windows.Forms.CheckBox checkBoxDelete;
        private System.Windows.Forms.Label labelPleaseWait;
        private System.Windows.Forms.Timer timerCreateSoundFile;
        private System.ComponentModel.BackgroundWorker backgroundWorkerCreateSoundFile;

    }
}