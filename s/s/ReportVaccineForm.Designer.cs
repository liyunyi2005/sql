namespace CommunityHospital
{
    partial class ReportVaccineForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelCondition = new System.Windows.Forms.Panel();
            this.lblDateRange = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.lblVaccineType = new System.Windows.Forms.Label();
            this.cmbVaccineType = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelStats = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.VaccineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Manufacturer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalVaccinated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age0_6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age7_17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age18_59 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age60 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Male = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Female = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VaccinationRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(185, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "疫苗接种统计报表";
            // 
            // panelCondition
            // 
            this.panelCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.panelCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCondition.Controls.Add(this.lblDateRange);
            this.panelCondition.Controls.Add(this.dtpStart);
            this.panelCondition.Controls.Add(this.lblTo);
            this.panelCondition.Controls.Add(this.dtpEnd);
            this.panelCondition.Controls.Add(this.lblVaccineType);
            this.panelCondition.Controls.Add(this.cmbVaccineType);
            this.panelCondition.Controls.Add(this.btnQuery);
            this.panelCondition.Controls.Add(this.btnExport);
            this.panelCondition.Location = new System.Drawing.Point(20, 70);
            this.panelCondition.Name = "panelCondition";
            this.panelCondition.Size = new System.Drawing.Size(890, 80);
            this.panelCondition.TabIndex = 1;
            // 
            // lblDateRange
            // 
            this.lblDateRange.AutoSize = true;
            this.lblDateRange.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblDateRange.Location = new System.Drawing.Point(20, 30);
            this.lblDateRange.Name = "lblDateRange";
            this.lblDateRange.Size = new System.Drawing.Size(75, 20);
            this.lblDateRange.TabIndex = 0;
            this.lblDateRange.Text = "统计时间：";
            // 
            // dtpStart
            // 
            this.dtpStart.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(100, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(120, 25);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Value = new System.DateTime(2024, 11, 24, 0, 0, 0, 0);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblTo.Location = new System.Drawing.Point(230, 30);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(20, 20);
            this.lblTo.TabIndex = 2;
            this.lblTo.Text = "至";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(250, 27);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(120, 25);
            this.dtpEnd.TabIndex = 3;
            this.dtpEnd.Value = new System.DateTime(2024, 12, 24, 0, 0, 0, 0);
            // 
            // lblVaccineType
            // 
            this.lblVaccineType.AutoSize = true;
            this.lblVaccineType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblVaccineType.Location = new System.Drawing.Point(400, 30);
            this.lblVaccineType.Name = "lblVaccineType";
            this.lblVaccineType.Size = new System.Drawing.Size(75, 20);
            this.lblVaccineType.TabIndex = 4;
            this.lblVaccineType.Text = "疫苗类型：";
            // 
            // cmbVaccineType
            // 
            this.cmbVaccineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVaccineType.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.cmbVaccineType.FormattingEnabled = true;
            this.cmbVaccineType.Items.AddRange(new object[] {
            "全部疫苗",
            "新冠疫苗",
            "流感疫苗",
            "乙肝疫苗",
            "其他疫苗"});
            this.cmbVaccineType.Location = new System.Drawing.Point(480, 27);
            this.cmbVaccineType.Name = "cmbVaccineType";
            this.cmbVaccineType.Size = new System.Drawing.Size(150, 28);
            this.cmbVaccineType.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnQuery.ForeColor = System.Drawing.Color.White;
            this.btnQuery.Location = new System.Drawing.Point(670, 25);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(100, 30);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "生成统计";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnExport.Location = new System.Drawing.Point(780, 25);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(100, 30);
            this.btnExport.TabIndex = 7;
            this.btnExport.Text = "导出报表";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VaccineName,
            this.Manufacturer,
            this.TotalVaccinated,
            this.Age0_6,
            this.Age7_17,
            this.Age18_59,
            this.Age60,
            this.Male,
            this.Female,
            this.VaccinationRate});
            this.dataGridView.Location = new System.Drawing.Point(20, 170);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(890, 380);
            this.dataGridView.TabIndex = 2;
            // 
            // panelStats
            // 
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(240)))));
            this.panelStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelStats.Location = new System.Drawing.Point(20, 560);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(890, 80);
            this.panelStats.TabIndex = 3;
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnPrint.Location = new System.Drawing.Point(720, 570);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 35);
            this.btnPrint.TabIndex = 4;
            this.btnPrint.Text = "打印报表";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnClose.Location = new System.Drawing.Point(830, 570);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // VaccineName
            // 
            this.VaccineName.DataPropertyName = "VaccineName";
            this.VaccineName.HeaderText = "疫苗名称";
            this.VaccineName.Name = "VaccineName";
            this.VaccineName.ReadOnly = true;
            // 
            // Manufacturer
            // 
            this.Manufacturer.DataPropertyName = "Manufacturer";
            this.Manufacturer.HeaderText = "生产厂家";
            this.Manufacturer.Name = "Manufacturer";
            this.Manufacturer.ReadOnly = true;
            // 
            // TotalVaccinated
            // 
            this.TotalVaccinated.DataPropertyName = "TotalVaccinated";
            this.TotalVaccinated.HeaderText = "接种总人次";
            this.TotalVaccinated.Name = "TotalVaccinated";
            this.TotalVaccinated.ReadOnly = true;
            // 
            // Age0_6
            // 
            this.Age0_6.DataPropertyName = "Age0_6";
            this.Age0_6.HeaderText = "0-6岁";
            this.Age0_6.Name = "Age0_6";
            this.Age0_6.ReadOnly = true;
            // 
            // Age7_17
            // 
            this.Age7_17.DataPropertyName = "Age7_17";
            this.Age7_17.HeaderText = "7-17岁";
            this.Age7_17.Name = "Age7_17";
            this.Age7_17.ReadOnly = true;
            // 
            // Age18_59
            // 
            this.Age18_59.DataPropertyName = "Age18_59";
            this.Age18_59.HeaderText = "18-59岁";
            this.Age18_59.Name = "Age18_59";
            this.Age18_59.ReadOnly = true;
            // 
            // Age60
            // 
            this.Age60.DataPropertyName = "Age60";
            this.Age60.HeaderText = "60岁及以上";
            this.Age60.Name = "Age60";
            this.Age60.ReadOnly = true;
            // 
            // Male
            // 
            this.Male.DataPropertyName = "Male";
            this.Male.HeaderText = "男性";
            this.Male.Name = "Male";
            this.Male.ReadOnly = true;
            // 
            // Female
            // 
            this.Female.DataPropertyName = "Female";
            this.Female.HeaderText = "女性";
            this.Female.Name = "Female";
            this.Female.ReadOnly = true;
            // 
            // VaccinationRate
            // 
            this.VaccinationRate.DataPropertyName = "VaccinationRate";
            this.VaccinationRate.HeaderText = "接种率";
            this.VaccinationRate.Name = "VaccinationRate";
            this.VaccinationRate.ReadOnly = true;
            // 
            // ReportVaccineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 650);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelCondition);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ReportVaccineForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "疫苗接种统计报表";
            this.panelCondition.ResumeLayout(false);
            this.panelCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.Label lblDateRange;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label lblVaccineType;
        private System.Windows.Forms.ComboBox cmbVaccineType;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manufacturer;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalVaccinated;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age0_6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age7_17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age18_59;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age60;
        private System.Windows.Forms.DataGridViewTextBoxColumn Male;
        private System.Windows.Forms.DataGridViewTextBoxColumn Female;
        private System.Windows.Forms.DataGridViewTextBoxColumn VaccinationRate;
    }
}