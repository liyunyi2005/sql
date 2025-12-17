namespace CommunityHospital
{
    partial class AppointmentAddForm
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
			this.tabPageNew = new System.Windows.Forms.TabPage();
			this.panelMain = new System.Windows.Forms.Panel();
			this.groupBoxResident = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelResident = new System.Windows.Forms.TableLayoutPanel();
			this.labelResidentSearch = new System.Windows.Forms.Label();
			this.txtResidentSearch = new System.Windows.Forms.TextBox();
			this.btnSearchResident = new System.Windows.Forms.Button();
			this.btnNewResident = new System.Windows.Forms.Button();
			this.dataGridViewResidents = new System.Windows.Forms.DataGridView();
			this.groupBoxAppointment = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelAppointment = new System.Windows.Forms.TableLayoutPanel();
			this.labelVaccineName = new System.Windows.Forms.Label();
			this.comboVaccineName = new System.Windows.Forms.ComboBox();
			this.labelVaccineType = new System.Windows.Forms.Label();
			this.comboVaccineType = new System.Windows.Forms.ComboBox();
			this.labelAppointmentDate = new System.Windows.Forms.Label();
			this.dateTimeAppointment = new System.Windows.Forms.DateTimePicker();
			this.labelTimeSlot = new System.Windows.Forms.Label();
			this.comboTimeSlot = new System.Windows.Forms.ComboBox();
			this.labelDoseNumber = new System.Windows.Forms.Label();
			this.comboDoseNumber = new System.Windows.Forms.ComboBox();
			this.labelHospital = new System.Windows.Forms.Label();
			this.comboHospital = new System.Windows.Forms.ComboBox();
			this.labelClinic = new System.Windows.Forms.Label();
			this.comboClinic = new System.Windows.Forms.ComboBox();
			this.labelDoctor = new System.Windows.Forms.Label();
			this.comboDoctor = new System.Windows.Forms.ComboBox();
			this.labelRemark = new System.Windows.Forms.Label();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnPrintVoucher = new System.Windows.Forms.Button();
			this.tabPageHistory = new System.Windows.Forms.TabPage();
			this.panelHistory = new System.Windows.Forms.Panel();
			this.dataGridViewAppointments = new System.Windows.Forms.DataGridView();
			this.panelHistoryButtons = new System.Windows.Forms.Panel();
			this.btnRefreshHistory = new System.Windows.Forms.Button();
			this.btnCancelAppointment = new System.Windows.Forms.Button();
			this.btnExportHistory = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.panelTitle.SuspendLayout();
			this.tabControlMain.SuspendLayout();
			this.tabPageNew.SuspendLayout();
			this.panelMain.SuspendLayout();
			this.groupBoxResident.SuspendLayout();
			this.tableLayoutPanelResident.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResidents)).BeginInit();
			this.groupBoxAppointment.SuspendLayout();
			this.tableLayoutPanelAppointment.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.tabPageHistory.SuspendLayout();
			this.panelHistory.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).BeginInit();
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
			this.labelTitle.Text = "疫苗接种预约";
			// 
			// tabControlMain
			// 
			this.tabControlMain.Controls.Add(this.tabPageNew);
			this.tabControlMain.Controls.Add(this.tabPageHistory);
			this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabControlMain.Location = new System.Drawing.Point(0, 60);
			this.tabControlMain.Name = "tabControlMain";
			this.tabControlMain.SelectedIndex = 0;
			this.tabControlMain.Size = new System.Drawing.Size(1000, 640);
			this.tabControlMain.TabIndex = 1;
			// 
			// tabPageNew
			// 
			this.tabPageNew.Controls.Add(this.panelMain);
			this.tabPageNew.Location = new System.Drawing.Point(4, 29);
			this.tabPageNew.Name = "tabPageNew";
			this.tabPageNew.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
			this.tabPageNew.Size = new System.Drawing.Size(992, 607);
			this.tabPageNew.TabIndex = 0;
			this.tabPageNew.Text = "新建预约";
			this.tabPageNew.UseVisualStyleBackColor = true;
			// 
			// panelMain
			// 
			this.panelMain.Controls.Add(this.groupBoxResident);
			this.panelMain.Controls.Add(this.groupBoxAppointment);
			this.panelMain.Controls.Add(this.panelButtons);
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(3, 3);
			this.panelMain.Name = "panelMain";
			this.panelMain.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.panelMain.Size = new System.Drawing.Size(986, 601);
			this.panelMain.TabIndex = 0;
			// 
			// groupBoxResident
			// 
			this.groupBoxResident.Controls.Add(this.tableLayoutPanelResident);
			this.groupBoxResident.Controls.Add(this.dataGridViewResidents);
			this.groupBoxResident.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxResident.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBoxResident.Location = new System.Drawing.Point(10, 270);
			this.groupBoxResident.Name = "groupBoxResident";
			this.groupBoxResident.Size = new System.Drawing.Size(966, 250);
			this.groupBoxResident.TabIndex = 0;
			this.groupBoxResident.TabStop = false;
			this.groupBoxResident.Text = "选择居民";
			// 
			// tableLayoutPanelResident
			// 
			this.tableLayoutPanelResident.ColumnCount = 4;
			this.tableLayoutPanelResident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelResident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
			this.tableLayoutPanelResident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelResident.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutPanelResident.Controls.Add(this.labelResidentSearch, 0, 0);
			this.tableLayoutPanelResident.Controls.Add(this.txtResidentSearch, 1, 0);
			this.tableLayoutPanelResident.Controls.Add(this.btnSearchResident, 2, 0);
			this.tableLayoutPanelResident.Controls.Add(this.btnNewResident, 3, 0);
			this.tableLayoutPanelResident.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanelResident.Location = new System.Drawing.Point(3, 22);
			this.tableLayoutPanelResident.Name = "tableLayoutPanelResident";
			this.tableLayoutPanelResident.RowCount = 1;
			this.tableLayoutPanelResident.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanelResident.Size = new System.Drawing.Size(960, 50);
			this.tableLayoutPanelResident.TabIndex = 1;
			// 
			// labelResidentSearch
			// 
			this.labelResidentSearch.AutoSize = true;
			this.labelResidentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelResidentSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelResidentSearch.Location = new System.Drawing.Point(3, 0);
			this.labelResidentSearch.Name = "labelResidentSearch";
			this.labelResidentSearch.Size = new System.Drawing.Size(138, 50);
			this.labelResidentSearch.TabIndex = 0;
			this.labelResidentSearch.Text = "居民搜索：";
			this.labelResidentSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtResidentSearch
			// 
			this.txtResidentSearch.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtResidentSearch.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtResidentSearch.Location = new System.Drawing.Point(147, 10);
			this.txtResidentSearch.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.txtResidentSearch.Name = "txtResidentSearch";
			this.txtResidentSearch.Size = new System.Drawing.Size(378, 26);
			this.txtResidentSearch.TabIndex = 1;
			this.txtResidentSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtResidentSearch_KeyPress);
			// 
			// btnSearchResident
			// 
			this.btnSearchResident.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearchResident.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSearchResident.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSearchResident.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSearchResident.Location = new System.Drawing.Point(531, 10);
			this.btnSearchResident.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnSearchResident.Name = "btnSearchResident";
			this.btnSearchResident.Size = new System.Drawing.Size(186, 30);
			this.btnSearchResident.TabIndex = 2;
			this.btnSearchResident.Text = "搜索居民";
			this.btnSearchResident.UseVisualStyleBackColor = true;
			this.btnSearchResident.Click += new System.EventHandler(this.BtnSearchResident_Click);
			// 
			// btnNewResident
			// 
			this.btnNewResident.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNewResident.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnNewResident.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnNewResident.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNewResident.Location = new System.Drawing.Point(723, 10);
			this.btnNewResident.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnNewResident.Name = "btnNewResident";
			this.btnNewResident.Size = new System.Drawing.Size(234, 30);
			this.btnNewResident.TabIndex = 3;
			this.btnNewResident.Text = "新建居民档案";
			this.btnNewResident.UseVisualStyleBackColor = true;
			this.btnNewResident.Click += new System.EventHandler(this.BtnNewResident_Click);
			// 
			// dataGridViewResidents
			// 
			this.dataGridViewResidents.AllowUserToAddRows = false;
			this.dataGridViewResidents.AllowUserToDeleteRows = false;
			this.dataGridViewResidents.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
			this.dataGridViewResidents.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dataGridViewResidents.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewResidents.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewResidents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewResidents.ColumnHeadersHeight = 40;
			this.dataGridViewResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewResidents.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridViewResidents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.dataGridViewResidents.Location = new System.Drawing.Point(3, 78);
			this.dataGridViewResidents.MultiSelect = false;
			this.dataGridViewResidents.Name = "dataGridViewResidents";
			this.dataGridViewResidents.ReadOnly = true;
			this.dataGridViewResidents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.dataGridViewResidents.RowHeadersVisible = false;
			this.dataGridViewResidents.RowHeadersWidth = 62;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dataGridViewResidents.RowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dataGridViewResidents.RowTemplate.Height = 35;
			this.dataGridViewResidents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewResidents.Size = new System.Drawing.Size(960, 169);
			this.dataGridViewResidents.TabIndex = 0;
			this.dataGridViewResidents.SelectionChanged += new System.EventHandler(this.DataGridViewResidents_SelectionChanged);
			// 
			// groupBoxAppointment
			// 
			this.groupBoxAppointment.Controls.Add(this.tableLayoutPanelAppointment);
			this.groupBoxAppointment.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBoxAppointment.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBoxAppointment.Location = new System.Drawing.Point(10, 10);
			this.groupBoxAppointment.Name = "groupBoxAppointment";
			this.groupBoxAppointment.Size = new System.Drawing.Size(966, 260);
			this.groupBoxAppointment.TabIndex = 1;
			this.groupBoxAppointment.TabStop = false;
			this.groupBoxAppointment.Text = "预约信息";
			// 
			// tableLayoutPanelAppointment
			// 
			this.tableLayoutPanelAppointment.ColumnCount = 4;
			this.tableLayoutPanelAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutPanelAppointment.Controls.Add(this.labelVaccineName, 0, 0);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboVaccineName, 1, 0);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelVaccineType, 2, 0);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboVaccineType, 3, 0);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelAppointmentDate, 0, 1);
			this.tableLayoutPanelAppointment.Controls.Add(this.dateTimeAppointment, 1, 1);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelTimeSlot, 2, 1);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboTimeSlot, 3, 1);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelDoseNumber, 0, 2);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboDoseNumber, 1, 2);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelHospital, 2, 2);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboHospital, 3, 2);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelClinic, 0, 3);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboClinic, 1, 3);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelDoctor, 2, 3);
			this.tableLayoutPanelAppointment.Controls.Add(this.comboDoctor, 3, 3);
			this.tableLayoutPanelAppointment.Controls.Add(this.labelRemark, 0, 4);
			this.tableLayoutPanelAppointment.Controls.Add(this.txtRemark, 1, 4);
			this.tableLayoutPanelAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelAppointment.Location = new System.Drawing.Point(3, 22);
			this.tableLayoutPanelAppointment.Name = "tableLayoutPanelAppointment";
			this.tableLayoutPanelAppointment.RowCount = 5;
			this.tableLayoutPanelAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelAppointment.Size = new System.Drawing.Size(960, 235);
			this.tableLayoutPanelAppointment.TabIndex = 0;
			// 
			// labelVaccineName
			// 
			this.labelVaccineName.AutoSize = true;
			this.labelVaccineName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVaccineName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelVaccineName.Location = new System.Drawing.Point(3, 0);
			this.labelVaccineName.Name = "labelVaccineName";
			this.labelVaccineName.Size = new System.Drawing.Size(186, 47);
			this.labelVaccineName.TabIndex = 0;
			this.labelVaccineName.Text = "疫苗名称：";
			this.labelVaccineName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboVaccineName
			// 
			this.comboVaccineName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboVaccineName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVaccineName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboVaccineName.FormattingEnabled = true;
			this.comboVaccineName.Items.AddRange(new object[] {
            "新冠疫苗（灭活）",
            "新冠疫苗（重组）",
            "流感疫苗",
            "乙肝疫苗",
            "百白破疫苗",
            "麻疹疫苗",
            "水痘疫苗",
            "肺炎疫苗"});
			this.comboVaccineName.Location = new System.Drawing.Point(195, 5);
			this.comboVaccineName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboVaccineName.Name = "comboVaccineName";
			this.comboVaccineName.Size = new System.Drawing.Size(282, 28);
			this.comboVaccineName.TabIndex = 1;
			this.comboVaccineName.SelectedIndexChanged += new System.EventHandler(this.ComboVaccineName_SelectedIndexChanged);
			// 
			// labelVaccineType
			// 
			this.labelVaccineType.AutoSize = true;
			this.labelVaccineType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelVaccineType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelVaccineType.Location = new System.Drawing.Point(483, 0);
			this.labelVaccineType.Name = "labelVaccineType";
			this.labelVaccineType.Size = new System.Drawing.Size(186, 47);
			this.labelVaccineType.TabIndex = 2;
			this.labelVaccineType.Text = "疫苗类型：";
			this.labelVaccineType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboVaccineType
			// 
			this.comboVaccineType.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboVaccineType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboVaccineType.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboVaccineType.FormattingEnabled = true;
			this.comboVaccineType.Items.AddRange(new object[] {
            "第一针",
            "第二针",
            "第三针",
            "加强针",
            "年度接种"});
			this.comboVaccineType.Location = new System.Drawing.Point(675, 5);
			this.comboVaccineType.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboVaccineType.Name = "comboVaccineType";
			this.comboVaccineType.Size = new System.Drawing.Size(282, 28);
			this.comboVaccineType.TabIndex = 3;
			// 
			// labelAppointmentDate
			// 
			this.labelAppointmentDate.AutoSize = true;
			this.labelAppointmentDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAppointmentDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelAppointmentDate.Location = new System.Drawing.Point(3, 47);
			this.labelAppointmentDate.Name = "labelAppointmentDate";
			this.labelAppointmentDate.Size = new System.Drawing.Size(186, 47);
			this.labelAppointmentDate.TabIndex = 4;
			this.labelAppointmentDate.Text = "预约日期：";
			this.labelAppointmentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimeAppointment
			// 
			this.dateTimeAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimeAppointment.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dateTimeAppointment.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeAppointment.Location = new System.Drawing.Point(195, 52);
			this.dateTimeAppointment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateTimeAppointment.MinDate = new System.DateTime(2024, 12, 24, 0, 0, 0, 0);
			this.dateTimeAppointment.Name = "dateTimeAppointment";
			this.dateTimeAppointment.Size = new System.Drawing.Size(282, 26);
			this.dateTimeAppointment.TabIndex = 5;
			this.dateTimeAppointment.Value = new System.DateTime(2024, 12, 24, 0, 0, 0, 0);
			// 
			// labelTimeSlot
			// 
			this.labelTimeSlot.AutoSize = true;
			this.labelTimeSlot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTimeSlot.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelTimeSlot.Location = new System.Drawing.Point(483, 47);
			this.labelTimeSlot.Name = "labelTimeSlot";
			this.labelTimeSlot.Size = new System.Drawing.Size(186, 47);
			this.labelTimeSlot.TabIndex = 6;
			this.labelTimeSlot.Text = "预约时段：";
			this.labelTimeSlot.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboTimeSlot
			// 
			this.comboTimeSlot.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboTimeSlot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboTimeSlot.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboTimeSlot.FormattingEnabled = true;
			this.comboTimeSlot.Items.AddRange(new object[] {
            "08:00-09:00",
            "09:00-10:00",
            "10:00-11:00",
            "14:00-15:00",
            "15:00-16:00",
            "16:00-17:00"});
			this.comboTimeSlot.Location = new System.Drawing.Point(675, 52);
			this.comboTimeSlot.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboTimeSlot.Name = "comboTimeSlot";
			this.comboTimeSlot.Size = new System.Drawing.Size(282, 28);
			this.comboTimeSlot.TabIndex = 7;
			// 
			// labelDoseNumber
			// 
			this.labelDoseNumber.AutoSize = true;
			this.labelDoseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDoseNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelDoseNumber.Location = new System.Drawing.Point(3, 94);
			this.labelDoseNumber.Name = "labelDoseNumber";
			this.labelDoseNumber.Size = new System.Drawing.Size(186, 47);
			this.labelDoseNumber.TabIndex = 8;
			this.labelDoseNumber.Text = "接种剂次：";
			this.labelDoseNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboDoseNumber
			// 
			this.comboDoseNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboDoseNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboDoseNumber.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboDoseNumber.FormattingEnabled = true;
			this.comboDoseNumber.Items.AddRange(new object[] {
            "第1剂",
            "第2剂",
            "第3剂",
            "第4剂",
            "加强针",
            "年度接种"});
			this.comboDoseNumber.Location = new System.Drawing.Point(195, 99);
			this.comboDoseNumber.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboDoseNumber.Name = "comboDoseNumber";
			this.comboDoseNumber.Size = new System.Drawing.Size(282, 28);
			this.comboDoseNumber.TabIndex = 9;
			// 
			// labelHospital
			// 
			this.labelHospital.AutoSize = true;
			this.labelHospital.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHospital.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelHospital.Location = new System.Drawing.Point(483, 94);
			this.labelHospital.Name = "labelHospital";
			this.labelHospital.Size = new System.Drawing.Size(186, 47);
			this.labelHospital.TabIndex = 10;
			this.labelHospital.Text = "接种医院：";
			this.labelHospital.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboHospital
			// 
			this.comboHospital.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboHospital.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboHospital.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboHospital.FormattingEnabled = true;
			this.comboHospital.Items.AddRange(new object[] {
            "社区医院总院",
            "社区医院东区分院",
            "社区医院西区分院",
            "社区卫生服务中心"});
			this.comboHospital.Location = new System.Drawing.Point(675, 99);
			this.comboHospital.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboHospital.Name = "comboHospital";
			this.comboHospital.Size = new System.Drawing.Size(282, 28);
			this.comboHospital.TabIndex = 11;
			// 
			// labelClinic
			// 
			this.labelClinic.AutoSize = true;
			this.labelClinic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelClinic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelClinic.Location = new System.Drawing.Point(3, 141);
			this.labelClinic.Name = "labelClinic";
			this.labelClinic.Size = new System.Drawing.Size(186, 47);
			this.labelClinic.TabIndex = 12;
			this.labelClinic.Text = "接种科室：";
			this.labelClinic.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboClinic
			// 
			this.comboClinic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboClinic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboClinic.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboClinic.FormattingEnabled = true;
			this.comboClinic.Items.AddRange(new object[] {
            "预防接种科",
            "儿科",
            "内科",
            "全科门诊",
            "体检中心"});
			this.comboClinic.Location = new System.Drawing.Point(195, 146);
			this.comboClinic.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboClinic.Name = "comboClinic";
			this.comboClinic.Size = new System.Drawing.Size(282, 28);
			this.comboClinic.TabIndex = 13;
			// 
			// labelDoctor
			// 
			this.labelDoctor.AutoSize = true;
			this.labelDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelDoctor.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelDoctor.Location = new System.Drawing.Point(483, 141);
			this.labelDoctor.Name = "labelDoctor";
			this.labelDoctor.Size = new System.Drawing.Size(186, 47);
			this.labelDoctor.TabIndex = 14;
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
			this.comboDoctor.Location = new System.Drawing.Point(675, 146);
			this.comboDoctor.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboDoctor.Name = "comboDoctor";
			this.comboDoctor.Size = new System.Drawing.Size(282, 28);
			this.comboDoctor.TabIndex = 15;
			// 
			// labelRemark
			// 
			this.labelRemark.AutoSize = true;
			this.labelRemark.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelRemark.Location = new System.Drawing.Point(3, 188);
			this.labelRemark.Name = "labelRemark";
			this.labelRemark.Size = new System.Drawing.Size(186, 47);
			this.labelRemark.TabIndex = 16;
			this.labelRemark.Text = "备   注：";
			this.labelRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtRemark
			// 
			this.tableLayoutPanelAppointment.SetColumnSpan(this.txtRemark, 3);
			this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtRemark.Location = new System.Drawing.Point(195, 193);
			this.txtRemark.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(762, 26);
			this.txtRemark.TabIndex = 17;
			this.txtRemark.Text = "请携带身份证件和健康码";
			// 
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.btnSubmit);
			this.panelButtons.Controls.Add(this.btnReset);
			this.panelButtons.Controls.Add(this.btnPrintVoucher);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(10, 531);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(966, 60);
			this.panelButtons.TabIndex = 2;
			// 
			// btnSubmit
			// 
			this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSubmit.FlatAppearance.BorderSize = 0;
			this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSubmit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSubmit.ForeColor = System.Drawing.Color.White;
			this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSubmit.Location = new System.Drawing.Point(200, 10);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(160, 40);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.Text = "提交预约";
			this.btnSubmit.UseVisualStyleBackColor = false;
			this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
			// 
			// btnReset
			// 
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(380, 10);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(160, 40);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "重  置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// btnPrintVoucher
			// 
			this.btnPrintVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrintVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPrintVoucher.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnPrintVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrintVoucher.Location = new System.Drawing.Point(560, 10);
			this.btnPrintVoucher.Name = "btnPrintVoucher";
			this.btnPrintVoucher.Size = new System.Drawing.Size(160, 40);
			this.btnPrintVoucher.TabIndex = 2;
			this.btnPrintVoucher.Text = "打印凭证";
			this.btnPrintVoucher.UseVisualStyleBackColor = true;
			this.btnPrintVoucher.Click += new System.EventHandler(this.BtnPrintVoucher_Click);
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
			this.tabPageHistory.Text = "预约记录";
			this.tabPageHistory.UseVisualStyleBackColor = true;
			// 
			// panelHistory
			// 
			this.panelHistory.Controls.Add(this.dataGridViewAppointments);
			this.panelHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelHistory.Location = new System.Drawing.Point(3, 3);
			this.panelHistory.Name = "panelHistory";
			this.panelHistory.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.panelHistory.Size = new System.Drawing.Size(986, 521);
			this.panelHistory.TabIndex = 0;
			// 
			// dataGridViewAppointments
			// 
			this.dataGridViewAppointments.AllowUserToAddRows = false;
			this.dataGridViewAppointments.AllowUserToDeleteRows = false;
			this.dataGridViewAppointments.AllowUserToResizeRows = false;
			this.dataGridViewAppointments.BackgroundColor = System.Drawing.Color.White;
			this.dataGridViewAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAppointments.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewAppointments.Location = new System.Drawing.Point(10, 10);
			this.dataGridViewAppointments.MultiSelect = false;
			this.dataGridViewAppointments.Name = "dataGridViewAppointments";
			this.dataGridViewAppointments.ReadOnly = true;
			this.dataGridViewAppointments.RowHeadersVisible = false;
			this.dataGridViewAppointments.RowHeadersWidth = 62;
			this.dataGridViewAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewAppointments.Size = new System.Drawing.Size(966, 501);
			this.dataGridViewAppointments.TabIndex = 0;
			this.dataGridViewAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewAppointments_CellDoubleClick);
			// 
			// panelHistoryButtons
			// 
			this.panelHistoryButtons.Controls.Add(this.btnRefreshHistory);
			this.panelHistoryButtons.Controls.Add(this.btnCancelAppointment);
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
			this.btnRefreshHistory.Location = new System.Drawing.Point(100, 20);
			this.btnRefreshHistory.Name = "btnRefreshHistory";
			this.btnRefreshHistory.Size = new System.Drawing.Size(160, 40);
			this.btnRefreshHistory.TabIndex = 0;
			this.btnRefreshHistory.Text = "刷  新";
			this.btnRefreshHistory.UseVisualStyleBackColor = true;
			this.btnRefreshHistory.Click += new System.EventHandler(this.BtnRefreshHistory_Click);
			// 
			// btnCancelAppointment
			// 
			this.btnCancelAppointment.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancelAppointment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancelAppointment.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnCancelAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnCancelAppointment.Location = new System.Drawing.Point(280, 20);
			this.btnCancelAppointment.Name = "btnCancelAppointment";
			this.btnCancelAppointment.Size = new System.Drawing.Size(160, 40);
			this.btnCancelAppointment.TabIndex = 1;
			this.btnCancelAppointment.Text = "取消预约";
			this.btnCancelAppointment.UseVisualStyleBackColor = true;
			this.btnCancelAppointment.Click += new System.EventHandler(this.BtnCancelAppointment_Click);
			// 
			// btnExportHistory
			// 
			this.btnExportHistory.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExportHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExportHistory.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnExportHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExportHistory.Location = new System.Drawing.Point(460, 20);
			this.btnExportHistory.Name = "btnExportHistory";
			this.btnExportHistory.Size = new System.Drawing.Size(160, 40);
			this.btnExportHistory.TabIndex = 2;
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
			this.btnClose.Location = new System.Drawing.Point(640, 20);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(160, 40);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "关  闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// AppointmentAddForm
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
			this.Name = "AppointmentAddForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "疫苗接种预约";
			this.Load += new System.EventHandler(this.AppointmentAddForm_Load);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.tabControlMain.ResumeLayout(false);
			this.tabPageNew.ResumeLayout(false);
			this.panelMain.ResumeLayout(false);
			this.groupBoxResident.ResumeLayout(false);
			this.tableLayoutPanelResident.ResumeLayout(false);
			this.tableLayoutPanelResident.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResidents)).EndInit();
			this.groupBoxAppointment.ResumeLayout(false);
			this.tableLayoutPanelAppointment.ResumeLayout(false);
			this.tableLayoutPanelAppointment.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.tabPageHistory.ResumeLayout(false);
			this.panelHistory.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAppointments)).EndInit();
			this.panelHistoryButtons.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageNew;
        private System.Windows.Forms.TabPage tabPageHistory;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox groupBoxResident;
        private System.Windows.Forms.DataGridView dataGridViewResidents;
        private System.Windows.Forms.GroupBox groupBoxAppointment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAppointment;
        private System.Windows.Forms.Label labelVaccineName;
        private System.Windows.Forms.ComboBox comboVaccineName;
        private System.Windows.Forms.Label labelVaccineType;
        private System.Windows.Forms.ComboBox comboVaccineType;
        private System.Windows.Forms.Label labelAppointmentDate;
        private System.Windows.Forms.DateTimePicker dateTimeAppointment;
        private System.Windows.Forms.Label labelTimeSlot;
        private System.Windows.Forms.ComboBox comboTimeSlot;
        private System.Windows.Forms.Label labelDoseNumber;
        private System.Windows.Forms.ComboBox comboDoseNumber;
        private System.Windows.Forms.Label labelHospital;
        private System.Windows.Forms.ComboBox comboHospital;
        private System.Windows.Forms.Label labelClinic;
        private System.Windows.Forms.ComboBox comboClinic;
        private System.Windows.Forms.Label labelDoctor;
        private System.Windows.Forms.ComboBox comboDoctor;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrintVoucher;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelResident;
        private System.Windows.Forms.Label labelResidentSearch;
        private System.Windows.Forms.TextBox txtResidentSearch;
        private System.Windows.Forms.Button btnSearchResident;
        private System.Windows.Forms.Button btnNewResident;
        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.DataGridView dataGridViewAppointments;
        private System.Windows.Forms.Panel panelHistoryButtons;
        private System.Windows.Forms.Button btnRefreshHistory;
        private System.Windows.Forms.Button btnCancelAppointment;
        private System.Windows.Forms.Button btnExportHistory;
        private System.Windows.Forms.Button btnClose;
    }
}