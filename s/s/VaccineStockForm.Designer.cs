namespace CommunityHospital
{
    partial class VaccineStockForm
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
            this.tabPageInput = new System.Windows.Forms.TabPage();
            this.panelInput = new System.Windows.Forms.Panel();
            this.groupBoxBasicInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelBasic = new System.Windows.Forms.TableLayoutPanel();
            this.labelVaccineName = new System.Windows.Forms.Label();
            this.comboVaccineName = new System.Windows.Forms.ComboBox();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.labelBatchNo = new System.Windows.Forms.Label();
            this.txtBatchNo = new System.Windows.Forms.TextBox();
            this.labelProduceDate = new System.Windows.Forms.Label();
            this.dateTimeProduce = new System.Windows.Forms.DateTimePicker();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.dateTimeExpiry = new System.Windows.Forms.DateTimePicker();
            this.labelStorageTemp = new System.Windows.Forms.Label();
            this.txtStorageTemp = new System.Windows.Forms.TextBox();
            this.labelTempUnit = new System.Windows.Forms.Label();
            this.groupBoxStockInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelStock = new System.Windows.Forms.TableLayoutPanel();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.labelUnit = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.labelPriceUnit = new System.Windows.Forms.Label();
            this.labelWarehouse = new System.Windows.Forms.Label();
            this.comboWarehouse = new System.Windows.Forms.ComboBox();
            this.labelRemark = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnPrintLabel = new System.Windows.Forms.Button();
            this.tabPageList = new System.Windows.Forms.TabPage();
            this.panelList = new System.Windows.Forms.Panel();
            this.dataGridViewVaccines = new System.Windows.Forms.DataGridView();
            this.panelListButtons = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelTitle.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageInput.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.groupBoxBasicInfo.SuspendLayout();
            this.tableLayoutPanelBasic.SuspendLayout();
            this.groupBoxStockInfo.SuspendLayout();
            this.tableLayoutPanelStock.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tabPageList.SuspendLayout();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccines)).BeginInit();
            this.panelListButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelTitle.Controls.Add(this.labelTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1350, 90);
            this.panelTitle.TabIndex = 0;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(30, 22);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(236, 47);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "疫苗入库管理";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageInput);
            this.tabControlMain.Controls.Add(this.tabPageList);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 90);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1350, 960);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageInput
            // 
            this.tabPageInput.Controls.Add(this.panelInput);
            this.tabPageInput.Location = new System.Drawing.Point(4, 37);
            this.tabPageInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageInput.Name = "tabPageInput";
            this.tabPageInput.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageInput.Size = new System.Drawing.Size(1342, 919);
            this.tabPageInput.TabIndex = 0;
            this.tabPageInput.Text = "入库登记";
            this.tabPageInput.UseVisualStyleBackColor = true;
            // 
            // panelInput
            // 
            this.panelInput.Controls.Add(this.groupBoxBasicInfo);
            this.panelInput.Controls.Add(this.groupBoxStockInfo);
            this.panelInput.Controls.Add(this.panelButtons);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelInput.Location = new System.Drawing.Point(4, 4);
            this.panelInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelInput.Size = new System.Drawing.Size(1334, 911);
            this.panelInput.TabIndex = 0;
            // 
            // groupBoxBasicInfo
            // 
            this.groupBoxBasicInfo.Controls.Add(this.tableLayoutPanelBasic);
            this.groupBoxBasicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxBasicInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxBasicInfo.Location = new System.Drawing.Point(15, 345);
            this.groupBoxBasicInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBasicInfo.Name = "groupBoxBasicInfo";
            this.groupBoxBasicInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxBasicInfo.Size = new System.Drawing.Size(1304, 330);
            this.groupBoxBasicInfo.TabIndex = 0;
            this.groupBoxBasicInfo.TabStop = false;
            this.groupBoxBasicInfo.Text = "疫苗基本信息";
            // 
            // tableLayoutPanelBasic
            // 
            this.tableLayoutPanelBasic.ColumnCount = 6;
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelBasic.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelBasic.Controls.Add(this.labelVaccineName, 0, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.comboVaccineName, 1, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.labelManufacturer, 2, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.txtManufacturer, 3, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.labelBatchNo, 4, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.txtBatchNo, 5, 0);
            this.tableLayoutPanelBasic.Controls.Add(this.labelProduceDate, 0, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.dateTimeProduce, 1, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.labelExpiryDate, 2, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.dateTimeExpiry, 3, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.labelStorageTemp, 4, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.txtStorageTemp, 5, 1);
            this.tableLayoutPanelBasic.Controls.Add(this.labelTempUnit, 5, 2);
            this.tableLayoutPanelBasic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelBasic.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanelBasic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelBasic.Name = "tableLayoutPanelBasic";
            this.tableLayoutPanelBasic.RowCount = 3;
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelBasic.Size = new System.Drawing.Size(1296, 294);
            this.tableLayoutPanelBasic.TabIndex = 0;
            // 
            // labelVaccineName
            // 
            this.labelVaccineName.AutoSize = true;
            this.labelVaccineName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVaccineName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVaccineName.Location = new System.Drawing.Point(4, 0);
            this.labelVaccineName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVaccineName.Name = "labelVaccineName";
            this.labelVaccineName.Size = new System.Drawing.Size(186, 97);
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
            "肺炎疫苗",
            "狂犬病疫苗"});
            this.comboVaccineName.Location = new System.Drawing.Point(198, 8);
            this.comboVaccineName.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.comboVaccineName.Name = "comboVaccineName";
            this.comboVaccineName.Size = new System.Drawing.Size(251, 36);
            this.comboVaccineName.TabIndex = 1;
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelManufacturer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelManufacturer.Location = new System.Drawing.Point(457, 0);
            this.labelManufacturer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(186, 97);
            this.labelManufacturer.TabIndex = 2;
            this.labelManufacturer.Text = "生产厂家：";
            this.labelManufacturer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtManufacturer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtManufacturer.Location = new System.Drawing.Point(651, 8);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(251, 35);
            this.txtManufacturer.TabIndex = 3;
            // 
            // labelBatchNo
            // 
            this.labelBatchNo.AutoSize = true;
            this.labelBatchNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBatchNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelBatchNo.Location = new System.Drawing.Point(910, 0);
            this.labelBatchNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBatchNo.Name = "labelBatchNo";
            this.labelBatchNo.Size = new System.Drawing.Size(186, 97);
            this.labelBatchNo.TabIndex = 4;
            this.labelBatchNo.Text = "疫苗批号：";
            this.labelBatchNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBatchNo
            // 
            this.txtBatchNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBatchNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBatchNo.Location = new System.Drawing.Point(1104, 8);
            this.txtBatchNo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtBatchNo.Name = "txtBatchNo";
            this.txtBatchNo.Size = new System.Drawing.Size(188, 35);
            this.txtBatchNo.TabIndex = 5;
            // 
            // labelProduceDate
            // 
            this.labelProduceDate.AutoSize = true;
            this.labelProduceDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProduceDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProduceDate.Location = new System.Drawing.Point(4, 97);
            this.labelProduceDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProduceDate.Name = "labelProduceDate";
            this.labelProduceDate.Size = new System.Drawing.Size(186, 97);
            this.labelProduceDate.TabIndex = 6;
            this.labelProduceDate.Text = "生产日期：";
            this.labelProduceDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimeProduce
            // 
            this.dateTimeProduce.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeProduce.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeProduce.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeProduce.Location = new System.Drawing.Point(198, 105);
            this.dateTimeProduce.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dateTimeProduce.Name = "dateTimeProduce";
            this.dateTimeProduce.Size = new System.Drawing.Size(251, 35);
            this.dateTimeProduce.TabIndex = 7;
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelExpiryDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelExpiryDate.Location = new System.Drawing.Point(457, 97);
            this.labelExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(186, 97);
            this.labelExpiryDate.TabIndex = 8;
            this.labelExpiryDate.Text = "有效期至：";
            this.labelExpiryDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimeExpiry
            // 
            this.dateTimeExpiry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTimeExpiry.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dateTimeExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeExpiry.Location = new System.Drawing.Point(651, 105);
            this.dateTimeExpiry.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.dateTimeExpiry.Name = "dateTimeExpiry";
            this.dateTimeExpiry.Size = new System.Drawing.Size(251, 35);
            this.dateTimeExpiry.TabIndex = 9;
            // 
            // labelStorageTemp
            // 
            this.labelStorageTemp.AutoSize = true;
            this.labelStorageTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelStorageTemp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStorageTemp.Location = new System.Drawing.Point(910, 97);
            this.labelStorageTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStorageTemp.Name = "labelStorageTemp";
            this.labelStorageTemp.Size = new System.Drawing.Size(186, 97);
            this.labelStorageTemp.TabIndex = 10;
            this.labelStorageTemp.Text = "存储温度：";
            this.labelStorageTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStorageTemp
            // 
            this.txtStorageTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStorageTemp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStorageTemp.Location = new System.Drawing.Point(1104, 105);
            this.txtStorageTemp.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtStorageTemp.Name = "txtStorageTemp";
            this.txtStorageTemp.Size = new System.Drawing.Size(188, 35);
            this.txtStorageTemp.TabIndex = 11;
            this.txtStorageTemp.Text = "2-8";
            // 
            // labelTempUnit
            // 
            this.labelTempUnit.AutoSize = true;
            this.labelTempUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTempUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTempUnit.Location = new System.Drawing.Point(1104, 194);
            this.labelTempUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTempUnit.Name = "labelTempUnit";
            this.labelTempUnit.Size = new System.Drawing.Size(33, 100);
            this.labelTempUnit.TabIndex = 12;
            this.labelTempUnit.Text = "℃";
            this.labelTempUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBoxStockInfo
            // 
            this.groupBoxStockInfo.Controls.Add(this.tableLayoutPanelStock);
            this.groupBoxStockInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxStockInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxStockInfo.Location = new System.Drawing.Point(15, 15);
            this.groupBoxStockInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStockInfo.Name = "groupBoxStockInfo";
            this.groupBoxStockInfo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxStockInfo.Size = new System.Drawing.Size(1304, 330);
            this.groupBoxStockInfo.TabIndex = 1;
            this.groupBoxStockInfo.TabStop = false;
            this.groupBoxStockInfo.Text = "入库信息";
            // 
            // tableLayoutPanelStock
            // 
            this.tableLayoutPanelStock.ColumnCount = 6;
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelStock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanelStock.Controls.Add(this.labelQuantity, 0, 0);
            this.tableLayoutPanelStock.Controls.Add(this.txtQuantity, 1, 0);
            this.tableLayoutPanelStock.Controls.Add(this.labelUnit, 2, 0);
            this.tableLayoutPanelStock.Controls.Add(this.labelPrice, 3, 0);
            this.tableLayoutPanelStock.Controls.Add(this.txtPrice, 4, 0);
            this.tableLayoutPanelStock.Controls.Add(this.labelPriceUnit, 5, 0);
            this.tableLayoutPanelStock.Controls.Add(this.labelWarehouse, 0, 1);
            this.tableLayoutPanelStock.Controls.Add(this.comboWarehouse, 1, 1);
            this.tableLayoutPanelStock.Controls.Add(this.labelRemark, 0, 2);
            this.tableLayoutPanelStock.Controls.Add(this.txtRemark, 1, 2);
            this.tableLayoutPanelStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelStock.Location = new System.Drawing.Point(4, 32);
            this.tableLayoutPanelStock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanelStock.Name = "tableLayoutPanelStock";
            this.tableLayoutPanelStock.RowCount = 3;
            this.tableLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelStock.Size = new System.Drawing.Size(1296, 294);
            this.tableLayoutPanelStock.TabIndex = 0;
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelQuantity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelQuantity.Location = new System.Drawing.Point(4, 0);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(186, 97);
            this.labelQuantity.TabIndex = 0;
            this.labelQuantity.Text = "入库数量：";
            this.labelQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtQuantity.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtQuantity.Location = new System.Drawing.Point(198, 8);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(251, 35);
            this.txtQuantity.TabIndex = 1;
            this.txtQuantity.Text = "100";
            // 
            // labelUnit
            // 
            this.labelUnit.AutoSize = true;
            this.labelUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelUnit.Location = new System.Drawing.Point(457, 0);
            this.labelUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnit.Name = "labelUnit";
            this.labelUnit.Size = new System.Drawing.Size(33, 97);
            this.labelUnit.TabIndex = 2;
            this.labelUnit.Text = "支";
            this.labelUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPrice.Location = new System.Drawing.Point(651, 0);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(251, 97);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "入库单价：";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPrice.Location = new System.Drawing.Point(910, 8);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(186, 35);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.Text = "120.00";
            // 
            // labelPriceUnit
            // 
            this.labelPriceUnit.AutoSize = true;
            this.labelPriceUnit.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelPriceUnit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPriceUnit.Location = new System.Drawing.Point(1104, 0);
            this.labelPriceUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceUnit.Name = "labelPriceUnit";
            this.labelPriceUnit.Size = new System.Drawing.Size(63, 97);
            this.labelPriceUnit.TabIndex = 5;
            this.labelPriceUnit.Text = "元/支";
            this.labelPriceUnit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelWarehouse
            // 
            this.labelWarehouse.AutoSize = true;
            this.labelWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWarehouse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelWarehouse.Location = new System.Drawing.Point(4, 97);
            this.labelWarehouse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWarehouse.Name = "labelWarehouse";
            this.labelWarehouse.Size = new System.Drawing.Size(186, 97);
            this.labelWarehouse.TabIndex = 6;
            this.labelWarehouse.Text = "存放仓库：";
            this.labelWarehouse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboWarehouse
            // 
            this.comboWarehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboWarehouse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboWarehouse.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboWarehouse.FormattingEnabled = true;
            this.comboWarehouse.Items.AddRange(new object[] {
            "常温库",
            "冷藏库（2-8℃）",
            "冷冻库（-20℃）",
            "特殊药品库"});
            this.comboWarehouse.Location = new System.Drawing.Point(198, 105);
            this.comboWarehouse.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.comboWarehouse.Name = "comboWarehouse";
            this.comboWarehouse.Size = new System.Drawing.Size(251, 36);
            this.comboWarehouse.TabIndex = 7;
            // 
            // labelRemark
            // 
            this.labelRemark.AutoSize = true;
            this.labelRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelRemark.Location = new System.Drawing.Point(4, 194);
            this.labelRemark.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRemark.Name = "labelRemark";
            this.labelRemark.Size = new System.Drawing.Size(186, 100);
            this.labelRemark.TabIndex = 8;
            this.labelRemark.Text = "备   注：";
            this.labelRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.tableLayoutPanelStock.SetColumnSpan(this.txtRemark, 5);
            this.txtRemark.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemark.Location = new System.Drawing.Point(198, 202);
            this.txtRemark.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(1094, 84);
            this.txtRemark.TabIndex = 9;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnSave);
            this.panelButtons.Controls.Add(this.btnReset);
            this.panelButtons.Controls.Add(this.btnPrintLabel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(15, 776);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1304, 120);
            this.panelButtons.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(300, 30);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(240, 60);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "保  存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(570, 30);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(240, 60);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "重  置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // btnPrintLabel
            // 
            this.btnPrintLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPrintLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrintLabel.Location = new System.Drawing.Point(840, 30);
            this.btnPrintLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrintLabel.Name = "btnPrintLabel";
            this.btnPrintLabel.Size = new System.Drawing.Size(240, 60);
            this.btnPrintLabel.TabIndex = 2;
            this.btnPrintLabel.Text = "打印标签";
            this.btnPrintLabel.UseVisualStyleBackColor = true;
            this.btnPrintLabel.Click += new System.EventHandler(this.BtnPrintLabel_Click);
            // 
            // tabPageList
            // 
            this.tabPageList.Controls.Add(this.panelList);
            this.tabPageList.Controls.Add(this.panelListButtons);
            this.tabPageList.Location = new System.Drawing.Point(4, 37);
            this.tabPageList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageList.Name = "tabPageList";
            this.tabPageList.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPageList.Size = new System.Drawing.Size(1342, 919);
            this.tabPageList.TabIndex = 1;
            this.tabPageList.Text = "入库记录";
            this.tabPageList.UseVisualStyleBackColor = true;
            // 
            // panelList
            // 
            this.panelList.Controls.Add(this.dataGridViewVaccines);
            this.panelList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelList.Location = new System.Drawing.Point(4, 4);
            this.panelList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelList.Name = "panelList";
            this.panelList.Padding = new System.Windows.Forms.Padding(15, 15, 15, 15);
            this.panelList.Size = new System.Drawing.Size(1334, 791);
            this.panelList.TabIndex = 0;
            // 
            // dataGridViewVaccines
            // 
            this.dataGridViewVaccines.AllowUserToAddRows = false;
            this.dataGridViewVaccines.AllowUserToDeleteRows = false;
            this.dataGridViewVaccines.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(248)))));
            this.dataGridViewVaccines.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewVaccines.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewVaccines.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewVaccines.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewVaccines.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewVaccines.ColumnHeadersHeight = 40;
            this.dataGridViewVaccines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewVaccines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVaccines.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.dataGridViewVaccines.Location = new System.Drawing.Point(15, 15);
            this.dataGridViewVaccines.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewVaccines.MultiSelect = false;
            this.dataGridViewVaccines.Name = "dataGridViewVaccines";
            this.dataGridViewVaccines.ReadOnly = true;
            this.dataGridViewVaccines.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridViewVaccines.RowHeadersVisible = false;
            this.dataGridViewVaccines.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridViewVaccines.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewVaccines.RowTemplate.Height = 35;
            this.dataGridViewVaccines.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewVaccines.Size = new System.Drawing.Size(1304, 761);
            this.dataGridViewVaccines.TabIndex = 1;
            this.dataGridViewVaccines.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVaccines_CellDoubleClick);
            // 
            // panelListButtons
            // 
            this.panelListButtons.Controls.Add(this.btnRefresh);
            this.panelListButtons.Controls.Add(this.btnDelete);
            this.panelListButtons.Controls.Add(this.btnExport);
            this.panelListButtons.Controls.Add(this.btnClose);
            this.panelListButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelListButtons.Location = new System.Drawing.Point(4, 795);
            this.panelListButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelListButtons.Name = "panelListButtons";
            this.panelListButtons.Size = new System.Drawing.Size(1334, 120);
            this.panelListButtons.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(150, 30);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(240, 60);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "刷  新";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(420, 30);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(240, 60);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "删  除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnExport
            // 
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExport.Location = new System.Drawing.Point(690, 30);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(240, 60);
            this.btnExport.TabIndex = 2;
            this.btnExport.Text = "导  出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(960, 30);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(240, 60);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关  闭";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // VaccineStockForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 1050);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.panelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VaccineStockForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "疫苗入库管理";
            this.Load += new System.EventHandler(this.VaccineStockForm_Load);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageInput.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.groupBoxBasicInfo.ResumeLayout(false);
            this.tableLayoutPanelBasic.ResumeLayout(false);
            this.tableLayoutPanelBasic.PerformLayout();
            this.groupBoxStockInfo.ResumeLayout(false);
            this.tableLayoutPanelStock.ResumeLayout(false);
            this.tableLayoutPanelStock.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tabPageList.ResumeLayout(false);
            this.panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccines)).EndInit();
            this.panelListButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInput;
        private System.Windows.Forms.TabPage tabPageList;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.GroupBox groupBoxBasicInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBasic;
        private System.Windows.Forms.Label labelVaccineName;
        private System.Windows.Forms.ComboBox comboVaccineName;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Label labelBatchNo;
        private System.Windows.Forms.TextBox txtBatchNo;
        private System.Windows.Forms.Label labelProduceDate;
        private System.Windows.Forms.DateTimePicker dateTimeProduce;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.DateTimePicker dateTimeExpiry;
        private System.Windows.Forms.Label labelStorageTemp;
        private System.Windows.Forms.TextBox txtStorageTemp;
        private System.Windows.Forms.Label labelTempUnit;
        private System.Windows.Forms.GroupBox groupBoxStockInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelStock;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label labelUnit;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label labelPriceUnit;
        private System.Windows.Forms.Label labelWarehouse;
        private System.Windows.Forms.ComboBox comboWarehouse;
        private System.Windows.Forms.Label labelRemark;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrintLabel;
        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.DataGridView dataGridViewVaccines;
        private System.Windows.Forms.Panel panelListButtons;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}