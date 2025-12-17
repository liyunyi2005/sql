namespace CommunityHospital
{
    partial class RecordAddForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panelTitle = new System.Windows.Forms.Panel();
			this.labelTitle = new System.Windows.Forms.Label();
			this.tabControlMain = new System.Windows.Forms.TabControl();
			this.tabPageRegistration = new System.Windows.Forms.TabPage();
			this.panelMain = new System.Windows.Forms.Panel();
			this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelBasic = new System.Windows.Forms.TableLayoutPanel();
			this.labelAppointmentSearch = new System.Windows.Forms.Label();
			this.txtAppointmentSearch = new System.Windows.Forms.TextBox();
			this.btnSearchAppointment = new System.Windows.Forms.Button();
			this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
			this.groupBoxVaccinationInfo = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelVaccination = new System.Windows.Forms.TableLayoutPanel();
			this.labelVaccinationTime = new System.Windows.Forms.Label();
			this.dateTimeVaccination = new System.Windows.Forms.DateTimePicker();
			this.labelVaccineSite = new System.Windows.Forms.Label();
			this.comboVaccineSite = new System.Windows.Forms.ComboBox();
			this.labelDoctor = new System.Windows.Forms.Label();
			this.comboDoctor = new System.Windows.Forms.ComboBox();
			this.labelBatchNo = new System.Windows.Forms.Label();
			this.txtBatchNo = new System.Windows.Forms.TextBox();
			this.labelReaction = new System.Windows.Forms.Label();
			this.comboReaction = new System.Windows.Forms.ComboBox();
			this.labelTemperature = new System.Windows.Forms.Label();
			this.txtTemperature = new System.Windows.Forms.TextBox();
			this.labelTemperatureUnit = new System.Windows.Forms.Label();
			this.labelBloodPressure = new System.Windows.Forms.Label();
			this.txtBloodPressure = new System.Windows.Forms.TextBox();
			this.labelBPUnit = new System.Windows.Forms.Label();
			this.labelHealthStatus = new System.Windows.Forms.Label();
			this.comboHealthStatus = new System.Windows.Forms.ComboBox();
			this.labelRemark = new System.Windows.Forms.Label();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnComplete = new System.Windows.Forms.Button();
			this.btnSaveDraft = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.tabPageHistory = new System.Windows.Forms.TabPage();
			this.panelHistory = new System.Windows.Forms.Panel();
			this.dataGridViewRecords = new System.Windows.Forms.DataGridView();
			this.panelHistoryButtons = new System.Windows.Forms.Panel();
			this.btnRefreshHistory = new System.Windows.Forms.Button();
			this.btnEditRecord = new System.Windows.Forms.Button();
			this.btnDeleteRecord = new System.Windows.Forms.Button();
			this.btnExportHistory = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelTitle.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageRegistration.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.groupBoxBasicInfo.SuspendLayout();
			this.tableLayoutPanelBasic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
			this.groupBoxVaccinationInfo.SuspendLayout();
			this.tableLayoutPanelVaccination.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.tabPageHistory.SuspendLayout();
			this.panelHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
			this.panelHistoryButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.panelTitle.Controls.Add(this.labelTitle);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1000, 60);
			this.panelTitle.TabIndex = 0;
			// 
			// labelTitle
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelTitle.ForeColor = System.Drawing.Color.White;
			this.labelTitle.Location = new System.Drawing.Point(20, 15);
			this.labelTitle.Name = "labelTitle";
			this.labelTitle.Size = new System.Drawing.Size(158, 31);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "接种记录登记";
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageRegistration);
			this.tabControlMain.Controls.Add(this.tabPageHistory);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabControlMain.Location = new System.Drawing.Point(0, 60);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1000, 640);
			this.tabControlMain.TabIndex = 1;
			// 
			// tabPageRegistration
			// 
			this.tabPageRegistration.Controls.Add(this.panelMain);
			this.tabPageRegistration.Location = new System.Drawing.Point(4, 29);
			this.tabPageRegistration.Name = "tabPageRegistration";
			this.tabPageRegistration.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageRegistration.Size = new System.Drawing.Size(992, 607);
			this.tabPageRegistration.TabIndex = 0;
			this.tabPageRegistration.Text = "接种登记";
			this.tabPageRegistration.UseVisualStyleBackColor = true;
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.groupBoxBasicInfo);
			this.panelMain.Controls.Add(this.groupBoxVaccinationInfo);
			this.panelMain.Controls.Add(this.panelButtons);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(3, 3);
			this.panelMain.Name = "panelMain";
			this.panelMain.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.panelMain.Size = new System.Drawing.Size(986, 601);
			this.panelMain.TabIndex = 0;
			// 
			// groupBoxBasicInfo
			// 
			this.groupBoxBasicInfo.Controls.Add(this.tableLayoutPanelBasic);
			this.groupBoxBasicInfo.Controls.Add(this.dataGridViewAppointments);
			this.groupBoxBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxBasicInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBoxBasicInfo.Location = new System.Drawing.Point(10, 270);
			this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
			this.groupBoxBasicInfo.Size = new System.Drawing.Size(966, 250);
			this.groupBoxBasicInfo.TabIndex = 0;
			this.groupBoxBasicInfo.TabStop = false;
			this.groupBoxBasicInfo.Text = "选择预约记录";
			// 
			// tableLayoutPanelBasic
			// 
			this.tableLayoutPanelBasic.ColumnCount = 3;
			this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
			this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelBasic.Controls.Add(this.labelAppointmentSearch, 0, 0);
			this.tableLayoutPanelBasic.Controls.Add(this.txtAppointmentSearch, 1, 0);
			this.tableLayoutPanelBasic.Controls.Add(this.btnSearchAppointment, 2, 0);
			this.tableLayoutPanelBasic.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelBasic.Location = new System.Drawing.Point(3, 22);
			this.tableLayoutPanelBasic.Name = "tableLayoutPanelBasic";
			this.tableLayoutPanelBasic.RowCount = 1;
			this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelBasic.Size = new System.Drawing.Size(960, 50);
			this.tableLayoutPanelBasic.TabIndex = 1;
			// 
			// labelAppointmentSearch
			// 
			this.labelAppointmentSearch.AutoSize = true;
			this.labelAppointmentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAppointmentSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelAppointmentSearch.Location = new System.Drawing.Point(3, 0);
			this.labelAppointmentSearch.Name = "labelAppointmentSearch";
			this.labelAppointmentSearch.Size = new System.Drawing.Size(138, 50);
			this.labelAppointmentSearch.TabIndex = 0;
			this.labelAppointmentSearch.Text = "预约搜索：";
			this.labelAppointmentSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtAppointmentSearch
			// 
			this.txtAppointmentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtAppointmentSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtAppointmentSearch.Location = new System.Drawing.Point(147, 10);
			this.txtAppointmentSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.txtAppointmentSearch.Name = "txtAppointmentSearch";
			this.txtAppointmentSearch.Size = new System.Drawing.Size(570, 26);
			this.txtAppointmentSearch.TabIndex = 1;
			this.txtAppointmentSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtAppointmentSearch_KeyPress);
			// 
			// btnSearchAppointment
			// 
			this.btnSearchAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSearchAppointment.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSearchAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearchAppointment.Location = new System.Drawing.Point(723, 10);
			this.btnSearchAppointment.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnSearchAppointment.Name = "btnSearchAppointment";
			this.btnSearchAppointment.Size = new System.Drawing.Size(234, 30);
			this.btnSearchAppointment.TabIndex = 2;
			this.btnSearchAppointment.Text = "搜索预约";
			this.btnSearchAppointment.UseVisualStyleBackColor = true;
			this.btnSearchAppointment.Click += new System.EventHandler(this.BtnSearchAppointment_Click);
			// 
			// dataGridViewAppointments
			// 
			this.dataGridViewAppointments.AllowUserToAddRows = false;
			this.dataGridViewAppointments.AllowUserToDeleteRows = false;
			this.dataGridViewAppointments.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dataGridViewAppointments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewAppointments.ColumnHeadersHeight = 40;
			this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewAppointments.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewAppointments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.dataGridViewAppointments.Location = new System.Drawing.Point(3, 78);
			this.dataGridViewAppointments.MultiSelect = false;
			this.dataGridViewAppointments.Name = "dataGridViewAppointments";
			this.dataGridViewAppointments.ReadOnly = true;
			this.dataGridViewAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewAppointments.RowHeadersVisible = false;
			this.dataGridViewAppointments.RowHeadersWidth = 62;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dataGridViewAppointments.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewAppointments.RowTemplate.Height = 35;
			this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewAppointments.Size = new System.Drawing.Size(960, 169);
			this.dataGridViewAppointments.TabIndex = 0;
			this.dataGridViewAppointments.SelectionChanged += new System.EventHandler(this.DataGridViewAppointments_SelectionChanged);
			// 
			// groupBoxVaccinationInfo
			// 
			this.groupBoxVaccinationInfo.Controls.Add(this.tableLayoutPanelVaccination);
			this.groupBoxVaccinationInfo.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxVaccinationInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBoxVaccinationInfo.Location = new System.Drawing.Point(10, 10);
			this.groupBoxVaccinationInfo.Name = "groupBoxVaccinationInfo";
			this.groupBoxVaccinationInfo.Size = new System.Drawing.Size(966, 260);
			this.groupBoxVaccinationInfo.TabIndex = 1;
			this.groupBoxVaccinationInfo.TabStop = false;
			this.groupBoxVaccinationInfo.Text = "接种信息";
			// 
			// tableLayoutPanelVaccination
			// 
			this.tableLayoutPanelVaccination.ColumnCount = 6;
			this.tableLayoutPanelVaccination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelVaccination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelVaccination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelVaccination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelVaccination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelVaccination.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelVaccination.Controls.Add(this.labelVaccinationTime, 0, 0);
			this.tableLayoutPanelVaccination.Controls.Add(this.dateTimeVaccination, 1, 0);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelVaccineSite, 2, 0);
			this.tableLayoutPanelVaccination.Controls.Add(this.comboVaccineSite, 3, 0);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelDoctor, 4, 0);
			this.tableLayoutPanelVaccination.Controls.Add(this.comboDoctor, 5, 0);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelBatchNo, 0, 1);
			this.tableLayoutPanelVaccination.Controls.Add(this.txtBatchNo, 1, 1);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelReaction, 2, 1);
			this.tableLayoutPanelVaccination.Controls.Add(this.comboReaction, 3, 1);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelTemperature, 4, 1);
			this.tableLayoutPanelVaccination.Controls.Add(this.txtTemperature, 5, 1);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelTemperatureUnit, 5, 2);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelBloodPressure, 0, 2);
			this.tableLayoutPanelVaccination.Controls.Add(this.txtBloodPressure, 1, 2);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelBPUnit, 2, 2);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelHealthStatus, 3, 2);
			this.tableLayoutPanelVaccination.Controls.Add(this.comboHealthStatus, 4, 2);
			this.tableLayoutPanelVaccination.Controls.Add(this.labelRemark, 0, 3);
			this.tableLayoutPanelVaccination.Controls.Add(this.txtRemark, 1, 3);
			this.tableLayoutPanelVaccination.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelVaccination.Location = new System.Drawing.Point(3, 22);
			this.tableLayoutPanelVaccination.Name = "tableLayoutPanelVaccination";
			this.tableLayoutPanelVaccination.RowCount = 4;
			this.tableLayoutPanelVaccination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelVaccination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelVaccination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelVaccination.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelVaccination.Size = new System.Drawing.Size(960, 235);
			this.tableLayoutPanelVaccination.TabIndex = 0;
			// 
			// labelVaccinationTime
			// 
			this.labelVaccinationTime.AutoSize = true;
			this.labelVaccinationTime.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVaccinationTime.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelVaccinationTime.Location = new System.Drawing.Point(3, 0);
			this.labelVaccinationTime.Name = "labelVaccinationTime";
			this.labelVaccinationTime.Size = new System.Drawing.Size(138, 58);
			this.labelVaccinationTime.TabIndex = 0;
			this.labelVaccinationTime.Text = "接种时间：";
			this.labelVaccinationTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimeVaccination
			// 
			this.dateTimeVaccination.CustomFormat = "yyyy-MM-dd HH:mm";
			this.dateTimeVaccination.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimeVaccination.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dateTimeVaccination.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimeVaccination.Location = new System.Drawing.Point(147, 10);
			this.dateTimeVaccination.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.dateTimeVaccination.Name = "dateTimeVaccination";
			this.dateTimeVaccination.Size = new System.Drawing.Size(186, 26);
			this.dateTimeVaccination.TabIndex = 1;
			// 
			// labelVaccineSite
			// 
			this.labelVaccineSite.AutoSize = true;
			this.labelVaccineSite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVaccineSite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelVaccineSite.Location = new System.Drawing.Point(339, 0);
			this.labelVaccineSite.Name = "labelVaccineSite";
			this.labelVaccineSite.Size = new System.Drawing.Size(138, 58);
			this.labelVaccineSite.TabIndex = 2;
			this.labelVaccineSite.Text = "接种部位：";
			this.labelVaccineSite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboVaccineSite
			// 
			this.comboVaccineSite.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboVaccineSite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVaccineSite.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboVaccineSite.FormattingEnabled = true;
			this.comboVaccineSite.Items.AddRange(new object[] {
            "左上臂",
            "右上臂",
            "左大腿",
            "右大腿"});
			this.comboVaccineSite.Location = new System.Drawing.Point(483, 10);
			this.comboVaccineSite.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.comboVaccineSite.Name = "comboVaccineSite";
			this.comboVaccineSite.Size = new System.Drawing.Size(186, 28);
			this.comboVaccineSite.TabIndex = 3;
			// 
			// labelDoctor
			// 
			this.labelDoctor.AutoSize = true;
			this.labelDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDoctor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelDoctor.Location = new System.Drawing.Point(675, 0);
			this.labelDoctor.Name = "labelDoctor";
			this.labelDoctor.Size = new System.Drawing.Size(138, 58);
			this.labelDoctor.TabIndex = 4;
			this.labelDoctor.Text = "接种医生：";
			this.labelDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboDoctor
			// 
			this.comboDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDoctor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboDoctor.FormattingEnabled = true;
			this.comboDoctor.Items.AddRange(new object[] {
            "王医生",
            "李医生",
            "张医生",
            "刘医生",
            "赵医生",
            "陈医生"});
			this.comboDoctor.Location = new System.Drawing.Point(819, 10);
			this.comboDoctor.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.comboDoctor.Name = "comboDoctor";
			this.comboDoctor.Size = new System.Drawing.Size(138, 28);
			this.comboDoctor.TabIndex = 5;
			// 
			// labelBatchNo
			// 
			this.labelBatchNo.AutoSize = true;
			this.labelBatchNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBatchNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelBatchNo.Location = new System.Drawing.Point(3, 58);
			this.labelBatchNo.Name = "labelBatchNo";
			this.labelBatchNo.Size = new System.Drawing.Size(138, 58);
			this.labelBatchNo.TabIndex = 6;
			this.labelBatchNo.Text = "疫苗批号：";
			this.labelBatchNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBatchNo
			// 
			this.txtBatchNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBatchNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtBatchNo.Location = new System.Drawing.Point(147, 68);
			this.txtBatchNo.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.txtBatchNo.Name = "txtBatchNo";
			this.txtBatchNo.Size = new System.Drawing.Size(186, 26);
			this.txtBatchNo.TabIndex = 7;
			// 
			// labelReaction
			// 
			this.labelReaction.AutoSize = true;
			this.labelReaction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelReaction.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelReaction.Location = new System.Drawing.Point(339, 58);
			this.labelReaction.Name = "labelReaction";
			this.labelReaction.Size = new System.Drawing.Size(138, 58);
			this.labelReaction.TabIndex = 8;
			this.labelReaction.Text = "不良反应：";
			this.labelReaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboReaction
			// 
			this.comboReaction.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboReaction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboReaction.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboReaction.FormattingEnabled = true;
			this.comboReaction.Items.AddRange(new object[] {
            "无不良反应",
            "轻微红肿",
            "疼痛不适",
            "低热（37.5-38℃）",
            "中热（38-39℃）",
            "高热（>39℃）",
            "头痛头晕",
            "恶心呕吐",
            "其他症状"});
			this.comboReaction.Location = new System.Drawing.Point(483, 68);
			this.comboReaction.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.comboReaction.Name = "comboReaction";
			this.comboReaction.Size = new System.Drawing.Size(186, 28);
			this.comboReaction.TabIndex = 9;
			// 
			// labelTemperature
			// 
			this.labelTemperature.AutoSize = true;
			this.labelTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTemperature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelTemperature.Location = new System.Drawing.Point(675, 58);
			this.labelTemperature.Name = "labelTemperature";
			this.labelTemperature.Size = new System.Drawing.Size(138, 58);
			this.labelTemperature.TabIndex = 10;
			this.labelTemperature.Text = "体温：";
			this.labelTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTemperature
			// 
			this.txtTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtTemperature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtTemperature.Location = new System.Drawing.Point(819, 68);
			this.txtTemperature.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.txtTemperature.Name = "txtTemperature";
			this.txtTemperature.Size = new System.Drawing.Size(138, 26);
			this.txtTemperature.TabIndex = 11;
			// 
			// labelTemperatureUnit
			// 
			this.labelTemperatureUnit.AutoSize = true;
			this.labelTemperatureUnit.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelTemperatureUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelTemperatureUnit.Location = new System.Drawing.Point(819, 116);
			this.labelTemperatureUnit.Name = "labelTemperatureUnit";
			this.labelTemperatureUnit.Size = new System.Drawing.Size(23, 58);
			this.labelTemperatureUnit.TabIndex = 12;
			this.labelTemperatureUnit.Text = "℃";
			this.labelTemperatureUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelBloodPressure
			// 
			this.labelBloodPressure.AutoSize = true;
			this.labelBloodPressure.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelBloodPressure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelBloodPressure.Location = new System.Drawing.Point(3, 116);
			this.labelBloodPressure.Name = "labelBloodPressure";
			this.labelBloodPressure.Size = new System.Drawing.Size(138, 58);
			this.labelBloodPressure.TabIndex = 13;
			this.labelBloodPressure.Text = "血压：";
			this.labelBloodPressure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtBloodPressure
			// 
			this.txtBloodPressure.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtBloodPressure.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtBloodPressure.Location = new System.Drawing.Point(147, 126);
			this.txtBloodPressure.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.txtBloodPressure.Name = "txtBloodPressure";
			this.txtBloodPressure.Size = new System.Drawing.Size(186, 26);
			this.txtBloodPressure.TabIndex = 14;
			// 
			// labelBPUnit
			// 
			this.labelBPUnit.AutoSize = true;
			this.labelBPUnit.Dock = System.Windows.Forms.DockStyle.Left;
			this.labelBPUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelBPUnit.Location = new System.Drawing.Point(339, 116);
			this.labelBPUnit.Name = "labelBPUnit";
			this.labelBPUnit.Size = new System.Drawing.Size(55, 58);
			this.labelBPUnit.TabIndex = 15;
			this.labelBPUnit.Text = "mmHg";
			this.labelBPUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// labelHealthStatus
			// 
			this.labelHealthStatus.AutoSize = true;
			this.labelHealthStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHealthStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelHealthStatus.Location = new System.Drawing.Point(483, 116);
			this.labelHealthStatus.Name = "labelHealthStatus";
			this.labelHealthStatus.Size = new System.Drawing.Size(186, 58);
			this.labelHealthStatus.TabIndex = 16;
			this.labelHealthStatus.Text = "健康状况：";
			this.labelHealthStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboHealthStatus
			// 
			this.comboHealthStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboHealthStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHealthStatus.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboHealthStatus.FormattingEnabled = true;
			this.comboHealthStatus.Items.AddRange(new object[] {
            "健康",
            "亚健康",
            "轻微不适",
            "慢性病控制良好",
            "急性病期"});
			this.comboHealthStatus.Location = new System.Drawing.Point(675, 126);
			this.comboHealthStatus.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.comboHealthStatus.Name = "comboHealthStatus";
			this.comboHealthStatus.Size = new System.Drawing.Size(138, 28);
			this.comboHealthStatus.TabIndex = 17;
			// 
			// labelRemark
			// 
			this.labelRemark.AutoSize = true;
			this.labelRemark.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelRemark.Location = new System.Drawing.Point(3, 174);
			this.labelRemark.Name = "labelRemark";
			this.labelRemark.Size = new System.Drawing.Size(138, 61);
			this.labelRemark.TabIndex = 18;
			this.labelRemark.Text = "备   注：";
			this.labelRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRemark
			// 
			this.tableLayoutPanelVaccination.SetColumnSpan(this.txtRemark, 5);
			this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtRemark.Location = new System.Drawing.Point(147, 184);
			this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.txtRemark.Multiline = true;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRemark.Size = new System.Drawing.Size(810, 41);
			this.txtRemark.TabIndex = 19;
			// 
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.btnComplete);
			this.panelButtons.Controls.Add(this.btnSaveDraft);
			this.panelButtons.Controls.Add(this.btnReset);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(10, 531);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(966, 60);
			this.panelButtons.TabIndex = 2;
			// 
			// btnComplete
			// 
			this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
			this.btnComplete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnComplete.FlatAppearance.BorderSize = 0;
			this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnComplete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnComplete.ForeColor = System.Drawing.Color.White;
			this.btnComplete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnComplete.Location = new System.Drawing.Point(200, 10);
			this.btnComplete.Name = "btnComplete";
			this.btnComplete.Size = new System.Drawing.Size(160, 40);
			this.btnComplete.TabIndex = 0;
			this.btnComplete.Text = "完成接种";
			this.btnComplete.UseVisualStyleBackColor = false;
			this.btnComplete.Click += new System.EventHandler(this.BtnComplete_Click);
			// 
			// btnSaveDraft
			// 
			this.btnSaveDraft.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSaveDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSaveDraft.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSaveDraft.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSaveDraft.Location = new System.Drawing.Point(380, 10);
			this.btnSaveDraft.Name = "btnSaveDraft";
			this.btnSaveDraft.Size = new System.Drawing.Size(160, 40);
			this.btnSaveDraft.TabIndex = 1;
			this.btnSaveDraft.Text = "暂存记录";
			this.btnSaveDraft.UseVisualStyleBackColor = true;
			this.btnSaveDraft.Click += new System.EventHandler(this.BtnSaveDraft_Click);
			// 
			// btnReset
			// 
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(560, 10);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(160, 40);
			this.btnReset.TabIndex = 2;
			this.btnReset.Text = "重  置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// tabPageHistory
			// 
			this.tabPageHistory.Controls.Add(this.panelHistory);
			this.tabPageHistory.Controls.Add(this.panelHistoryButtons);
			this.tabPageHistory.Location = new System.Drawing.Point(4, 29);
			this.tabPageHistory.Name = "tabPageHistory";
			this.tabPageHistory.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageHistory.Size = new System.Drawing.Size(992, 607);
			this.tabPageHistory.TabIndex = 1;
			this.tabPageHistory.Text = "接种记录";
			this.tabPageHistory.UseVisualStyleBackColor = true;
			// 
			// panelHistory
			// 
			this.panelHistory.Controls.Add(this.dataGridViewRecords);
			this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelHistory.Location = new System.Drawing.Point(3, 3);
			this.panelHistory.Name = "panelHistory";
			this.panelHistory.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.panelHistory.Size = new System.Drawing.Size(986, 521);
			this.panelHistory.TabIndex = 0;
			// 
			// dataGridViewRecords
			// 
			this.dataGridViewRecords.AllowUserToAddRows = false;
			this.dataGridViewRecords.AllowUserToDeleteRows = false;
			this.dataGridViewRecords.AllowUserToResizeRows = false;
			this.dataGridViewRecords.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewRecords.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewRecords.Location = new System.Drawing.Point(10, 10);
			this.dataGridViewRecords.MultiSelect = false;
			this.dataGridViewRecords.Name = "dataGridViewRecords";
			this.dataGridViewRecords.ReadOnly = true;
			this.dataGridViewRecords.RowHeadersVisible = false;
			this.dataGridViewRecords.RowHeadersWidth = 62;
			this.dataGridViewRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewRecords.Size = new System.Drawing.Size(966, 501);
			this.dataGridViewRecords.TabIndex = 0;
			this.dataGridViewRecords.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewRecords_CellDoubleClick);
			// 
			// panelHistoryButtons
			// 
			this.panelHistoryButtons.Controls.Add(this.btnRefreshHistory);
			this.panelHistoryButtons.Controls.Add(this.btnEditRecord);
			this.panelHistoryButtons.Controls.Add(this.btnDeleteRecord);
			this.panelHistoryButtons.Controls.Add(this.btnExportHistory);
			this.panelHistoryButtons.Controls.Add(this.btnClose);
			this.panelHistoryButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelHistoryButtons.Location = new System.Drawing.Point(3, 524);
			this.panelHistoryButtons.Name = "panelHistoryButtons";
			this.panelHistoryButtons.Size = new System.Drawing.Size(986, 80);
			this.panelHistoryButtons.TabIndex = 1;
			// 
			// btnRefreshHistory
			// 
			this.btnRefreshHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefreshHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefreshHistory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnRefreshHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnRefreshHistory.Location = new System.Drawing.Point(50, 20);
			this.btnRefreshHistory.Name = "btnRefreshHistory";
			this.btnRefreshHistory.Size = new System.Drawing.Size(160, 40);
			this.btnRefreshHistory.TabIndex = 0;
			this.btnRefreshHistory.Text = "刷  新";
			this.btnRefreshHistory.UseVisualStyleBackColor = true;
			this.btnRefreshHistory.Click += new System.EventHandler(this.BtnRefreshHistory_Click);
			// 
			// btnEditRecord
			// 
			this.btnEditRecord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEditRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEditRecord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnEditRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEditRecord.Location = new System.Drawing.Point(230, 20);
			this.btnEditRecord.Name = "btnEditRecord";
			this.btnEditRecord.Size = new System.Drawing.Size(160, 40);
			this.btnEditRecord.TabIndex = 1;
			this.btnEditRecord.Text = "编  辑";
			this.btnEditRecord.UseVisualStyleBackColor = true;
			this.btnEditRecord.Click += new System.EventHandler(this.BtnEditRecord_Click);
			// 
			// btnDeleteRecord
			// 
			this.btnDeleteRecord.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDeleteRecord.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnDeleteRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDeleteRecord.Location = new System.Drawing.Point(410, 20);
			this.btnDeleteRecord.Name = "btnDeleteRecord";
			this.btnDeleteRecord.Size = new System.Drawing.Size(160, 40);
			this.btnDeleteRecord.TabIndex = 2;
			this.btnDeleteRecord.Text = "删  除";
			this.btnDeleteRecord.UseVisualStyleBackColor = true;
			this.btnDeleteRecord.Click += new System.EventHandler(this.BtnDeleteRecord_Click);
			// 
			// btnExportHistory
			// 
			this.btnExportHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExportHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportHistory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnExportHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExportHistory.Location = new System.Drawing.Point(590, 20);
			this.btnExportHistory.Name = "btnExportHistory";
			this.btnExportHistory.Size = new System.Drawing.Size(160, 40);
			this.btnExportHistory.TabIndex = 3;
			this.btnExportHistory.Text = "导  出";
			this.btnExportHistory.UseVisualStyleBackColor = true;
			this.btnExportHistory.Click += new System.EventHandler(this.BtnExportHistory_Click);
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(770, 20);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(160, 40);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "关  闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// RecordAddForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1000, 700);
			this.Controls.Add(this.tabControlMain);
			this.Controls.Add(this.panelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "RecordAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "接种记录登记";
			this.Load += new System.EventHandler(this.RecordAddForm_Load);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabPageRegistration.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.groupBoxBasicInfo.ResumeLayout(false);
			this.tableLayoutPanelBasic.ResumeLayout(false);
			this.tableLayoutPanelBasic.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
			this.groupBoxVaccinationInfo.ResumeLayout(false);
			this.tableLayoutPanelVaccination.ResumeLayout(false);
			this.tableLayoutPanelVaccination.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.tabPageHistory.ResumeLayout(false);
			this.panelHistory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
			this.panelHistoryButtons.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageRegistration;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBasic;
        private System.Windows.Forms.Label labelAppointmentSearch;
        private System.Windows.Forms.TextBox txtAppointmentSearch;
        private System.Windows.Forms.Button btnSearchAppointment;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.GroupBox groupBoxVaccinationInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelVaccination;
        private System.Windows.Forms.Label labelVaccinationTime;
        private System.Windows.Forms.DateTimePicker dateTimeVaccination;
        private System.Windows.Forms.Label labelVaccineSite;
        private System.Windows.Forms.ComboBox comboVaccineSite;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboDoctor;
        private System.Windows.Forms.Label labelBatchNo;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label labelReaction;
        private System.Windows.Forms.ComboBox comboReaction;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.Label labelTemperatureUnit;
        private System.Windows.Forms.Label labelBloodPressure;
        private System.Windows.Forms.TextBox txtBloodPressure;
        private System.Windows.Forms.Label labelBPUnit;
        private System.Windows.Forms.Label labelHealthStatus;
        private System.Windows.Forms.ComboBox comboHealthStatus;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnSaveDraft;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.DataGridView dataGridViewRecords;
        private System.Windows.Forms.Panel panelHistoryButtons;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.Button btnEditRecord;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.Button btnClose;
    }
}