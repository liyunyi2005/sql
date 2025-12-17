using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CommunityHospital
{
    public partial class VaccineStockForm : Form
    {
        // 数据库连接和命令对象
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlDataAdapter;
        private DataTable dataTableVaccines;

        public VaccineStockForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            InitializeDataGridView();
            LoadInitialData();
        }

        private void InitializeDatabaseConnection()
        {
            try
            {
                // 创建数据库连接
                string connectionString = "Data Source=.;Initial Catalog=CommunityHospital;Integrated Security=True";
                sqlConnection = new SqlConnection(connectionString);

                // 创建命令对象
                sqlCommand = new SqlCommand();
                sqlCommand.Connection = sqlConnection;

                // 创建数据适配器
                sqlDataAdapter = new SqlDataAdapter(sqlCommand);

                // 创建数据表
                dataTableVaccines = new DataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据库连接初始化失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridView()
        {
            try
            {
                // 清空现有列
                dataGridViewVaccines.Columns.Clear();

                // 添加列
                dataGridViewVaccines.Columns.Add("StockID", "入库编号");
                dataGridViewVaccines.Columns.Add("VaccineName", "疫苗名称");
                dataGridViewVaccines.Columns.Add("Manufacturer", "生产厂家");
                dataGridViewVaccines.Columns.Add("BatchNo", "批号");
                dataGridViewVaccines.Columns.Add("ProduceDate", "生产日期");
                dataGridViewVaccines.Columns.Add("ExpiryDate", "有效期至");
                dataGridViewVaccines.Columns.Add("Quantity", "数量");
                dataGridViewVaccines.Columns.Add("Unit", "单位");
                dataGridViewVaccines.Columns.Add("Price", "单价");
                dataGridViewVaccines.Columns.Add("TotalPrice", "总价");
                dataGridViewVaccines.Columns.Add("StorageTemp", "存储温度");
                dataGridViewVaccines.Columns.Add("Warehouse", "存放仓库");
                dataGridViewVaccines.Columns.Add("StockDate", "入库日期");
                dataGridViewVaccines.Columns.Add("Operator", "操作员");
                dataGridViewVaccines.Columns.Add("Status", "状态");

                // 设置列宽
                dataGridViewVaccines.Columns["StockID"].Width = 100;
                dataGridViewVaccines.Columns["VaccineName"].Width = 120;
                dataGridViewVaccines.Columns["Manufacturer"].Width = 120;
                dataGridViewVaccines.Columns["BatchNo"].Width = 100;
                dataGridViewVaccines.Columns["ProduceDate"].Width = 90;
                dataGridViewVaccines.Columns["ExpiryDate"].Width = 90;
                dataGridViewVaccines.Columns["Quantity"].Width = 70;
                dataGridViewVaccines.Columns["Unit"].Width = 50;
                dataGridViewVaccines.Columns["Price"].Width = 70;
                dataGridViewVaccines.Columns["TotalPrice"].Width = 70;
                dataGridViewVaccines.Columns["StorageTemp"].Width = 80;
                dataGridViewVaccines.Columns["Warehouse"].Width = 100;
                dataGridViewVaccines.Columns["StockDate"].Width = 90;
                dataGridViewVaccines.Columns["Operator"].Width = 80;
                dataGridViewVaccines.Columns["Status"].Width = 70;

                // 设置列对齐方式
                dataGridViewVaccines.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewVaccines.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewVaccines.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dataGridViewVaccines.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 设置数字格式
                dataGridViewVaccines.Columns["Price"].DefaultCellStyle.Format = "N2";
                dataGridViewVaccines.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";

                // 设置日期格式
                dataGridViewVaccines.Columns["ProduceDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dataGridViewVaccines.Columns["ExpiryDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
                dataGridViewVaccines.Columns["StockDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据表格初始化失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInitialData()
        {
            try
            {
                // 设置默认值
                comboVaccineName.SelectedIndex = 0;
                comboWarehouse.SelectedIndex = 1; // 默认冷藏库

                // 设置默认日期
                dateTimeProduce.Value = DateTime.Today.AddMonths(-1);
                dateTimeExpiry.Value = DateTime.Today.AddYears(1);

                // 加载入库记录
                LoadStockRecords();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"初始化数据失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VaccineStockForm_Load(object sender, EventArgs e)
        {
            // 窗体加载完成
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveStockRecord();
        }

        private void SaveStockRecord()
        {
            try
            {
                // 验证输入
                if (!ValidateInput())
                    return;

                // 生成入库编号
                string stockID = GenerateStockID();

                // 计算总价
                decimal quantity = decimal.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                decimal totalPrice = quantity * price;

                // 构建插入语句
                string query = @"
                    INSERT INTO VaccineStock (
                        StockID, VaccineName, Manufacturer, BatchNo, 
                        ProduceDate, ExpiryDate, Quantity, Unit, Price, 
                        TotalPrice, StorageTemp, Warehouse, Remark, 
                        StockDate, Operator, Status
                    ) VALUES (
                        @StockID, @VaccineName, @Manufacturer, @BatchNo,
                        @ProduceDate, @ExpiryDate, @Quantity, @Unit, @Price,
                        @TotalPrice, @StorageTemp, @Warehouse, @Remark,
                        @StockDate, @Operator, @Status
                    )";

                // 设置命令参数
                sqlCommand.CommandText = query;
                sqlCommand.Parameters.Clear();

                sqlCommand.Parameters.AddWithValue("@StockID", stockID);
                sqlCommand.Parameters.AddWithValue("@VaccineName", comboVaccineName.Text);
                sqlCommand.Parameters.AddWithValue("@Manufacturer", txtManufacturer.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@BatchNo", txtBatchNo.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@ProduceDate", dateTimeProduce.Value.Date);
                sqlCommand.Parameters.AddWithValue("@ExpiryDate", dateTimeExpiry.Value.Date);
                sqlCommand.Parameters.AddWithValue("@Quantity", quantity);
                sqlCommand.Parameters.AddWithValue("@Unit", "支");
                sqlCommand.Parameters.AddWithValue("@Price", price);
                sqlCommand.Parameters.AddWithValue("@TotalPrice", totalPrice);
                sqlCommand.Parameters.AddWithValue("@StorageTemp", txtStorageTemp.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@Warehouse", comboWarehouse.Text);
                sqlCommand.Parameters.AddWithValue("@Remark", txtRemark.Text.Trim());
                sqlCommand.Parameters.AddWithValue("@StockDate", DateTime.Now.Date);
                sqlCommand.Parameters.AddWithValue("@Operator", LoginForm.GlobalSettings.CurrentUser);
                sqlCommand.Parameters.AddWithValue("@Status", "正常");

                // 执行插入
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                int rowsAffected = sqlCommand.ExecuteNonQuery();

                sqlConnection.Close();

                if (rowsAffected > 0)
                {
                    // 更新疫苗库存
                    UpdateVaccineInventory(comboVaccineName.Text, quantity);

                    MessageBox.Show("疫苗入库成功！", "成功",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 重置表单
                    BtnReset_Click(null, null);

                    // 刷新列表
                    LoadStockRecords();

                    // 切换到列表页
                    tabControlMain.SelectedIndex = 1;
                }
                else
                {
                    MessageBox.Show("入库失败，请重试！", "错误",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // 验证疫苗名称
            if (string.IsNullOrWhiteSpace(comboVaccineName.Text))
            {
                MessageBox.Show("请选择疫苗名称！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboVaccineName.Focus();
                return false;
            }

            // 验证生产厂家
            if (string.IsNullOrWhiteSpace(txtManufacturer.Text.Trim()))
            {
                MessageBox.Show("请输入生产厂家！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtManufacturer.Focus();
                return false;
            }

            // 验证批号
            if (string.IsNullOrWhiteSpace(txtBatchNo.Text.Trim()))
            {
                MessageBox.Show("请输入疫苗批号！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBatchNo.Focus();
                return false;
            }

            // 验证有效期
            if (dateTimeExpiry.Value <= dateTimeProduce.Value)
            {
                MessageBox.Show("有效期必须晚于生产日期！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimeExpiry.Focus();
                return false;
            }

            // 验证数量
            if (!decimal.TryParse(txtQuantity.Text, out decimal quantity) || quantity <= 0)
            {
                MessageBox.Show("请输入有效的入库数量！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return false;
            }

            // 验证单价
            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("请输入有效的入库单价！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPrice.Focus();
                return false;
            }

            // 验证存储温度
            if (string.IsNullOrWhiteSpace(txtStorageTemp.Text.Trim()))
            {
                MessageBox.Show("请输入存储温度！", "验证错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStorageTemp.Focus();
                return false;
            }

            return true;
        }

        private string GenerateStockID()
        {
            // 生成入库编号：VS20241224001
            string prefix = "VS" + DateTime.Now.ToString("yyyyMMdd");

            // 查询当日最大编号
            string query = $"SELECT MAX(StockID) FROM VaccineStock WHERE StockID LIKE '{prefix}%'";

            sqlCommand.CommandText = query;

            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open();

            object result = sqlCommand.ExecuteScalar();

            sqlConnection.Close();

            int sequence = 1;
            if (result != null && result != DBNull.Value)
            {
                string maxID = result.ToString();
                if (maxID.Length >= prefix.Length + 3)
                {
                    string seqStr = maxID.Substring(prefix.Length);
                    if (int.TryParse(seqStr, out int maxSeq))
                    {
                        sequence = maxSeq + 1;
                    }
                }
            }

            return prefix + sequence.ToString("D3");
        }

        private void UpdateVaccineInventory(string vaccineName, decimal quantity)
        {
            try
            {
                // 检查库存是否存在
                string checkQuery = $"SELECT COUNT(*) FROM VaccineInventory WHERE VaccineName = '{vaccineName}'";

                sqlCommand.CommandText = checkQuery;

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                int count = (int)sqlCommand.ExecuteScalar();

                if (count > 0)
                {
                    // 更新库存
                    string updateQuery = $"UPDATE VaccineInventory SET Quantity = Quantity + {quantity}, LastUpdate = GETDATE() WHERE VaccineName = '{vaccineName}'";
                    sqlCommand.CommandText = updateQuery;
                    sqlCommand.ExecuteNonQuery();
                }
                else
                {
                    // 插入新库存
                    string insertQuery = $"INSERT INTO VaccineInventory (VaccineName, Quantity, Unit, LastUpdate) VALUES ('{vaccineName}', {quantity}, '支', GETDATE())";
                    sqlCommand.CommandText = insertQuery;
                    sqlCommand.ExecuteNonQuery();
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"更新库存失败：{ex.Message}", "警告",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void ResetForm()
        {
            // 重置表单
            comboVaccineName.SelectedIndex = 0;
            txtManufacturer.Clear();
            txtBatchNo.Clear();
            dateTimeProduce.Value = DateTime.Today.AddMonths(-1);
            dateTimeExpiry.Value = DateTime.Today.AddYears(1);
            txtStorageTemp.Text = "2-8";
            txtQuantity.Text = "100";
            txtPrice.Text = "120.00";
            comboWarehouse.SelectedIndex = 1;
            txtRemark.Clear();

            comboVaccineName.Focus();
        }

        private void BtnPrintLabel_Click(object sender, EventArgs e)
        {
            PrintVaccineLabel();
        }

        private void PrintVaccineLabel()
        {
            try
            {
                // 验证是否已选择疫苗
                if (string.IsNullOrWhiteSpace(comboVaccineName.Text))
                {
                    MessageBox.Show("请先选择疫苗名称！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 这里应该实现打印功能
                // 可以打印疫苗标签、入库单等

                MessageBox.Show("打印功能需要连接打印机", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打印失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadStockRecords();
        }

        private void LoadStockRecords()
        {
            try
            {
                // 查询入库记录
                string query = @"
                    SELECT 
                        StockID, VaccineName, Manufacturer, BatchNo,
                        CONVERT(varchar(10), ProduceDate, 120) as ProduceDate,
                        CONVERT(varchar(10), ExpiryDate, 120) as ExpiryDate,
                        Quantity, Unit, Price, TotalPrice,
                        StorageTemp, Warehouse, 
                        CONVERT(varchar(10), StockDate, 120) as StockDate,
                        Operator, Status
                    FROM VaccineStock 
                    ORDER BY StockDate DESC, StockID DESC";

                sqlCommand.CommandText = query;
                dataTableVaccines.Clear();

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                sqlDataAdapter.Fill(dataTableVaccines);

                sqlConnection.Close();

                // 绑定数据到DataGridView
                BindDataToGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载入库记录失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindDataToGridView()
        {
            try
            {
                dataGridViewVaccines.Rows.Clear();

                foreach (DataRow row in dataTableVaccines.Rows)
                {
                    // 检查有效期，标记即将过期的疫苗
                    string status = row["Status"].ToString();
                    DateTime expiryDate = Convert.ToDateTime(row["ExpiryDate"]);
                    if (expiryDate <= DateTime.Today.AddMonths(1) && expiryDate > DateTime.Today)
                    {
                        status = "即将过期";
                    }
                    else if (expiryDate <= DateTime.Today)
                    {
                        status = "已过期";
                    }

                    // 添加行数据
                    dataGridViewVaccines.Rows.Add(
                        row["StockID"].ToString(),
                        row["VaccineName"].ToString(),
                        row["Manufacturer"].ToString(),
                        row["BatchNo"].ToString(),
                        row["ProduceDate"].ToString(),
                        row["ExpiryDate"].ToString(),
                        row["Quantity"].ToString(),
                        row["Unit"].ToString(),
                        Convert.ToDecimal(row["Price"]).ToString("N2"),
                        Convert.ToDecimal(row["TotalPrice"]).ToString("N2"),
                        row["StorageTemp"].ToString(),
                        row["Warehouse"].ToString(),
                        row["StockDate"].ToString(),
                        row["Operator"].ToString(),
                        status
                    );

                    // 根据状态设置行颜色
                    DataGridViewRow gridRow = dataGridViewVaccines.Rows[dataGridViewVaccines.Rows.Count - 1];
                    if (status == "已过期")
                    {
                        gridRow.DefaultCellStyle.BackColor = Color.LightPink;
                        gridRow.DefaultCellStyle.ForeColor = Color.DarkRed;
                    }
                    else if (status == "即将过期")
                    {
                        gridRow.DefaultCellStyle.BackColor = Color.LightYellow;
                        gridRow.DefaultCellStyle.ForeColor = Color.DarkOrange;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据绑定失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteStockRecord();
        }

        private void DeleteStockRecord()
        {
            if (dataGridViewVaccines.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的入库记录！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string stockID = dataGridViewVaccines.SelectedRows[0].Cells["StockID"].Value.ToString();
                string vaccineName = dataGridViewVaccines.SelectedRows[0].Cells["VaccineName"].Value.ToString();
                decimal quantity = Convert.ToDecimal(dataGridViewVaccines.SelectedRows[0].Cells["Quantity"].Value);

                DialogResult result = MessageBox.Show($"确定要删除入库记录【{stockID}】吗？\n此操作会相应减少库存数量！",
                    "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 开始事务
                    if (sqlConnection.State != ConnectionState.Open)
                        sqlConnection.Open();

                    SqlTransaction transaction = sqlConnection.BeginTransaction();

                    try
                    {
                        // 1. 删除入库记录
                        sqlCommand.Transaction = transaction;
                        sqlCommand.CommandText = $"DELETE FROM VaccineStock WHERE StockID = '{stockID}'";
                        int rowsAffected = sqlCommand.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // 2. 更新库存（减少数量）
                            sqlCommand.CommandText = $"UPDATE VaccineInventory SET Quantity = Quantity - {quantity} WHERE VaccineName = '{vaccineName}'";
                            sqlCommand.ExecuteNonQuery();

                            // 提交事务
                            transaction.Commit();

                            MessageBox.Show("入库记录删除成功！", "成功",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // 刷新列表
                            LoadStockRecords();
                        }
                        else
                        {
                            transaction.Rollback();
                            MessageBox.Show("删除失败，请重试！", "错误",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        throw ex;
                    }
                    finally
                    {
                        sqlConnection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportStockRecords();
        }

        private void ExportStockRecords()
        {
            try
            {
                if (dataGridViewVaccines.RowCount == 0)
                {
                    MessageBox.Show("没有数据可以导出！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
                saveFileDialog.Title = "导出入库记录";
                saveFileDialog.FileName = $"疫苗入库记录_{DateTime.Now:yyyyMMdd_HHmmss}";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 这里应该实现导出逻辑
                    // 可以使用NPOI、EPPlus等库导出Excel

                    MessageBox.Show($"数据已导出到：{saveFileDialog.FileName}",
                        "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"导出失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridViewVaccines_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ShowStockDetail();
            }
        }

        private void ShowStockDetail()
        {
            if (dataGridViewVaccines.SelectedRows.Count == 0)
                return;

            try
            {
                string stockID = dataGridViewVaccines.SelectedRows[0].Cells["StockID"].Value.ToString();

                // 查询详细信息
                string query = $"SELECT * FROM VaccineStock WHERE StockID = '{stockID}'";

                sqlCommand.CommandText = query;

                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        StringBuilder detail = new StringBuilder();
                        detail.AppendLine($"入库编号：{reader["StockID"]}");
                        detail.AppendLine($"疫苗名称：{reader["VaccineName"]}");
                        detail.AppendLine($"生产厂家：{reader["Manufacturer"]}");
                        detail.AppendLine($"批　　号：{reader["BatchNo"]}");
                        detail.AppendLine($"生产日期：{Convert.ToDateTime(reader["ProduceDate"]):yyyy-MM-dd}");
                        detail.AppendLine($"有效期至：{Convert.ToDateTime(reader["ExpiryDate"]):yyyy-MM-dd}");
                        detail.AppendLine($"入库数量：{reader["Quantity"]} {reader["Unit"]}");
                        detail.AppendLine($"入库单价：{Convert.ToDecimal(reader["Price"]):N2} 元/{reader["Unit"]}");
                        detail.AppendLine($"总　　价：{Convert.ToDecimal(reader["TotalPrice"]):N2} 元");
                        detail.AppendLine($"存储温度：{reader["StorageTemp"]}");
                        detail.AppendLine($"存放仓库：{reader["Warehouse"]}");
                        detail.AppendLine($"入库日期：{Convert.ToDateTime(reader["StockDate"]):yyyy-MM-dd}");
                        detail.AppendLine($"操作人员：{reader["Operator"]}");
                        detail.AppendLine($"备　　注：{reader["Remark"]}");
                        detail.AppendLine($"状　　态：{reader["Status"]}");

                        MessageBox.Show(detail.ToString(), "入库记录详情",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"显示详情失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 辅助方法：显示提示信息
        private void ShowMessage(string message, bool isSuccess = true)
        {
            labelTitle.ForeColor = isSuccess ? Color.Green : Color.Red;
            labelTitle.Text = message;

            // 3秒后恢复原文本
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += (s, e) => {
                labelTitle.Text = "疫苗入库管理";
                labelTitle.ForeColor = Color.White;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            // 清理资源
            if (sqlConnection != null && sqlConnection.State == ConnectionState.Open)
                sqlConnection.Close();

            if (sqlConnection != null)
                sqlConnection.Dispose();

            if (sqlCommand != null)
                sqlCommand.Dispose();

            if (sqlDataAdapter != null)
                sqlDataAdapter.Dispose();

            if (dataTableVaccines != null)
                dataTableVaccines.Dispose();

            base.OnFormClosing(e);
        }
    }
}