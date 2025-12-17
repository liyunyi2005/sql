namespace CommunityHospital
{
    partial class ResidentQueryForm
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
			this.panelCondition = new System.Windows.Forms.Panel();
			this.groupBoxCondition = new System.Windows.Forms.GroupBox();
			this.tableLayoutPanelCondition = new System.Windows.Forms.TableLayoutPanel();
			this.labelName = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.labelIDCard = new System.Windows.Forms.Label();
			this.txtIDCard = new System.Windows.Forms.TextBox();
			this.labelGender = new System.Windows.Forms.Label();
			this.comboGender = new System.Windows.Forms.ComboBox();
			this.labelAgeRange = new System.Windows.Forms.Label();
			this.comboAgeRange = new System.Windows.Forms.ComboBox();
			this.labelAllergy = new System.Windows.Forms.Label();
			this.comboAllergy = new System.Windows.Forms.ComboBox();
			this.labelPhone = new System.Windows.Forms.Label();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.labelArchiveDate = new System.Windows.Forms.Label();
			this.dateTimeArchiveStart = new System.Windows.Forms.DateTimePicker();
			this.labelTo = new System.Windows.Forms.Label();
			this.dateTimeArchiveEnd = new System.Windows.Forms.DateTimePicker();
			this.labelCommunity = new System.Windows.Forms.Label();
			this.comboCommunity = new System.Windows.Forms.ComboBox();
			this.panelButtons = new System.Windows.Forms.Panel();
			this.btnQuery = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnExport = new System.Windows.Forms.Button();
			this.panelGrid = new System.Windows.Forms.Panel();
			this.dataGridViewResidents = new System.Windows.Forms.DataGridView();
			this.panelBottom = new System.Windows.Forms.Panel();
			this.lblTotalCount = new System.Windows.Forms.Label();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnDetail = new System.Windows.Forms.Button();
			this.panelTitle.SuspendLayout();
			this.panelCondition.SuspendLayout();
			this.groupBoxCondition.SuspendLayout();
			this.tableLayoutPanelCondition.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.panelGrid.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResidents)).BeginInit();
			this.panelBottom.SuspendLayout();
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
			this.labelTitle.Size = new System.Drawing.Size(206, 31);
			this.labelTitle.TabIndex = 0;
			this.labelTitle.Text = "居民健康档案查询";
			// 
			// panelCondition
			// 
			this.panelCondition.Controls.Add(this.groupBoxCondition);
			this.panelCondition.Controls.Add(this.panelButtons);
			this.panelCondition.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelCondition.Location = new System.Drawing.Point(0, 60);
			this.panelCondition.Name = "panelCondition";
			this.panelCondition.Padding = new System.Windows.Forms.Padding(10, 10, 10, 10);
			this.panelCondition.Size = new System.Drawing.Size(1000, 180);
			this.panelCondition.TabIndex = 1;
			// 
			// groupBoxCondition
			// 
			this.groupBoxCondition.Controls.Add(this.tableLayoutPanelCondition);
			this.groupBoxCondition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBoxCondition.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBoxCondition.Location = new System.Drawing.Point(10, 10);
			this.groupBoxCondition.Name = "groupBoxCondition";
			this.groupBoxCondition.Size = new System.Drawing.Size(780, 160);
			this.groupBoxCondition.TabIndex = 0;
			this.groupBoxCondition.TabStop = false;
			this.groupBoxCondition.Text = "查询条件";
			// 
			// tableLayoutPanelCondition
			// 
			this.tableLayoutPanelCondition.ColumnCount = 6;
			this.tableLayoutPanelCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanelCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanelCondition.Controls.Add(this.labelName, 0, 0);
			this.tableLayoutPanelCondition.Controls.Add(this.txtName, 1, 0);
			this.tableLayoutPanelCondition.Controls.Add(this.labelIDCard, 2, 0);
			this.tableLayoutPanelCondition.Controls.Add(this.txtIDCard, 3, 0);
			this.tableLayoutPanelCondition.Controls.Add(this.labelGender, 4, 0);
			this.tableLayoutPanelCondition.Controls.Add(this.comboGender, 5, 0);
			this.tableLayoutPanelCondition.Controls.Add(this.labelAgeRange, 0, 1);
			this.tableLayoutPanelCondition.Controls.Add(this.comboAgeRange, 1, 1);
			this.tableLayoutPanelCondition.Controls.Add(this.labelAllergy, 2, 1);
			this.tableLayoutPanelCondition.Controls.Add(this.comboAllergy, 3, 1);
			this.tableLayoutPanelCondition.Controls.Add(this.labelPhone, 4, 1);
			this.tableLayoutPanelCondition.Controls.Add(this.txtPhone, 5, 1);
			this.tableLayoutPanelCondition.Controls.Add(this.labelArchiveDate, 0, 2);
			this.tableLayoutPanelCondition.Controls.Add(this.dateTimeArchiveStart, 1, 2);
			this.tableLayoutPanelCondition.Controls.Add(this.labelTo, 2, 2);
			this.tableLayoutPanelCondition.Controls.Add(this.dateTimeArchiveEnd, 3, 2);
			this.tableLayoutPanelCondition.Controls.Add(this.labelCommunity, 4, 2);
			this.tableLayoutPanelCondition.Controls.Add(this.comboCommunity, 5, 2);
			this.tableLayoutPanelCondition.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanelCondition.Location = new System.Drawing.Point(3, 22);
			this.tableLayoutPanelCondition.Name = "tableLayoutPanelCondition";
			this.tableLayoutPanelCondition.RowCount = 3;
			this.tableLayoutPanelCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutPanelCondition.Size = new System.Drawing.Size(774, 135);
			this.tableLayoutPanelCondition.TabIndex = 0;
			// 
			// labelName
			// 
			this.labelName.AutoSize = true;
			this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelName.Location = new System.Drawing.Point(3, 0);
			this.labelName.Name = "labelName";
			this.labelName.Size = new System.Drawing.Size(110, 45);
			this.labelName.TabIndex = 0;
			this.labelName.Text = "居民姓名：";
			this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtName
			// 
			this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtName.Location = new System.Drawing.Point(119, 5);
			this.txtName.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(148, 26);
			this.txtName.TabIndex = 1;
			// 
			// labelIDCard
			// 
			this.labelIDCard.AutoSize = true;
			this.labelIDCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelIDCard.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelIDCard.Location = new System.Drawing.Point(273, 0);
			this.labelIDCard.Name = "labelIDCard";
			this.labelIDCard.Size = new System.Drawing.Size(110, 45);
			this.labelIDCard.TabIndex = 2;
			this.labelIDCard.Text = "身份证号：";
			this.labelIDCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIDCard
			// 
			this.txtIDCard.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtIDCard.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtIDCard.Location = new System.Drawing.Point(389, 5);
			this.txtIDCard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtIDCard.Name = "txtIDCard";
			this.txtIDCard.Size = new System.Drawing.Size(148, 26);
			this.txtIDCard.TabIndex = 3;
			// 
			// labelGender
			// 
			this.labelGender.AutoSize = true;
			this.labelGender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelGender.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelGender.Location = new System.Drawing.Point(543, 0);
			this.labelGender.Name = "labelGender";
			this.labelGender.Size = new System.Drawing.Size(110, 45);
			this.labelGender.TabIndex = 4;
			this.labelGender.Text = "性别：";
			this.labelGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboGender
			// 
			this.comboGender.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboGender.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboGender.FormattingEnabled = true;
			this.comboGender.Items.AddRange(new object[] {
            "全部",
            "男",
            "女"});
			this.comboGender.Location = new System.Drawing.Point(659, 5);
			this.comboGender.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboGender.Name = "comboGender";
			this.comboGender.Size = new System.Drawing.Size(112, 28);
			this.comboGender.TabIndex = 5;
			// 
			// labelAgeRange
			// 
			this.labelAgeRange.AutoSize = true;
			this.labelAgeRange.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAgeRange.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelAgeRange.Location = new System.Drawing.Point(3, 45);
			this.labelAgeRange.Name = "labelAgeRange";
			this.labelAgeRange.Size = new System.Drawing.Size(110, 45);
			this.labelAgeRange.TabIndex = 6;
			this.labelAgeRange.Text = "年龄段：";
			this.labelAgeRange.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboAgeRange
			// 
			this.comboAgeRange.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboAgeRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAgeRange.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboAgeRange.FormattingEnabled = true;
			this.comboAgeRange.Items.AddRange(new object[] {
            "全部",
            "0-6岁",
            "7-17岁",
            "18-59岁",
            "60岁及以上"});
			this.comboAgeRange.Location = new System.Drawing.Point(119, 50);
			this.comboAgeRange.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboAgeRange.Name = "comboAgeRange";
			this.comboAgeRange.Size = new System.Drawing.Size(148, 28);
			this.comboAgeRange.TabIndex = 7;
			// 
			// labelAllergy
			// 
			this.labelAllergy.AutoSize = true;
			this.labelAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelAllergy.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelAllergy.Location = new System.Drawing.Point(273, 45);
			this.labelAllergy.Name = "labelAllergy";
			this.labelAllergy.Size = new System.Drawing.Size(110, 45);
			this.labelAllergy.TabIndex = 8;
			this.labelAllergy.Text = "过敏史：";
			this.labelAllergy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboAllergy
			// 
			this.comboAllergy.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboAllergy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAllergy.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboAllergy.FormattingEnabled = true;
			this.comboAllergy.Items.AddRange(new object[] {
            "全部",
            "有过敏史",
            "无过敏史"});
			this.comboAllergy.Location = new System.Drawing.Point(389, 50);
			this.comboAllergy.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboAllergy.Name = "comboAllergy";
			this.comboAllergy.Size = new System.Drawing.Size(148, 28);
			this.comboAllergy.TabIndex = 9;
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelPhone.Location = new System.Drawing.Point(543, 45);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(110, 45);
			this.labelPhone.TabIndex = 10;
			this.labelPhone.Text = "联系电话：";
			this.labelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPhone
			// 
			this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPhone.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtPhone.Location = new System.Drawing.Point(659, 50);
			this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(112, 26);
			this.txtPhone.TabIndex = 11;
			// 
			// labelArchiveDate
			// 
			this.labelArchiveDate.AutoSize = true;
			this.labelArchiveDate.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelArchiveDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelArchiveDate.Location = new System.Drawing.Point(3, 90);
			this.labelArchiveDate.Name = "labelArchiveDate";
			this.labelArchiveDate.Size = new System.Drawing.Size(110, 45);
			this.labelArchiveDate.TabIndex = 12;
			this.labelArchiveDate.Text = "建档日期：";
			this.labelArchiveDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// dateTimeArchiveStart
			// 
			this.dateTimeArchiveStart.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimeArchiveStart.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dateTimeArchiveStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeArchiveStart.Location = new System.Drawing.Point(119, 95);
			this.dateTimeArchiveStart.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateTimeArchiveStart.Name = "dateTimeArchiveStart";
			this.dateTimeArchiveStart.Size = new System.Drawing.Size(148, 26);
			this.dateTimeArchiveStart.TabIndex = 13;
			// 
			// labelTo
			// 
			this.labelTo.AutoSize = true;
			this.labelTo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelTo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelTo.Location = new System.Drawing.Point(273, 90);
			this.labelTo.Name = "labelTo";
			this.labelTo.Size = new System.Drawing.Size(110, 45);
			this.labelTo.TabIndex = 14;
			this.labelTo.Text = "至";
			this.labelTo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dateTimeArchiveEnd
			// 
			this.dateTimeArchiveEnd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dateTimeArchiveEnd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dateTimeArchiveEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimeArchiveEnd.Location = new System.Drawing.Point(389, 95);
			this.dateTimeArchiveEnd.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.dateTimeArchiveEnd.Name = "dateTimeArchiveEnd";
			this.dateTimeArchiveEnd.Size = new System.Drawing.Size(148, 26);
			this.dateTimeArchiveEnd.TabIndex = 15;
			// 
			// labelCommunity
			// 
			this.labelCommunity.AutoSize = true;
			this.labelCommunity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelCommunity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelCommunity.Location = new System.Drawing.Point(543, 90);
			this.labelCommunity.Name = "labelCommunity";
			this.labelCommunity.Size = new System.Drawing.Size(110, 45);
			this.labelCommunity.TabIndex = 16;
			this.labelCommunity.Text = "所属社区：";
			this.labelCommunity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// comboCommunity
			// 
			this.comboCommunity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.comboCommunity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboCommunity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.comboCommunity.FormattingEnabled = true;
			this.comboCommunity.Items.AddRange(new object[] {
            "全部",
            "朝阳社区",
            "海淀社区",
            "东城社区",
            "西城社区",
            "丰台社区",
            "石景山社区",
            "通州社区"});
			this.comboCommunity.Location = new System.Drawing.Point(659, 95);
			this.comboCommunity.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.comboCommunity.Name = "comboCommunity";
			this.comboCommunity.Size = new System.Drawing.Size(112, 28);
			this.comboCommunity.TabIndex = 17;
			// 
			// panelButtons
			// 
			this.panelButtons.Controls.Add(this.btnQuery);
			this.panelButtons.Controls.Add(this.btnReset);
			this.panelButtons.Controls.Add(this.btnExport);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelButtons.Location = new System.Drawing.Point(790, 10);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(200, 160);
			this.panelButtons.TabIndex = 1;
			// 
			// btnQuery
			// 
			this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.btnQuery.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnQuery.FlatAppearance.BorderSize = 0;
			this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnQuery.ForeColor = System.Drawing.Color.White;
			this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnQuery.Location = new System.Drawing.Point(20, 20);
			this.btnQuery.Name = "btnQuery";
			this.btnQuery.Size = new System.Drawing.Size(160, 40);
			this.btnQuery.TabIndex = 0;
			this.btnQuery.Text = "查  询";
			this.btnQuery.UseVisualStyleBackColor = false;
			this.btnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
			// 
			// btnReset
			// 
			this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnReset.Location = new System.Drawing.Point(20, 70);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(160, 40);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "重  置";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
			// 
			// btnExport
			// 
			this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExport.Location = new System.Drawing.Point(20, 120);
			this.btnExport.Name = "btnExport";
			this.btnExport.Size = new System.Drawing.Size(160, 40);
			this.btnExport.TabIndex = 2;
			this.btnExport.Text = "导  出";
			this.btnExport.UseVisualStyleBackColor = true;
			this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
			// 
			// panelGrid
			// 
			this.panelGrid.Controls.Add(this.dataGridViewResidents);
			this.panelGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelGrid.Location = new System.Drawing.Point(0, 240);
			this.panelGrid.Name = "panelGrid";
			this.panelGrid.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
			this.panelGrid.Size = new System.Drawing.Size(1000, 320);
			this.panelGrid.TabIndex = 2;
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
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dataGridViewResidents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dataGridViewResidents.ColumnHeadersHeight = 40;
			this.dataGridViewResidents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
			this.dataGridViewResidents.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewResidents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			this.dataGridViewResidents.Location = new System.Drawing.Point(10, 0);
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
			this.dataGridViewResidents.Size = new System.Drawing.Size(980, 310);
			this.dataGridViewResidents.TabIndex = 0;
			this.dataGridViewResidents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewResidents_CellDoubleClick);
			this.dataGridViewResidents.SelectionChanged += new System.EventHandler(this.DataGridViewResidents_SelectionChanged);
			// 
			// panelBottom
			// 
			this.panelBottom.Controls.Add(this.lblTotalCount);
			this.panelBottom.Controls.Add(this.btnClose);
			this.panelBottom.Controls.Add(this.btnEdit);
			this.panelBottom.Controls.Add(this.btnDelete);
			this.panelBottom.Controls.Add(this.btnDetail);
			this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new System.Drawing.Point(0, 560);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(1000, 60);
			this.panelBottom.TabIndex = 3;
			// 
			// lblTotalCount
			// 
			this.lblTotalCount.AutoSize = true;
			this.lblTotalCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblTotalCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
			this.lblTotalCount.Location = new System.Drawing.Point(20, 20);
			this.lblTotalCount.Name = "lblTotalCount";
			this.lblTotalCount.Size = new System.Drawing.Size(88, 21);
			this.lblTotalCount.TabIndex = 4;
			this.lblTotalCount.Text = "总计：0 条";
			// 
			// btnClose
			// 
			this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnClose.Location = new System.Drawing.Point(820, 10);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(160, 40);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "关  闭";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEdit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(330, 10);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(160, 40);
			this.btnEdit.TabIndex = 2;
			this.btnEdit.Text = "编  辑";
			this.btnEdit.UseVisualStyleBackColor = true;
			this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDelete.Location = new System.Drawing.Point(500, 10);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(160, 40);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "删  除";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
			// 
			// btnDetail
			// 
			this.btnDetail.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDetail.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDetail.Location = new System.Drawing.Point(160, 10);
			this.btnDetail.Name = "btnDetail";
			this.btnDetail.Size = new System.Drawing.Size(160, 40);
			this.btnDetail.TabIndex = 0;
			this.btnDetail.Text = "详  情";
			this.btnDetail.UseVisualStyleBackColor = true;
			this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
			// 
			// ResidentQueryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(1000, 620);
			this.Controls.Add(this.panelGrid);
			this.Controls.Add(this.panelBottom);
			this.Controls.Add(this.panelCondition);
			this.Controls.Add(this.panelTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ResidentQueryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "居民档案查询";
			this.Load += new System.EventHandler(this.ResidentQueryForm_Load);
			this.panelTitle.ResumeLayout(false);
			this.panelTitle.PerformLayout();
			this.panelCondition.ResumeLayout(false);
			this.groupBoxCondition.ResumeLayout(false);
			this.tableLayoutPanelCondition.ResumeLayout(false);
			this.tableLayoutPanelCondition.PerformLayout();
			this.panelButtons.ResumeLayout(false);
			this.panelGrid.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResidents)).EndInit();
			this.panelBottom.ResumeLayout(false);
			this.panelBottom.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelCondition;
        private System.Windows.Forms.GroupBox groupBoxCondition;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelCondition;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labelIDCard;
        private System.Windows.Forms.TextBox txtIDCard;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboGender;
        private System.Windows.Forms.Label labelAgeRange;
        private System.Windows.Forms.ComboBox comboAgeRange;
        private System.Windows.Forms.Label labelAllergy;
        private System.Windows.Forms.ComboBox comboAllergy;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label labelArchiveDate;
        private System.Windows.Forms.DateTimePicker dateTimeArchiveStart;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.DateTimePicker dateTimeArchiveEnd;
        private System.Windows.Forms.Label labelCommunity;
        private System.Windows.Forms.ComboBox comboCommunity;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel panelGrid;
        private System.Windows.Forms.DataGridView dataGridViewResidents;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Label lblTotalCount;
    }
}