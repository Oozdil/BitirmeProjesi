namespace TalkToMePharmaDashBoard
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelFormInfo = new System.Windows.Forms.Label();
            this.chartTopDrugs = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.labelTopDrugs = new System.Windows.Forms.Label();
            this.labelTopUsers = new System.Windows.Forms.Label();
            this.dataGridViewStatisticsList = new System.Windows.Forms.DataGridView();
            this.DrugName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RRS_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlStats = new System.Windows.Forms.TabControl();
            this.tabPageGraphs = new System.Windows.Forms.TabPage();
            this.labelLastUpdate = new System.Windows.Forms.Label();
            this.tabPageGrid = new System.Windows.Forms.TabPage();
            this.timerStatistics = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopDrugs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatisticsList)).BeginInit();
            this.tabControlStats.SuspendLayout();
            this.tabPageGraphs.SuspendLayout();
            this.tabPageGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelFormInfo
            // 
            this.labelFormInfo.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFormInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFormInfo.Location = new System.Drawing.Point(40, 3);
            this.labelFormInfo.Name = "labelFormInfo";
            this.labelFormInfo.Size = new System.Drawing.Size(934, 26);
            this.labelFormInfo.TabIndex = 0;
            this.labelFormInfo.Text = "UYGULAMA VE KULLANICI İSTATİSTİKLERİ";
            this.labelFormInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chartTopDrugs
            // 
            this.chartTopDrugs.BorderlineColor = System.Drawing.Color.OrangeRed;
            chartArea1.Name = "ChartArea1";
            this.chartTopDrugs.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTopDrugs.Legends.Add(legend1);
            this.chartTopDrugs.Location = new System.Drawing.Point(22, 136);
            this.chartTopDrugs.Name = "chartTopDrugs";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTopDrugs.Series.Add(series1);
            this.chartTopDrugs.Size = new System.Drawing.Size(431, 370);
            this.chartTopDrugs.TabIndex = 1;
            this.chartTopDrugs.Text = "chart1";
            // 
            // chartTopUsers
            // 
            this.chartTopUsers.BorderlineColor = System.Drawing.Color.OrangeRed;
            chartArea2.Name = "ChartArea1";
            this.chartTopUsers.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartTopUsers.Legends.Add(legend2);
            this.chartTopUsers.Location = new System.Drawing.Point(561, 136);
            this.chartTopUsers.Name = "chartTopUsers";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTopUsers.Series.Add(series2);
            this.chartTopUsers.Size = new System.Drawing.Size(431, 370);
            this.chartTopUsers.TabIndex = 2;
            this.chartTopUsers.Text = "chart2";
            // 
            // labelTopDrugs
            // 
            this.labelTopDrugs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTopDrugs.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTopDrugs.Location = new System.Drawing.Point(18, 48);
            this.labelTopDrugs.Name = "labelTopDrugs";
            this.labelTopDrugs.Size = new System.Drawing.Size(435, 68);
            this.labelTopDrugs.TabIndex = 3;
            this.labelTopDrugs.Text = "EN ÇOK DİNLENEN İLK 5 İLAÇ";
            this.labelTopDrugs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTopUsers
            // 
            this.labelTopUsers.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTopUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelTopUsers.Location = new System.Drawing.Point(557, 48);
            this.labelTopUsers.Name = "labelTopUsers";
            this.labelTopUsers.Size = new System.Drawing.Size(435, 68);
            this.labelTopUsers.TabIndex = 4;
            this.labelTopUsers.Text = "UYGULAMAYI EN AKTİF KULLANAN İLK 5 KULLANICI";
            this.labelTopUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewStatisticsList
            // 
            this.dataGridViewStatisticsList.AllowUserToAddRows = false;
            this.dataGridViewStatisticsList.AllowUserToDeleteRows = false;
            this.dataGridViewStatisticsList.AllowUserToResizeColumns = false;
            this.dataGridViewStatisticsList.AllowUserToResizeRows = false;
            this.dataGridViewStatisticsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewStatisticsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewStatisticsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewStatisticsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStatisticsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrugName,
            this.Barcode,
            this.ID,
            this.RRS_Status,
            this.DateOfCreate});
            this.dataGridViewStatisticsList.EnableHeadersVisualStyles = false;
            this.dataGridViewStatisticsList.Location = new System.Drawing.Point(50, 6);
            this.dataGridViewStatisticsList.MultiSelect = false;
            this.dataGridViewStatisticsList.Name = "dataGridViewStatisticsList";
            this.dataGridViewStatisticsList.ReadOnly = true;
            this.dataGridViewStatisticsList.RowHeadersVisible = false;
            this.dataGridViewStatisticsList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridViewStatisticsList.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewStatisticsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStatisticsList.Size = new System.Drawing.Size(902, 551);
            this.dataGridViewStatisticsList.TabIndex = 5;
            // 
            // DrugName
            // 
            this.DrugName.HeaderText = "Drug Name";
            this.DrugName.Name = "DrugName";
            this.DrugName.ReadOnly = true;
            this.DrugName.Width = 400;
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            this.Barcode.Width = 110;
            // 
            // ID
            // 
            this.ID.HeaderText = "BARCODE ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // RRS_Status
            // 
            this.RRS_Status.HeaderText = "USER ID";
            this.RRS_Status.Name = "RRS_Status";
            this.RRS_Status.ReadOnly = true;
            // 
            // DateOfCreate
            // 
            this.DateOfCreate.HeaderText = "Date Of Create";
            this.DateOfCreate.Name = "DateOfCreate";
            this.DateOfCreate.ReadOnly = true;
            this.DateOfCreate.Width = 150;
            // 
            // tabControlStats
            // 
            this.tabControlStats.Controls.Add(this.tabPageGraphs);
            this.tabControlStats.Controls.Add(this.tabPageGrid);
            this.tabControlStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlStats.Location = new System.Drawing.Point(0, 0);
            this.tabControlStats.Name = "tabControlStats";
            this.tabControlStats.SelectedIndex = 0;
            this.tabControlStats.Size = new System.Drawing.Size(1035, 583);
            this.tabControlStats.TabIndex = 6;
            // 
            // tabPageGraphs
            // 
            this.tabPageGraphs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tabPageGraphs.Controls.Add(this.labelLastUpdate);
            this.tabPageGraphs.Controls.Add(this.chartTopDrugs);
            this.tabPageGraphs.Controls.Add(this.labelFormInfo);
            this.tabPageGraphs.Controls.Add(this.labelTopDrugs);
            this.tabPageGraphs.Controls.Add(this.labelTopUsers);
            this.tabPageGraphs.Controls.Add(this.chartTopUsers);
            this.tabPageGraphs.Location = new System.Drawing.Point(4, 22);
            this.tabPageGraphs.Name = "tabPageGraphs";
            this.tabPageGraphs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGraphs.Size = new System.Drawing.Size(1027, 557);
            this.tabPageGraphs.TabIndex = 0;
            this.tabPageGraphs.Text = "GRAFİKLER";
            // 
            // labelLastUpdate
            // 
            this.labelLastUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelLastUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelLastUpdate.Location = new System.Drawing.Point(58, 521);
            this.labelLastUpdate.Name = "labelLastUpdate";
            this.labelLastUpdate.Size = new System.Drawing.Size(934, 26);
            this.labelLastUpdate.TabIndex = 5;
            this.labelLastUpdate.Text = "Son Guncelleme :";
            this.labelLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPageGrid
            // 
            this.tabPageGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.tabPageGrid.Controls.Add(this.dataGridViewStatisticsList);
            this.tabPageGrid.Location = new System.Drawing.Point(4, 22);
            this.tabPageGrid.Name = "tabPageGrid";
            this.tabPageGrid.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGrid.Size = new System.Drawing.Size(1027, 557);
            this.tabPageGrid.TabIndex = 1;
            this.tabPageGrid.Text = "TÜM ARAMALAR";
            // 
            // timerStatistics
            // 
            this.timerStatistics.Interval = 30000;
            this.timerStatistics.Tick += new System.EventHandler(this.timerStatistics_Tick);
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1035, 583);
            this.Controls.Add(this.tabControlStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartTopDrugs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStatisticsList)).EndInit();
            this.tabControlStats.ResumeLayout(false);
            this.tabPageGraphs.ResumeLayout(false);
            this.tabPageGrid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFormInfo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopDrugs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopUsers;
        private System.Windows.Forms.Label labelTopDrugs;
        private System.Windows.Forms.Label labelTopUsers;
        private System.Windows.Forms.DataGridView dataGridViewStatisticsList;
        private System.Windows.Forms.TabControl tabControlStats;
        private System.Windows.Forms.TabPage tabPageGraphs;
        private System.Windows.Forms.TabPage tabPageGrid;
        private System.Windows.Forms.Label labelLastUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrugName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RRS_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfCreate;
        public System.Windows.Forms.Timer timerStatistics;
    }
}