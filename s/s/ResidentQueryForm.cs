using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CommunityHospital
{
    public partial class ResidentQueryForm : Form
    {
        // 数据库连接和命令对象
        private System.Data.SqlClient.SqlConnection sqlConnection;
        private System.Data.SqlClient.SqlCommand sqlCommand;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter;
        private DataTable dataTableResidents;

        public ResidentQueryForm()
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
                sqlConnection = new System.Data.SqlClient.SqlConnection(connectionString);

                // 创建命令对象
                sqlCommand = new System.Data.SqlClient.SqlCommand();
                sqlCommand.Connection = sqlConnection;

                // 创建数据适配器
                sqlDataAdapter = new System.Data.SqlClient.SqlDataAdapter(sqlCommand);

                // 创建数据表
                dataTableResidents = new DataTable();
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
                dataGridViewResidents.Columns.Clear();

                // 添加列
                dataGridViewResidents.Columns.Add("ResidentID", "档案编号");
                dataGridViewResidents.Columns.Add("Name", "姓名");
                dataGridViewResidents.Columns.Add("Gender", "性别");
                dataGridViewResidents.Columns.Add("Age", "年龄");
                dataGridViewResidents.Columns.Add("IDCard", "身份证号");
                dataGridViewResidents.Columns.Add("Phone", "联系电话");
                dataGridViewResidents.Columns.Add("Address", "家庭地址");
                dataGridViewResidents.Columns.Add("Allergy", "过敏史");
                dataGridViewResidents.Columns.Add("Community", "所属社区");
                dataGridViewResidents.Columns.Add("ArchiveDate", "建档日期");
                dataGridViewResidents.Columns.Add("Status", "档案状态");

                // 设置列宽
                dataGridViewResidents.Columns["ResidentID"].Width = 100;
                dataGridViewResidents.Columns["Name"].Width = 80;
                dataGridViewResidents.Columns["Gender"].Width = 60;
                dataGridViewResidents.Columns["Age"].Width = 60;
                dataGridViewResidents.Columns["IDCard"].Width = 180;
                dataGridViewResidents.Columns["Phone"].Width = 120;
                dataGridViewResidents.Columns["Address"].Width = 180;
                dataGridViewResidents.Columns["Allergy"].Width = 100;
                dataGridViewResidents.Columns["Community"].Width = 100;
                dataGridViewResidents.Columns["ArchiveDate"].Width = 100;
                dataGridViewResidents.Columns["Status"].Width = 80;

                // 设置列对齐方式
                dataGridViewResidents.Columns["ResidentID"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewResidents.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewResidents.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewResidents.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                // 设置身份证号列的格式
                dataGridViewResidents.Columns["IDCard"].DefaultCellStyle.Font = new Font("Consolas", 10.5f);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据表格初始化失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadInitialData()
        {
            // 设置默认条件
            comboGender.SelectedIndex = 0;
            comboAgeRange.SelectedIndex = 0;
            comboAllergy.SelectedIndex = 0;
            comboCommunity.SelectedIndex = 0;

            // 设置默认日期
            dateTimeArchiveStart.Value = DateTime.Today.AddMonths(-3);
            dateTimeArchiveEnd.Value = DateTime.Today;
        }

        private void ResidentQueryForm_Load(object sender, EventArgs e)
        {
            // 窗体加载时执行一次查询
            ExecuteQuery();
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            ExecuteQuery();
        }

        private void ExecuteQuery()
        {
            try
            {
                // 构建查询条件
                string query = BuildQueryString();

                // 设置命令文本
                sqlCommand.CommandText = query;

                // 清空数据表
                dataTableResidents.Clear();

                // 打开连接并填充数据
                if (sqlConnection.State != ConnectionState.Open)
                    sqlConnection.Open();

                sqlDataAdapter.Fill(dataTableResidents);

                // 关闭连接
                sqlConnection.Close();

                // 绑定数据到DataGridView
                BindDataToGridView();

                // 更新统计信息
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"查询失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildQueryString()
        {
            string baseQuery = "SELECT * FROM Residents WHERE 1=1";

            // 姓名条件
            if (!string.IsNullOrWhiteSpace(txtName.Text))
            {
                baseQuery += $" AND Name LIKE '%{txtName.Text.Trim()}%'";
            }

            // 身份证号条件
            if (!string.IsNullOrWhiteSpace(txtIDCard.Text))
            {
                baseQuery += $" AND IDCard LIKE '%{txtIDCard.Text.Trim()}%'";
            }

            // 性别条件
            if (comboGender.SelectedIndex > 0)
            {
                baseQuery += $" AND Gender = '{comboGender.Text}'";
            }

            // 年龄段条件
            if (comboAgeRange.SelectedIndex > 0)
            {
                string ageRange = comboAgeRange.Text;
                if (ageRange == "0-6岁")
                    baseQuery += " AND Age BETWEEN 0 AND 6";
                else if (ageRange == "7-17岁")
                    baseQuery += " AND Age BETWEEN 7 AND 17";
                else if (ageRange == "18-59岁")
                    baseQuery += " AND Age BETWEEN 18 AND 59";
                else if (ageRange == "60岁及以上")
                    baseQuery += " AND Age >= 60";
            }

            // 过敏史条件
            if (comboAllergy.SelectedIndex > 0)
            {
                if (comboAllergy.Text == "有过敏史")
                    baseQuery += " AND AllergyHistory IS NOT NULL AND AllergyHistory <> ''";
                else if (comboAllergy.Text == "无过敏史")
                    baseQuery += " AND (AllergyHistory IS NULL OR AllergyHistory = '')";
            }

            // 联系电话条件
            if (!string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                baseQuery += $" AND Phone LIKE '%{txtPhone.Text.Trim()}%'";
            }

            // 建档日期条件
            if (dateTimeArchiveStart.Value.Date <= dateTimeArchiveEnd.Value.Date)
            {
                string startDate = dateTimeArchiveStart.Value.ToString("yyyy-MM-dd");
                string endDate = dateTimeArchiveEnd.Value.AddDays(1).ToString("yyyy-MM-dd");
                baseQuery += $" AND CreateDate >= '{startDate}' AND CreateDate < '{endDate}'";
            }

            // 社区条件
            if (comboCommunity.SelectedIndex > 0)
            {
                baseQuery += $" AND Community = '{comboCommunity.Text}'";
            }

            // 排序
            baseQuery += " ORDER BY CreateDate DESC";

            return baseQuery;
        }

        private void BindDataToGridView()
        {
            try
            {
                dataGridViewResidents.Rows.Clear();

                foreach (DataRow row in dataTableResidents.Rows)
                {
                    // 计算年龄（如果数据库中没有Age字段）
                    int age = 0;
                    if (row["BirthDate"] != DBNull.Value)
                    {
                        DateTime birthDate = Convert.ToDateTime(row["BirthDate"]);
                        age = DateTime.Now.Year - birthDate.Year;
                        if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
                            age--;
                    }

                    // 添加行数据
                    dataGridViewResidents.Rows.Add(
                        row["ResidentID"].ToString(),
                        row["Name"].ToString(),
                        row["Gender"].ToString(),
                        age.ToString(),
                        FormatIDCard(row["IDCard"].ToString()),
                        row["Phone"].ToString(),
                        row["Address"].ToString(),
                        FormatAllergyHistory(row["AllergyHistory"].ToString()),
                        row["Community"].ToString(),
                        Convert.ToDateTime(row["CreateDate"]).ToString("yyyy-MM-dd"),
                        row["Status"]?.ToString() ?? "正常"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"数据绑定失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatIDCard(string idCard)
        {
            if (string.IsNullOrEmpty(idCard) || idCard.Length < 18)
                return idCard;

            // 显示首尾，中间用*代替：320***********1234
            return idCard.Substring(0, 3) + new string('*', 12) + idCard.Substring(15);
        }

        private string FormatAllergyHistory(string allergy)
        {
            if (string.IsNullOrEmpty(allergy))
                return "无";

            if (allergy.Length > 10)
                return allergy.Substring(0, 8) + "...";

            return allergy;
        }

        private void UpdateStatistics()
        {
            int totalCount = dataGridViewResidents.RowCount;
            lblTotalCount.Text = $"总计：{totalCount} 条";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // 重置查询条件
            txtName.Clear();
            txtIDCard.Clear();
            txtPhone.Clear();
            comboGender.SelectedIndex = 0;
            comboAgeRange.SelectedIndex = 0;
            comboAllergy.SelectedIndex = 0;
            comboCommunity.SelectedIndex = 0;
            dateTimeArchiveStart.Value = DateTime.Today.AddMonths(-3);
            dateTimeArchiveEnd.Value = DateTime.Today;

            // 清空数据表格
            dataGridViewResidents.Rows.Clear();
            UpdateStatistics();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewResidents.RowCount == 0)
                {
                    MessageBox.Show("没有数据可以导出！", "提示",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
                saveFileDialog.Title = "导出居民档案数据";
                saveFileDialog.FileName = $"居民档案查询结果_{DateTime.Now:yyyyMMdd_HHmmss}";

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

        private void BtnDetail_Click(object sender, EventArgs e)
        {
            ShowResidentDetail();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditResident();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteResident();
        }

        private void DataGridViewResidents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ShowResidentDetail();
            }
        }

        private void DataGridViewResidents_SelectionChanged(object sender, EventArgs e)
        {
            // 启用或禁用按钮
            bool hasSelection = dataGridViewResidents.SelectedRows.Count > 0;
            btnDetail.Enabled = hasSelection;
            btnEdit.Enabled = hasSelection;
            btnDelete.Enabled = hasSelection;
        }

        private void ShowResidentDetail()
        {
            if (dataGridViewResidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要查看的居民档案！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string residentID = dataGridViewResidents.SelectedRows[0].Cells["ResidentID"].Value.ToString();

                // 打开居民档案详情窗口
               // ResidentDetailForm detailForm = new ResidentDetailForm(residentID);
                //detailForm.ShowDialog();

                // 如果详情窗口中修改了数据，重新查询
             /*   if (detailForm.DataChanged)
             {
                    ExecuteQuery();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开详情失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditResident()
        {
            if (dataGridViewResidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要编辑的居民档案！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string residentID = dataGridViewResidents.SelectedRows[0].Cells["ResidentID"].Value.ToString();

                // 打开居民档案编辑窗口
                //ResidentEditForm editForm = new ResidentEditForm(residentID);
              //editForm.ShowDialog();

                // 如果编辑窗口中修改了数据，重新查询
               /* if (editForm.DataChanged)
                {
                    ExecuteQuery();
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"打开编辑窗口失败：{ex.Message}", "错误",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteResident()
        {
            if (dataGridViewResidents.SelectedRows.Count == 0)
            {
                MessageBox.Show("请选择要删除的居民档案！", "提示",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string residentID = dataGridViewResidents.SelectedRows[0].Cells["ResidentID"].Value.ToString();
                string residentName = dataGridViewResidents.SelectedRows[0].Cells["Name"].Value.ToString();

                DialogResult result = MessageBox.Show($"确定要删除居民【{residentName}】的档案吗？\n此操作不可恢复！",
                    "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // 执行删除操作
                    string deleteQuery = $"DELETE FROM Residents WHERE ResidentID = '{residentID}'";

                    sqlCommand.CommandText = deleteQuery;

                    if (sqlConnection.State != ConnectionState.Open)
                        sqlConnection.Open();

                    int rowsAffected = sqlCommand.ExecuteNonQuery();

                    sqlConnection.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("居民档案删除成功！", "成功",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 重新查询
                        ExecuteQuery();
                    }
                    else
                    {
                        MessageBox.Show("删除失败，请重试！", "错误",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"删除失败：{ex.Message}", "错误",
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
                labelTitle.Text = "居民健康档案查询";
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

            if (dataTableResidents != null)
                dataTableResidents.Dispose();

            base.OnFormClosing(e);
        }
    }
}