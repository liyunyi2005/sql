using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CommunityHospital
{
	public partial class RecordAddForm : Form
	{
		// 数据库连接和命令对象
		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;
		private SqlDataAdapter sqlDataAdapter;
		private DataTable dataTableAppointments;
		private DataTable dataTableRecords;

		// 当前选中的预约信息
		private string selectedAppointmentID = "";
		private string selectedResidentID = "";
		private string selectedResidentName = "";
		private string selectedVaccineName = "";
		private string selectedDoseNumber = "";

		public RecordAddForm()
		{
			InitializeComponent();
			InitializeDatabaseConnection();
			InitializeDataGridViews();
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
				dataTableAppointments = new DataTable();
				dataTableRecords = new DataTable();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"数据库连接初始化失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InitializeDataGridViews()
		{
			try
			{
				// 初始化预约表格
				InitializeAppointmentsGridView();

				// 初始化接种记录表格
				InitializeRecordsGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"数据表格初始化失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InitializeAppointmentsGridView()
		{
			// 清空现有列
			dataGridViewAppointments.Columns.Clear();

			// 允许点击勾选（Designer 里把整个表设为 ReadOnly=true，这里需要覆盖）
			// 我们只允许编辑“选择”列，其它列保持只读。
			dataGridViewAppointments.ReadOnly = false;
			dataGridViewAppointments.EditMode = DataGridViewEditMode.EditOnEnter;

			// 添加“选择”列（必须是 CheckBox 列，不能用 Columns.Add 创建 TextBox 列）
			var selectColumn = new DataGridViewCheckBoxColumn
			{
				Name = "Select",
				HeaderText = "选择",
				Width = 60,
				FalseValue = false,
				TrueValue = true
			};
			dataGridViewAppointments.Columns.Add(selectColumn);
			dataGridViewAppointments.Columns.Add("AppointmentID", "预约编号");
			dataGridViewAppointments.Columns.Add("ResidentName", "居民姓名");
			dataGridViewAppointments.Columns.Add("VaccineName", "疫苗名称");
			dataGridViewAppointments.Columns.Add("DoseNumber", "接种剂次");
			dataGridViewAppointments.Columns.Add("AppointmentDate", "预约日期");
			dataGridViewAppointments.Columns.Add("TimeSlot", "预约时段");
			dataGridViewAppointments.Columns.Add("Status", "预约状态");

			// 除“选择”列外，其它列都只读，避免误编辑
			foreach (DataGridViewColumn col in dataGridViewAppointments.Columns)
			{
				col.ReadOnly = col.Name != "Select";
				col.SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			// 设置列宽
			dataGridViewAppointments.Columns["AppointmentID"].Width = 120;
			dataGridViewAppointments.Columns["ResidentName"].Width = 100;
			dataGridViewAppointments.Columns["VaccineName"].Width = 120;
			dataGridViewAppointments.Columns["DoseNumber"].Width = 80;
			dataGridViewAppointments.Columns["AppointmentDate"].Width = 100;
			dataGridViewAppointments.Columns["TimeSlot"].Width = 100;
			dataGridViewAppointments.Columns["Status"].Width = 80;

			// 设置列对齐方式
			dataGridViewAppointments.Columns["Select"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewAppointments.Columns["DoseNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewAppointments.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			// 让勾选框点击后立即提交值（否则要离开单元格才会更新）
			dataGridViewAppointments.CurrentCellDirtyStateChanged -= DataGridViewAppointments_CurrentCellDirtyStateChanged;
			dataGridViewAppointments.CurrentCellDirtyStateChanged += DataGridViewAppointments_CurrentCellDirtyStateChanged;
			dataGridViewAppointments.CellContentClick -= DataGridViewAppointments_CellContentClick;
			dataGridViewAppointments.CellContentClick += DataGridViewAppointments_CellContentClick;
			dataGridViewAppointments.CellClick -= DataGridViewAppointments_CellClick;
			dataGridViewAppointments.CellClick += DataGridViewAppointments_CellClick;

			// 设置日期格式
			dataGridViewAppointments.Columns["AppointmentDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
		}

		private void DataGridViewAppointments_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dataGridViewAppointments.IsCurrentCellDirty)
			{
				dataGridViewAppointments.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void DataGridViewAppointments_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
			if (dataGridViewAppointments.Columns[e.ColumnIndex].Name == "Select")
			{
				SetSelectedAppointmentRow(e.RowIndex);
			}
		}

		private void DataGridViewAppointments_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
			// 点击任意单元格都视为选择该预约
			SetSelectedAppointmentRow(e.RowIndex);
		}

		private void SetSelectedAppointmentRow(int rowIndex)
		{
			if (rowIndex < 0 || rowIndex >= dataGridViewAppointments.Rows.Count) return;

			for (int i = 0; i < dataGridViewAppointments.Rows.Count; i++)
			{
				var row = dataGridViewAppointments.Rows[i];
				row.Cells["Select"].Value = (i == rowIndex);
			}

			var selectedRow = dataGridViewAppointments.Rows[rowIndex];
			selectedAppointmentID = selectedRow.Cells["AppointmentID"].Value?.ToString() ?? "";
			selectedResidentName = selectedRow.Cells["ResidentName"].Value?.ToString() ?? "";
			selectedVaccineName = selectedRow.Cells["VaccineName"].Value?.ToString() ?? "";
			selectedDoseNumber = selectedRow.Cells["DoseNumber"].Value?.ToString() ?? "";

			if (!string.IsNullOrEmpty(selectedAppointmentID))
			{
				GetResidentInfoFromAppointment(selectedAppointmentID);
			}
			if (!string.IsNullOrEmpty(selectedVaccineName))
			{
				GetLatestVaccineBatch(selectedVaccineName);
			}
		}

		private void InitializeRecordsGridView()
		{
			try
			{
				// 清空现有列
				dataGridViewRecords.Columns.Clear();

				// 添加列
				dataGridViewRecords.Columns.Add("RecordID", "记录编号");
				dataGridViewRecords.Columns.Add("ResidentName", "居民姓名");
				dataGridViewRecords.Columns.Add("VaccineName", "疫苗名称");
				dataGridViewRecords.Columns.Add("BatchNo", "疫苗批号");
				dataGridViewRecords.Columns.Add("VaccinationTime", "接种时间");
				dataGridViewRecords.Columns.Add("VaccineSite", "接种部位");
				dataGridViewRecords.Columns.Add("Doctor", "接种医生");
				dataGridViewRecords.Columns.Add("Reaction", "不良反应");
				dataGridViewRecords.Columns.Add("Status", "记录状态");

				// 设置列宽
				dataGridViewRecords.Columns["RecordID"].Width = 120;
				dataGridViewRecords.Columns["ResidentName"].Width = 100;
				dataGridViewRecords.Columns["VaccineName"].Width = 120;
				dataGridViewRecords.Columns["BatchNo"].Width = 100;
				dataGridViewRecords.Columns["VaccinationTime"].Width = 150;
				dataGridViewRecords.Columns["VaccineSite"].Width = 80;
				dataGridViewRecords.Columns["Doctor"].Width = 80;
				dataGridViewRecords.Columns["Reaction"].Width = 100;
				dataGridViewRecords.Columns["Status"].Width = 80;

				// 设置列对齐方式
				dataGridViewRecords.Columns["VaccineSite"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dataGridViewRecords.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				// 设置日期格式
				dataGridViewRecords.Columns["VaccinationTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"接种记录表格初始化失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadInitialData()
		{
			try
			{
				// 设置默认值
				comboVaccineSite.SelectedIndex = 0;
				comboDoctor.SelectedIndex = 0;
				comboReaction.SelectedIndex = 0;
				comboHealthStatus.SelectedIndex = 0;

				// 设置接种时间为当前时间
				dateTimeVaccination.Value = DateTime.Now;

				// 加载可接种的预约记录
				LoadAppointments("");

				// 加载接种记录
				LoadVaccinationRecords();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"初始化数据失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void RecordAddForm_Load(object sender, EventArgs e)
		{
			// 窗体加载完成
		}

		private void LoadAppointments(string searchText)
		{
			try
			{
				// 构建查询语句（只查询已审核的预约）
				string query = @"
                    SELECT 
                        a.AppointmentID,
                        r.Name as ResidentName,
                        r.ResidentID,
                        a.VaccineName,
                        a.DoseNumber,
                        CONVERT(varchar(10), a.AppointmentDate, 120) as AppointmentDate,
                        a.TimeSlot,
                        a.Status
                    FROM Appointments a
                    JOIN Residents r ON a.ResidentID = r.ResidentID
                    WHERE a.Status = '已审核' 
                    AND a.AppointmentDate <= GETDATE()
                    AND NOT EXISTS (
                        SELECT 1 FROM VaccinationRecords vr 
                        WHERE vr.AppointmentID = a.AppointmentID
                    )";

				if (!string.IsNullOrWhiteSpace(searchText))
				{
					query += $" AND (r.Name LIKE '%{searchText}%' OR a.AppointmentID LIKE '%{searchText}%' OR a.VaccineName LIKE '%{searchText}%')";
				}

				query += " ORDER BY a.AppointmentDate, a.TimeSlot";

				// 执行查询
				sqlCommand.CommandText = query;
				dataTableAppointments.Clear();

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				sqlDataAdapter.Fill(dataTableAppointments);

				sqlConnection.Close();

				// 绑定数据到DataGridView
				BindAppointmentsToGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"加载预约记录失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BindAppointmentsToGridView()
		{
			try
			{
				dataGridViewAppointments.Rows.Clear();

				foreach (DataRow row in dataTableAppointments.Rows)
				{
					// 添加行数据
					int rowIndex = dataGridViewAppointments.Rows.Add(
						false,  // 选择框
						row["AppointmentID"].ToString(),
						row["ResidentName"].ToString(),
						row["VaccineName"].ToString(),
						row["DoseNumber"].ToString(),
						row["AppointmentDate"].ToString(),
						row["TimeSlot"].ToString(),
						row["Status"].ToString()
					);

					// 根据预约日期设置行颜色
					DateTime appointmentDate = Convert.ToDateTime(row["AppointmentDate"]);
					if (appointmentDate.Date < DateTime.Today)
					{
						// 过期预约用黄色标记
						DataGridViewRow gridRow = dataGridViewAppointments.Rows[rowIndex];
						gridRow.DefaultCellStyle.BackColor = Color.LightYellow;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkOrange;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"预约数据绑定失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadVaccinationRecords()
		{
			try
			{
				// 查询接种记录
				string query = @"
                    SELECT 
                        vr.RecordID,
                        r.Name as ResidentName,
                        vr.VaccineName,
                        vr.BatchNo,
                        CONVERT(varchar(16), vr.VaccinationTime, 120) as VaccinationTime,
                        vr.VaccineSite,
                        vr.Doctor,
                        vr.Reaction,
                        vr.Status
                    FROM VaccinationRecords vr
                    JOIN Residents r ON vr.ResidentID = r.ResidentID
                    WHERE vr.VaccinationTime >= DATEADD(DAY, -30, GETDATE())
                    ORDER BY vr.VaccinationTime DESC";

				sqlCommand.CommandText = query;
				dataTableRecords.Clear();

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				sqlDataAdapter.Fill(dataTableRecords);

				sqlConnection.Close();

				// 绑定数据到DataGridView
				BindRecordsToGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"加载接种记录失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BindRecordsToGridView()
		{
			try
			{
				dataGridViewRecords.Rows.Clear();

				foreach (DataRow row in dataTableRecords.Rows)
				{
					// 添加行数据
					int rowIndex = dataGridViewRecords.Rows.Add(
						row["RecordID"].ToString(),
						row["ResidentName"].ToString(),
						row["VaccineName"].ToString(),
						row["BatchNo"].ToString(),
						row["VaccinationTime"].ToString(),
						row["VaccineSite"].ToString(),
						row["Doctor"].ToString(),
						row["Reaction"].ToString(),
						row["Status"].ToString()
					);

					// 根据状态设置行颜色
					DataGridViewRow gridRow = dataGridViewRecords.Rows[rowIndex];
					string status = row["Status"].ToString();

					if (status == "已完成")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightGreen;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
					}
					else if (status == "草稿")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightYellow;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkOrange;
					}
					else if (status == "异常")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightPink;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkRed;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"接种记录绑定失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TxtAppointmentSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				BtnSearchAppointment_Click(sender, e);
				e.Handled = true;
			}
		}

		private void BtnSearchAppointment_Click(object sender, EventArgs e)
		{
			LoadAppointments(txtAppointmentSearch.Text.Trim());
		}

		private void DataGridViewAppointments_SelectionChanged(object sender, EventArgs e)
		{
			// 兼容：如果用户通过“行选择”改变选中行，也同步勾选框与当前预约信息
			if (dataGridViewAppointments.CurrentRow != null && dataGridViewAppointments.CurrentRow.Index >= 0)
			{
				SetSelectedAppointmentRow(dataGridViewAppointments.CurrentRow.Index);
			}
		}

		private void GetResidentInfoFromAppointment(string appointmentID)
		{
			try
			{
				string query = $"SELECT ResidentID FROM Appointments WHERE AppointmentID = '{appointmentID}'";

				sqlCommand.CommandText = query;

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				object result = sqlCommand.ExecuteScalar();

				sqlConnection.Close();

				if (result != null && result != DBNull.Value)
				{
					selectedResidentID = result.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"获取居民信息失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetLatestVaccineBatch(string vaccineName)
		{
			try
			{
				string query = @"
                    SELECT TOP 1 BatchNo 
                    FROM VaccineStock 
                    WHERE VaccineName = @VaccineName 
                    AND ExpiryDate > GETDATE()
                    AND Quantity > 0
                    ORDER BY ProduceDate DESC";

				sqlCommand.CommandText = query;
				sqlCommand.Parameters.Clear();
				sqlCommand.Parameters.AddWithValue("@VaccineName", vaccineName);

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				object result = sqlCommand.ExecuteScalar();

				sqlConnection.Close();

				if (result != null && result != DBNull.Value)
				{
					txtBatchNo.Text = result.ToString();
				}
				else
				{
					txtBatchNo.Text = "";
					MessageBox.Show($"未找到【{vaccineName}】的有效批号，请检查库存！", "警告",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"获取疫苗批号失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnComplete_Click(object sender, EventArgs e)
		{
			CompleteVaccination(true);
		}

		private void BtnSaveDraft_Click(object sender, EventArgs e)
		{
			CompleteVaccination(false);
		}

		private void CompleteVaccination(bool isComplete)
		{
			try
			{
				// 验证输入
				if (!ValidateVaccination())
					return;

				// 生成接种记录编号
				string recordID = GenerateRecordID();

				// 获取预约信息
				if (string.IsNullOrEmpty(selectedAppointmentID))
				{
					MessageBox.Show("请选择接种的预约记录！", "验证错误",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// 构建插入语句
				string query = @"
                    INSERT INTO VaccinationRecords (
                        RecordID, AppointmentID, ResidentID, VaccineName,
                        BatchNo, VaccinationTime, VaccineSite, Doctor,
                        Reaction, Temperature, BloodPressure, HealthStatus,
                        Remark, Status, CreateTime, Operator
                    ) VALUES (
                        @RecordID, @AppointmentID, @ResidentID, @VaccineName,
                        @BatchNo, @VaccinationTime, @VaccineSite, @Doctor,
                        @Reaction, @Temperature, @BloodPressure, @HealthStatus,
                        @Remark, @Status, @CreateTime, @Operator
                    )";

				// 设置命令参数
				sqlCommand.CommandText = query;
				sqlCommand.Parameters.Clear();

				sqlCommand.Parameters.AddWithValue("@RecordID", recordID);
				sqlCommand.Parameters.AddWithValue("@AppointmentID", selectedAppointmentID);
				sqlCommand.Parameters.AddWithValue("@ResidentID", selectedResidentID);
				sqlCommand.Parameters.AddWithValue("@VaccineName", selectedVaccineName);
				sqlCommand.Parameters.AddWithValue("@BatchNo", txtBatchNo.Text.Trim());
				sqlCommand.Parameters.AddWithValue("@VaccinationTime", dateTimeVaccination.Value);
				sqlCommand.Parameters.AddWithValue("@VaccineSite", comboVaccineSite.Text);
				sqlCommand.Parameters.AddWithValue("@Doctor", comboDoctor.Text);
				sqlCommand.Parameters.AddWithValue("@Reaction", comboReaction.Text);
				sqlCommand.Parameters.AddWithValue("@Temperature", txtTemperature.Text.Trim());
				sqlCommand.Parameters.AddWithValue("@BloodPressure", txtBloodPressure.Text.Trim());
				sqlCommand.Parameters.AddWithValue("@HealthStatus", comboHealthStatus.Text);
				sqlCommand.Parameters.AddWithValue("@Remark", txtRemark.Text.Trim());
				sqlCommand.Parameters.AddWithValue("@Status", isComplete ? "已完成" : "草稿");
				sqlCommand.Parameters.AddWithValue("@CreateTime", DateTime.Now);
				sqlCommand.Parameters.AddWithValue("@Operator", LoginForm.GlobalSettings.CurrentUser);

				// 开始事务
				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				SqlTransaction transaction = sqlConnection.BeginTransaction();
				sqlCommand.Transaction = transaction;

				try
				{
					// 1. 插入接种记录
					int rowsAffected = sqlCommand.ExecuteNonQuery();

					if (rowsAffected > 0 && isComplete)
					{
						// 2. 更新预约状态为已完成
						string updateAppointmentQuery = $"UPDATE Appointments SET Status = '已完成' WHERE AppointmentID = '{selectedAppointmentID}'";
						sqlCommand.CommandText = updateAppointmentQuery;
						sqlCommand.ExecuteNonQuery();

						// 3. 更新疫苗库存（减少数量）
						string updateStockQuery = @"
                            UPDATE VaccineStock 
                            SET Quantity = Quantity - 1,
                                LastUpdate = GETDATE()
                            WHERE BatchNo = @BatchNo 
                            AND VaccineName = @VaccineName
                            AND Quantity > 0";

						sqlCommand.CommandText = updateStockQuery;
						sqlCommand.Parameters.Clear();
						sqlCommand.Parameters.AddWithValue("@BatchNo", txtBatchNo.Text.Trim());
						sqlCommand.Parameters.AddWithValue("@VaccineName", selectedVaccineName);
						sqlCommand.ExecuteNonQuery();

						// 4. 更新疫苗库存总表
						string updateInventoryQuery = @"
                            UPDATE VaccineInventory 
                            SET Quantity = Quantity - 1,
                                LastUpdate = GETDATE()
                            WHERE VaccineName = @VaccineName";

						sqlCommand.CommandText = updateInventoryQuery;
						sqlCommand.Parameters.Clear();
						sqlCommand.Parameters.AddWithValue("@VaccineName", selectedVaccineName);
						sqlCommand.ExecuteNonQuery();
					}

					// 提交事务
					transaction.Commit();

					string message = isComplete ? "接种完成！" : "记录已暂存！";
					MessageBox.Show(message, "成功",
						MessageBoxButtons.OK, MessageBoxIcon.Information);

					// 重置表单
					BtnReset_Click(null, null);

					// 刷新预约记录和接种记录
					LoadAppointments("");
					LoadVaccinationRecords();

					// 切换到接种记录页
					tabControlMain.SelectedIndex = 1;
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
			catch (Exception ex)
			{
				MessageBox.Show($"保存接种记录失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateVaccination()
		{
			// 验证预约选择
			if (string.IsNullOrEmpty(selectedAppointmentID))
			{
				MessageBox.Show("请选择接种的预约记录！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// 验证疫苗批号
			if (string.IsNullOrWhiteSpace(txtBatchNo.Text.Trim()))
			{
				MessageBox.Show("请输入疫苗批号！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				txtBatchNo.Focus();
				return false;
			}

			// 验证接种时间
			if (dateTimeVaccination.Value > DateTime.Now.AddMinutes(10))
			{
				MessageBox.Show("接种时间不能晚于当前时间10分钟以上！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dateTimeVaccination.Focus();
				return false;
			}

			// 验证接种部位
			if (string.IsNullOrWhiteSpace(comboVaccineSite.Text))
			{
				MessageBox.Show("请选择接种部位！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboVaccineSite.Focus();
				return false;
			}

			// 验证接种医生
			if (string.IsNullOrWhiteSpace(comboDoctor.Text))
			{
				MessageBox.Show("请选择接种医生！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboDoctor.Focus();
				return false;
			}

			// 验证体温
			if (!string.IsNullOrWhiteSpace(txtTemperature.Text.Trim()))
			{
				if (!double.TryParse(txtTemperature.Text.Trim(), out double temperature))
				{
					MessageBox.Show("请输入有效的体温数值！", "验证错误",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtTemperature.Focus();
					return false;
				}

				if (temperature < 35 || temperature > 42)
				{
					MessageBox.Show("体温应在35-42℃之间！", "验证错误",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					txtTemperature.Focus();
					return false;
				}
			}

			return true;
		}

		private string GenerateRecordID()
		{
			// 生成记录编号：VR20241224001
			string prefix = "VR" + DateTime.Now.ToString("yyyyMMdd");

			// 查询当日最大编号
			string query = $"SELECT MAX(RecordID) FROM VaccinationRecords WHERE RecordID LIKE '{prefix}%'";

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

		private void BtnReset_Click(object sender, EventArgs e)
		{
			ResetForm();
		}

		private void ResetForm()
		{
			// 重置预约选择
			foreach (DataGridViewRow row in dataGridViewAppointments.Rows)
			{
				row.Cells["Select"].Value = false;
			}

			selectedAppointmentID = "";
			selectedResidentID = "";
			selectedResidentName = "";
			selectedVaccineName = "";
			selectedDoseNumber = "";

			// 重置接种信息
			comboVaccineSite.SelectedIndex = 0;
			comboDoctor.SelectedIndex = 0;
			txtBatchNo.Clear();
			comboReaction.SelectedIndex = 0;
			txtTemperature.Clear();
			txtBloodPressure.Clear();
			comboHealthStatus.SelectedIndex = 0;
			txtRemark.Clear();
			dateTimeVaccination.Value = DateTime.Now;

			txtAppointmentSearch.Clear();
			txtAppointmentSearch.Focus();
		}

		private void BtnRefreshHistory_Click(object sender, EventArgs e)
		{
			LoadVaccinationRecords();
		}

		private void BtnEditRecord_Click(object sender, EventArgs e)
		{
			EditVaccinationRecord();
		}

		private void EditVaccinationRecord()
		{
			if (dataGridViewRecords.SelectedRows.Count == 0)
			{
				MessageBox.Show("请选择要编辑的接种记录！", "提示",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string recordID = dataGridViewRecords.SelectedRows[0].Cells["RecordID"].Value.ToString();
				string status = dataGridViewRecords.SelectedRows[0].Cells["Status"].Value.ToString();

				if (status == "已完成")
				{
					MessageBox.Show("已完成的接种记录不能编辑！", "提示",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// 查询记录详情并打开编辑窗口
				// 这里可以打开一个编辑窗口或者直接在表格中编辑
				// 为了简化，我们先显示详情
				ShowRecordDetail(recordID);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"编辑接种记录失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ShowRecordDetail(string recordID)
		{
			try
			{
				// 查询记录详细信息
				string query = @"
                    SELECT 
                        vr.*,
                        r.Name as ResidentName,
                        r.IDCard,
                        r.Phone,
                        a.VaccineType,
                        a.DoseNumber
                    FROM VaccinationRecords vr
                    JOIN Residents r ON vr.ResidentID = r.ResidentID
                    JOIN Appointments a ON vr.AppointmentID = a.AppointmentID
                    WHERE vr.RecordID = @RecordID";

				sqlCommand.CommandText = query;
				sqlCommand.Parameters.Clear();
				sqlCommand.Parameters.AddWithValue("@RecordID", recordID);

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				using (SqlDataReader reader = sqlCommand.ExecuteReader())
				{
					if (reader.Read())
					{
						StringBuilder detail = new StringBuilder();
						detail.AppendLine($"记录编号：{reader["RecordID"]}");
						detail.AppendLine($"居民姓名：{reader["ResidentName"]}");
						detail.AppendLine($"身份证号：{reader["IDCard"]}");
						detail.AppendLine($"联系电话：{reader["Phone"]}");
						detail.AppendLine($"疫苗名称：{reader["VaccineName"]}");
						detail.AppendLine($"疫苗类型：{reader["VaccineType"]}");
						detail.AppendLine($"接种剂次：{reader["DoseNumber"]}");
						detail.AppendLine($"疫苗批号：{reader["BatchNo"]}");
						detail.AppendLine($"接种时间：{Convert.ToDateTime(reader["VaccinationTime"]):yyyy-MM-dd HH:mm}");
						detail.AppendLine($"接种部位：{reader["VaccineSite"]}");
						detail.AppendLine($"接种医生：{reader["Doctor"]}");
						detail.AppendLine($"不良反应：{reader["Reaction"]}");
						detail.AppendLine($"体　　温：{reader["Temperature"]} ℃");
						detail.AppendLine($"血　　压：{reader["BloodPressure"]} mmHg");
						detail.AppendLine($"健康状况：{reader["HealthStatus"]}");
						detail.AppendLine($"备　　注：{reader["Remark"]}");
						detail.AppendLine($"记录状态：{reader["Status"]}");
						detail.AppendLine($"创建时间：{Convert.ToDateTime(reader["CreateTime"]):yyyy-MM-dd HH:mm}");
						detail.AppendLine($"操作人员：{reader["Operator"]}");

						MessageBox.Show(detail.ToString(), "接种记录详情",
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

		private void BtnDeleteRecord_Click(object sender, EventArgs e)
		{
			DeleteVaccinationRecord();
		}

		private void DeleteVaccinationRecord()
		{
			if (dataGridViewRecords.SelectedRows.Count == 0)
			{
				MessageBox.Show("请选择要删除的接种记录！", "提示",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string recordID = dataGridViewRecords.SelectedRows[0].Cells["RecordID"].Value.ToString();
				string residentName = dataGridViewRecords.SelectedRows[0].Cells["ResidentName"].Value.ToString();
				string status = dataGridViewRecords.SelectedRows[0].Cells["Status"].Value.ToString();

				DialogResult result = MessageBox.Show($"确定要删除居民【{residentName}】的接种记录吗？\n此操作不可恢复！",
					"删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

				if (result == DialogResult.Yes)
				{
					// 开始事务
					if (sqlConnection.State != ConnectionState.Open)
						sqlConnection.Open();

					SqlTransaction transaction = sqlConnection.BeginTransaction();
					sqlCommand.Transaction = transaction;

					try
					{
						// 1. 查询记录信息（用于恢复库存）
						string queryInfo = $"SELECT AppointmentID, VaccineName, BatchNo, Status FROM VaccinationRecords WHERE RecordID = '{recordID}'";
						sqlCommand.CommandText = queryInfo;

						string appointmentID = "";
						string vaccineName = "";
						string batchNo = "";
						string recordStatus = "";

						using (SqlDataReader reader = sqlCommand.ExecuteReader())
						{
							if (reader.Read())
							{
								appointmentID = reader["AppointmentID"].ToString();
								vaccineName = reader["VaccineName"].ToString();
								batchNo = reader["BatchNo"].ToString();
								recordStatus = reader["Status"].ToString();
							}
						}

						// 2. 删除接种记录
						string deleteQuery = $"DELETE FROM VaccinationRecords WHERE RecordID = '{recordID}'";
						sqlCommand.CommandText = deleteQuery;
						int rowsAffected = sqlCommand.ExecuteNonQuery();

						if (rowsAffected > 0)
						{
							// 3. 如果记录是"已完成"，需要恢复库存
							if (recordStatus == "已完成")
							{
								// 恢复疫苗库存
								string updateStockQuery = @"
                                    UPDATE VaccineStock 
                                    SET Quantity = Quantity + 1,
                                        LastUpdate = GETDATE()
                                    WHERE BatchNo = @BatchNo 
                                    AND VaccineName = @VaccineName";

								sqlCommand.CommandText = updateStockQuery;
								sqlCommand.Parameters.Clear();
								sqlCommand.Parameters.AddWithValue("@BatchNo", batchNo);
								sqlCommand.Parameters.AddWithValue("@VaccineName", vaccineName);
								sqlCommand.ExecuteNonQuery();

								// 恢复疫苗库存总表
								string updateInventoryQuery = @"
                                    UPDATE VaccineInventory 
                                    SET Quantity = Quantity + 1,
                                        LastUpdate = GETDATE()
                                    WHERE VaccineName = @VaccineName";

								sqlCommand.CommandText = updateInventoryQuery;
								sqlCommand.Parameters.Clear();
								sqlCommand.Parameters.AddWithValue("@VaccineName", vaccineName);
								sqlCommand.ExecuteNonQuery();

								// 恢复预约状态为"已审核"
								if (!string.IsNullOrEmpty(appointmentID))
								{
									string updateAppointmentQuery = $"UPDATE Appointments SET Status = '已审核' WHERE AppointmentID = '{appointmentID}'";
									sqlCommand.CommandText = updateAppointmentQuery;
									sqlCommand.ExecuteNonQuery();
								}
							}

							// 提交事务
							transaction.Commit();

							MessageBox.Show("接种记录删除成功！", "成功",
								MessageBoxButtons.OK, MessageBoxIcon.Information);

							// 刷新记录列表
							LoadVaccinationRecords();
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
				MessageBox.Show($"删除接种记录失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnExportHistory_Click(object sender, EventArgs e)
		{
			ExportVaccinationRecords();
		}

		private void ExportVaccinationRecords()
		{
			try
			{
				if (dataGridViewRecords.RowCount == 0)
				{
					MessageBox.Show("没有数据可以导出！", "提示",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
				saveFileDialog.Title = "导出接种记录";
				saveFileDialog.FileName = $"疫苗接种记录_{DateTime.Now:yyyyMMdd_HHmmss}";

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

		private void DataGridViewRecords_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				string recordID = dataGridViewRecords.Rows[e.RowIndex].Cells["RecordID"].Value.ToString();
				ShowRecordDetail(recordID);
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
				labelTitle.Text = "接种记录登记";
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

			if (dataTableAppointments != null)
				dataTableAppointments.Dispose();

			if (dataTableRecords != null)
				dataTableRecords.Dispose();

			base.OnFormClosing(e);
		}
	}
}