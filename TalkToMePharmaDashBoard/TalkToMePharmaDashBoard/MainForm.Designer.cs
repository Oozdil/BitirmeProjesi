namespace TalkToMePharmaDashBoard
{
    partial class MainForm
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
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonAboutPage = new System.Windows.Forms.Button();
            this.buttonAddNewUserPage = new System.Windows.Forms.Button();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.buttonMessagesPage = new System.Windows.Forms.Button();
            this.buttonNewDrugPage = new System.Windows.Forms.Button();
            this.buttonDrugListPage = new System.Windows.Forms.Button();
            this.labelAppName = new System.Windows.Forms.Label();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.timerMainForm = new System.Windows.Forms.Timer(this.components);
            this.panelContainer.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(215)))));
            this.panelContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelContainer.Controls.Add(this.panelBody);
            this.panelContainer.Controls.Add(this.panelHeader);
            this.panelContainer.Controls.Add(this.panelMenu);
            this.panelContainer.Location = new System.Drawing.Point(0, 28);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1239, 650);
            this.panelContainer.TabIndex = 0;
            // 
            // panelBody
            // 
            this.panelBody.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(200, 63);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1035, 583);
            this.panelBody.TabIndex = 2;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Lavender;
            this.panelHeader.Controls.Add(this.labelPageInfo);
            this.panelHeader.Controls.Add(this.labelUser);
            this.panelHeader.Controls.Add(this.labelTime);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(200, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1035, 63);
            this.panelHeader.TabIndex = 1;
            // 
            // labelPageInfo
            // 
            this.labelPageInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPageInfo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPageInfo.ForeColor = System.Drawing.Color.Blue;
            this.labelPageInfo.Location = new System.Drawing.Point(5, 33);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(1022, 27);
            this.labelPageInfo.TabIndex = 6;
            this.labelPageInfo.Text = "Time";
            this.labelPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelUser
            // 
            this.labelUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUser.ForeColor = System.Drawing.Color.Blue;
            this.labelUser.Location = new System.Drawing.Point(445, 3);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(585, 27);
            this.labelUser.TabIndex = 5;
            this.labelUser.Text = "Orçun ÖZDİL 172 80 30 65 Bitirme Projesi";
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTime
            // 
            this.labelTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTime.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTime.ForeColor = System.Drawing.Color.Blue;
            this.labelTime.Location = new System.Drawing.Point(5, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(303, 27);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(250)))));
            this.panelMenu.Controls.Add(this.buttonAboutPage);
            this.panelMenu.Controls.Add(this.buttonAddNewUserPage);
            this.panelMenu.Controls.Add(this.buttonStatistics);
            this.panelMenu.Controls.Add(this.buttonMessagesPage);
            this.panelMenu.Controls.Add(this.buttonNewDrugPage);
            this.panelMenu.Controls.Add(this.buttonDrugListPage);
            this.panelMenu.Controls.Add(this.labelAppName);
            this.panelMenu.Controls.Add(this.pictureBoxLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 646);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonAboutPage
            // 
            this.buttonAboutPage.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonAboutPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAboutPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAboutPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAboutPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAboutPage.Location = new System.Drawing.Point(0, 557);
            this.buttonAboutPage.Name = "buttonAboutPage";
            this.buttonAboutPage.Size = new System.Drawing.Size(200, 87);
            this.buttonAboutPage.TabIndex = 8;
            this.buttonAboutPage.Text = "Proje Hakkında";
            this.buttonAboutPage.UseVisualStyleBackColor = false;
            this.buttonAboutPage.Click += new System.EventHandler(this.buttonAboutPage_Click);
            // 
            // buttonAddNewUserPage
            // 
            this.buttonAddNewUserPage.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonAddNewUserPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddNewUserPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNewUserPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonAddNewUserPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddNewUserPage.Location = new System.Drawing.Point(0, 470);
            this.buttonAddNewUserPage.Name = "buttonAddNewUserPage";
            this.buttonAddNewUserPage.Size = new System.Drawing.Size(200, 87);
            this.buttonAddNewUserPage.TabIndex = 7;
            this.buttonAddNewUserPage.Text = "Yönetici Ekle";
            this.buttonAddNewUserPage.UseVisualStyleBackColor = false;
            this.buttonAddNewUserPage.Click += new System.EventHandler(this.buttonAddNewUserPage_Click);
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatistics.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonStatistics.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStatistics.Location = new System.Drawing.Point(0, 383);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(200, 87);
            this.buttonStatistics.TabIndex = 6;
            this.buttonStatistics.Text = "İstatistikler";
            this.buttonStatistics.UseVisualStyleBackColor = false;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // buttonMessagesPage
            // 
            this.buttonMessagesPage.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonMessagesPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMessagesPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMessagesPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonMessagesPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMessagesPage.Location = new System.Drawing.Point(0, 296);
            this.buttonMessagesPage.Name = "buttonMessagesPage";
            this.buttonMessagesPage.Size = new System.Drawing.Size(200, 87);
            this.buttonMessagesPage.TabIndex = 5;
            this.buttonMessagesPage.Text = "Mesajlar";
            this.buttonMessagesPage.UseVisualStyleBackColor = false;
            this.buttonMessagesPage.Click += new System.EventHandler(this.buttonMessagesPage_Click);
            // 
            // buttonNewDrugPage
            // 
            this.buttonNewDrugPage.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonNewDrugPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonNewDrugPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewDrugPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonNewDrugPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNewDrugPage.Location = new System.Drawing.Point(0, 209);
            this.buttonNewDrugPage.Name = "buttonNewDrugPage";
            this.buttonNewDrugPage.Size = new System.Drawing.Size(200, 87);
            this.buttonNewDrugPage.TabIndex = 4;
            this.buttonNewDrugPage.Text = "Yeni İlaç Ekle";
            this.buttonNewDrugPage.UseVisualStyleBackColor = false;
            this.buttonNewDrugPage.Click += new System.EventHandler(this.buttonNewDrugPage_Click);
            // 
            // buttonDrugListPage
            // 
            this.buttonDrugListPage.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonDrugListPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonDrugListPage.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrugListPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrugListPage.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonDrugListPage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDrugListPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDrugListPage.Location = new System.Drawing.Point(0, 122);
            this.buttonDrugListPage.Name = "buttonDrugListPage";
            this.buttonDrugListPage.Size = new System.Drawing.Size(200, 87);
            this.buttonDrugListPage.TabIndex = 3;
            this.buttonDrugListPage.Text = "İlaç Listesi";
            this.buttonDrugListPage.UseVisualStyleBackColor = false;
            this.buttonDrugListPage.Click += new System.EventHandler(this.buttonDrugListPage_Click);
            // 
            // labelAppName
            // 
            this.labelAppName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelAppName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAppName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAppName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAppName.Location = new System.Drawing.Point(0, 63);
            this.labelAppName.Name = "labelAppName";
            this.labelAppName.Size = new System.Drawing.Size(200, 59);
            this.labelAppName.TabIndex = 2;
            this.labelAppName.Text = "Talk To Me Pharma DashBoard";
            this.labelAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.BackgroundImage = global::TalkToMePharmaDashBoard.Properties.Resources.uniLogo;
            this.pictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBoxLogo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(200, 63);
            this.pictureBoxLogo.TabIndex = 0;
            this.pictureBoxLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1210, -1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(29, 29);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // labelHeader
            // 
            this.labelHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHeader.Location = new System.Drawing.Point(471, 1);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(317, 27);
            this.labelHeader.TabIndex = 2;
            this.labelHeader.Text = "Orçun ÖZDİL 172 80 30 65 Bitirme Projesi";
            this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFooter
            // 
            this.labelFooter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFooter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFooter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFooter.Location = new System.Drawing.Point(484, 678);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(317, 22);
            this.labelFooter.TabIndex = 3;
            this.labelFooter.Text = "MCBU © 2020";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerMainForm
            // 
            this.timerMainForm.Enabled = true;
            this.timerMainForm.Interval = 1000;
            this.timerMainForm.Tick += new System.EventHandler(this.timerMainForm_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(132)))));
            this.ClientSize = new System.Drawing.Size(1239, 700);
            this.Controls.Add(this.labelFooter);
            this.Controls.Add(this.labelHeader);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelContainer.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Label labelAppName;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button buttonAboutPage;
        private System.Windows.Forms.Button buttonAddNewUserPage;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.Button buttonMessagesPage;
        private System.Windows.Forms.Button buttonNewDrugPage;
        private System.Windows.Forms.Button buttonDrugListPage;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Timer timerMainForm;
        private System.Windows.Forms.Label labelPageInfo;
    }
}