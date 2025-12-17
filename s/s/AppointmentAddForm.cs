using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace CommunityHospital
{
	public partial class AppointmentAddForm : Form
	{
		// 数据库连接和命令对象
		private SqlConnection sqlConnection;
		private SqlCommand sqlCommand;
		private SqlDataAdapter sqlDataAdapter;
		private DataTable dataTableResidents;
		private DataTable dataTableAppointments;

		// 当前选中的居民ID
		private string selectedResidentID = "";
		private string selectedResidentName = "";

		public AppointmentAddForm()
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
				dataTableResidents = new DataTable();
				dataTableAppointments = new DataTable();
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
				// 初始化居民表格
				InitializeResidentsGridView();

				// 初始化预约记录表格
				InitializeAppointmentsGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"数据表格初始化失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void InitializeResidentsGridView()
		{
			// 清空现有列
			dataGridViewResidents.Columns.Clear();

			// 允许点击勾选（Designer 里把整个表设为 ReadOnly=true，这里需要覆盖）
			// 我们只允许编辑“选择”列，其它列保持只读。
			dataGridViewResidents.ReadOnly = false;
			dataGridViewResidents.EditMode = DataGridViewEditMode.EditOnEnter;

			// 添加“选择”列（必须是 CheckBox 列，不能用 Columns.Add 创建 TextBox 列）
			var selectColumn = new DataGridViewCheckBoxColumn
			{
				Name = "Select",
				HeaderText = "选择",
				Width = 60,
				FalseValue = false,
				TrueValue = true
			};
			dataGridViewResidents.Columns.Add(selectColumn);
			dataGridViewResidents.Columns.Add("ResidentID", "档案编号");
			dataGridViewResidents.Columns.Add("Name", "姓名");
			dataGridViewResidents.Columns.Add("Gender", "性别");
			dataGridViewResidents.Columns.Add("Age", "年龄");
			dataGridViewResidents.Columns.Add("IDCard", "身份证号");
			dataGridViewResidents.Columns.Add("Phone", "联系电话");
			dataGridViewResidents.Columns.Add("Community", "所属社区");

			// 除“选择”列外，其它列都只读，避免误编辑
			foreach (DataGridViewColumn col in dataGridViewResidents.Columns)
			{
				col.ReadOnly = col.Name != "Select";
				col.SortMode = DataGridViewColumnSortMode.NotSortable;
			}

			// 设置列宽
			dataGridViewResidents.Columns["ResidentID"].Width = 100;
			dataGridViewResidents.Columns["Name"].Width = 80;
			dataGridViewResidents.Columns["Gender"].Width = 60;
			dataGridViewResidents.Columns["Age"].Width = 60;
			dataGridViewResidents.Columns["IDCard"].Width = 180;
			dataGridViewResidents.Columns["Phone"].Width = 120;
			dataGridViewResidents.Columns["Community"].Width = 120;

			// 设置列对齐方式
			dataGridViewResidents.Columns["Select"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewResidents.Columns["Gender"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewResidents.Columns["Age"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			// 让勾选框点击后立即提交值（否则要离开单元格才会更新）
			dataGridViewResidents.CurrentCellDirtyStateChanged -= DataGridViewResidents_CurrentCellDirtyStateChanged;
			dataGridViewResidents.CurrentCellDirtyStateChanged += DataGridViewResidents_CurrentCellDirtyStateChanged;
			dataGridViewResidents.CellContentClick -= DataGridViewResidents_CellContentClick;
			dataGridViewResidents.CellContentClick += DataGridViewResidents_CellContentClick;
			dataGridViewResidents.CellClick -= DataGridViewResidents_CellClick;
			dataGridViewResidents.CellClick += DataGridViewResidents_CellClick;
		}

		private void DataGridViewResidents_CurrentCellDirtyStateChanged(object sender, EventArgs e)
		{
			if (dataGridViewResidents.IsCurrentCellDirty)
			{
				dataGridViewResidents.CommitEdit(DataGridViewDataErrorContexts.Commit);
			}
		}

		private void DataGridViewResidents_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
			if (dataGridViewResidents.Columns[e.ColumnIndex].Name == "Select")
			{
				SetSelectedResidentRow(e.RowIndex);
			}
		}

		private void DataGridViewResidents_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
			// 点击任意单元格都视为选择该居民
			SetSelectedResidentRow(e.RowIndex);
		}

		private void SetSelectedResidentRow(int rowIndex)
		{
			if (rowIndex < 0 || rowIndex >= dataGridViewResidents.Rows.Count) return;

			for (int i = 0; i < dataGridViewResidents.Rows.Count; i++)
			{
				var row = dataGridViewResidents.Rows[i];
				row.Cells["Select"].Value = (i == rowIndex);
			}

			var selectedRow = dataGridViewResidents.Rows[rowIndex];
			selectedResidentID = selectedRow.Cells["ResidentID"].Value?.ToString() ?? "";
			selectedResidentName = selectedRow.Cells["Name"].Value?.ToString() ?? "";
		}

		private void InitializeAppointmentsGridView()
		{
			try
			{
				// 清空现有列
				dataGridViewAppointments.Columns.Clear();

				// 添加列
				dataGridViewAppointments.Columns.Add("AppointmentID", "预约编号");
				dataGridViewAppointments.Columns.Add("ResidentName", "居民姓名");
				dataGridViewAppointments.Columns.Add("VaccineName", "疫苗名称");
				dataGridViewAppointments.Columns.Add("AppointmentDate", "预约日期");
				dataGridViewAppointments.Columns.Add("TimeSlot", "预约时段");
				dataGridViewAppointments.Columns.Add("DoseNumber", "接种剂次");
				dataGridViewAppointments.Columns.Add("Hospital", "接种医院");
				dataGridViewAppointments.Columns.Add("Status", "预约状态");
				dataGridViewAppointments.Columns.Add("CreateTime", "创建时间");

				// 设置列宽
				dataGridViewAppointments.Columns["AppointmentID"].Width = 120;
				dataGridViewAppointments.Columns["ResidentName"].Width = 100;
				dataGridViewAppointments.Columns["VaccineName"].Width = 120;
				dataGridViewAppointments.Columns["AppointmentDate"].Width = 100;
				dataGridViewAppointments.Columns["TimeSlot"].Width = 100;
				dataGridViewAppointments.Columns["DoseNumber"].Width = 80;
				dataGridViewAppointments.Columns["Hospital"].Width = 120;
				dataGridViewAppointments.Columns["Status"].Width = 80;
				dataGridViewAppointments.Columns["CreateTime"].Width = 150;

				// 设置列对齐方式
				dataGridViewAppointments.Columns["DoseNumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
				dataGridViewAppointments.Columns["Status"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				// 设置日期格式
				dataGridViewAppointments.Columns["AppointmentDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
				dataGridViewAppointments.Columns["CreateTime"].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"预约记录表格初始化失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadInitialData()
		{
			try
			{
				// 设置默认值
				comboVaccineName.SelectedIndex = 0;
				comboVaccineType.SelectedIndex = 0;
				comboTimeSlot.SelectedIndex = 0;
				comboDoseNumber.SelectedIndex = 0;
				comboHospital.SelectedIndex = 0;
				comboClinic.SelectedIndex = 0;
				comboDoctor.SelectedIndex = 0;

				// 设置预约日期为明天
				dateTimeAppointment.Value = DateTime.Today.AddDays(1);
				dateTimeAppointment.MinDate = DateTime.Today;

				// 加载居民列表
				LoadResidents("");

				// 加载预约记录
				LoadAppointmentHistory();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"初始化数据失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void AppointmentAddForm_Load(object sender, EventArgs e)
		{
			// 窗体加载完成
		}

		private void LoadResidents(string searchText)
		{
			try
			{
				// 构建查询语句
				string query = @"
                    SELECT 
                        ResidentID, Name, Gender, 
                        DATEDIFF(YEAR, BirthDate, GETDATE()) as Age,
                        IDCard, Phone, Community
                    FROM Residents 
                    WHERE Status = '正常'";

				if (!string.IsNullOrWhiteSpace(searchText))
				{
					query += $" AND (Name LIKE '%{searchText}%' OR IDCard LIKE '%{searchText}%' OR Phone LIKE '%{searchText}%')";
				}

				query += " ORDER BY Name";

				// 执行查询
				sqlCommand.CommandText = query;
				dataTableResidents.Clear();

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				sqlDataAdapter.Fill(dataTableResidents);

				sqlConnection.Close();

				// 绑定数据到DataGridView
				BindResidentsToGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"加载居民列表失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BindResidentsToGridView()
		{
			try
			{
				dataGridViewResidents.Rows.Clear();

				foreach (DataRow row in dataTableResidents.Rows)
				{
					// 计算年龄
					int age = 0;
					if (row["Age"] != DBNull.Value)
					{
						age = Convert.ToInt32(row["Age"]);
					}

					// 格式化身份证号（隐私保护）
					string idCard = FormatIDCard(row["IDCard"].ToString());

					// 添加行数据
					int rowIndex = dataGridViewResidents.Rows.Add(
						false,  // 选择框
						row["ResidentID"].ToString(),
						row["Name"].ToString(),
						row["Gender"].ToString(),
						age.ToString(),
						idCard,
						row["Phone"].ToString(),
						row["Community"].ToString()
					);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"居民数据绑定失败：{ex.Message}", "错误",
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

		private void LoadAppointmentHistory()
		{
			try
			{
				// 查询预约记录
				string query = @"
                    SELECT 
                        a.AppointmentID,
                        r.Name as ResidentName,
                        a.VaccineName,
                        CONVERT(varchar(10), a.AppointmentDate, 120) as AppointmentDate,
                        a.TimeSlot,
                        a.DoseNumber,
                        a.Hospital,
                        a.Status,
                        CONVERT(varchar(16), a.CreateTime, 120) as CreateTime
                    FROM Appointments a
                    JOIN Residents r ON a.ResidentID = r.ResidentID
                    WHERE a.AppointmentDate >= DATEADD(DAY, -30, GETDATE())
                    ORDER BY a.AppointmentDate DESC, a.CreateTime DESC";

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
						row["AppointmentID"].ToString(),
						row["ResidentName"].ToString(),
						row["VaccineName"].ToString(),
						row["AppointmentDate"].ToString(),
						row["TimeSlot"].ToString(),
						row["DoseNumber"].ToString(),
						row["Hospital"].ToString(),
						row["Status"].ToString(),
						row["CreateTime"].ToString()
					);

					// 根据状态设置行颜色
					DataGridViewRow gridRow = dataGridViewAppointments.Rows[rowIndex];
					string status = row["Status"].ToString();

					if (status == "已取消")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightGray;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkGray;
					}
					else if (status == "已完成")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightGreen;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkGreen;
					}
					else if (status == "待审核")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightYellow;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkOrange;
					}
					else if (status == "已审核")
					{
						gridRow.DefaultCellStyle.BackColor = Color.LightSkyBlue;
						gridRow.DefaultCellStyle.ForeColor = Color.DarkBlue;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"预约记录绑定失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void TxtResidentSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter)
			{
				BtnSearchResident_Click(sender, e);
				e.Handled = true;
			}
		}

		private void BtnSearchResident_Click(object sender, EventArgs e)
		{
			LoadResidents(txtResidentSearch.Text.Trim());
		}

		private void BtnNewResident_Click(object sender, EventArgs e)
		{
			// 打开新建居民档案窗口
			// ResidentAddForm addForm = new ResidentAddForm();
			// addForm.ShowDialog();

			// 刷新居民列表
			LoadResidents("");
		}

		private void DataGridViewResidents_SelectionChanged(object sender, EventArgs e)
		{
			// 兼容：如果用户通过“行选择”改变选中行，也同步勾选框与选中居民
			if (dataGridViewResidents.CurrentRow != null && dataGridViewResidents.CurrentRow.Index >= 0)
			{
				SetSelectedResidentRow(dataGridViewResidents.CurrentRow.Index);
			}
		}

		private void ComboVaccineName_SelectedIndexChanged(object sender, EventArgs e)
		{
			// 根据疫苗名称自动设置疫苗类型
			string vaccineName = comboVaccineName.Text;

			if (vaccineName.Contains("新冠疫苗"))
			{
				comboVaccineType.Items.Clear();
				comboVaccineType.Items.AddRange(new object[] { "第一针", "第二针", "第三针", "加强针" });
				comboVaccineType.SelectedIndex = 0;
			}
			else if (vaccineName.Contains("流感疫苗"))
			{
				comboVaccineType.Items.Clear();
				comboVaccineType.Items.AddRange(new object[] { "年度接种" });
				comboVaccineType.SelectedIndex = 0;
			}
			else
			{
				comboVaccineType.Items.Clear();
				comboVaccineType.Items.AddRange(new object[] { "第一针", "第二针", "第三针", "加强针", "年度接种" });
				comboVaccineType.SelectedIndex = 0;
			}
		}

		private void BtnSubmit_Click(object sender, EventArgs e)
		{
			SubmitAppointment();
		}

		private void SubmitAppointment()
		{
			try
			{
				// 验证输入
				if (!ValidateAppointment())
					return;

				// 生成预约编号
				string appointmentID = GenerateAppointmentID();

				// 构建插入语句
				string query = @"
                    INSERT INTO Appointments (
                        AppointmentID, ResidentID, VaccineName, VaccineType,
                        AppointmentDate, TimeSlot, DoseNumber, Hospital,
                        Clinic, Doctor, Remark, Status, CreateTime, Operator
                    ) VALUES (
                        @AppointmentID, @ResidentID, @VaccineName, @VaccineType,
                        @AppointmentDate, @TimeSlot, @DoseNumber, @Hospital,
                        @Clinic, @Doctor, @Remark, @Status, @CreateTime, @Operator
                    )";

				// 设置命令参数
				sqlCommand.CommandText = query;
				sqlCommand.Parameters.Clear();

				sqlCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);
				sqlCommand.Parameters.AddWithValue("@ResidentID", selectedResidentID);
				sqlCommand.Parameters.AddWithValue("@VaccineName", comboVaccineName.Text);
				sqlCommand.Parameters.AddWithValue("@VaccineType", comboVaccineType.Text);
				sqlCommand.Parameters.AddWithValue("@AppointmentDate", dateTimeAppointment.Value.Date);
				sqlCommand.Parameters.AddWithValue("@TimeSlot", comboTimeSlot.Text);
				sqlCommand.Parameters.AddWithValue("@DoseNumber", comboDoseNumber.Text);
				sqlCommand.Parameters.AddWithValue("@Hospital", comboHospital.Text);
				sqlCommand.Parameters.AddWithValue("@Clinic", comboClinic.Text);
				sqlCommand.Parameters.AddWithValue("@Doctor", comboDoctor.Text);
				sqlCommand.Parameters.AddWithValue("@Remark", txtRemark.Text.Trim());
				sqlCommand.Parameters.AddWithValue("@Status", "待审核");
				sqlCommand.Parameters.AddWithValue("@CreateTime", DateTime.Now);
				sqlCommand.Parameters.AddWithValue("@Operator", LoginForm.GlobalSettings.CurrentUser);

				// 执行插入
				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				int rowsAffected = sqlCommand.ExecuteNonQuery();

				sqlConnection.Close();

				if (rowsAffected > 0)
				{
					MessageBox.Show("预约提交成功！请等待审核。", "成功",
						MessageBoxButtons.OK, MessageBoxIcon.Information);

					// 重置表单
					BtnReset_Click(null, null);

					// 刷新预约记录
					LoadAppointmentHistory();

					// 切换到预约记录页
					tabControlMain.SelectedIndex = 1;
				}
				else
				{
					MessageBox.Show("预约提交失败，请重试！", "错误",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"提交预约失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private bool ValidateAppointment()
		{
			// 验证居民选择
			if (string.IsNullOrEmpty(selectedResidentID))
			{
				MessageBox.Show("请选择预约的居民！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}

			// 验证疫苗名称
			if (string.IsNullOrWhiteSpace(comboVaccineName.Text))
			{
				MessageBox.Show("请选择疫苗名称！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboVaccineName.Focus();
				return false;
			}

			// 验证疫苗类型
			if (string.IsNullOrWhiteSpace(comboVaccineType.Text))
			{
				MessageBox.Show("请选择疫苗类型！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboVaccineType.Focus();
				return false;
			}

			// 验证预约日期
			if (dateTimeAppointment.Value < DateTime.Today)
			{
				MessageBox.Show("预约日期不能早于今天！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				dateTimeAppointment.Focus();
				return false;
			}

			// 验证预约时段
			if (string.IsNullOrWhiteSpace(comboTimeSlot.Text))
			{
				MessageBox.Show("请选择预约时段！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboTimeSlot.Focus();
				return false;
			}

			// 验证接种剂次
			if (string.IsNullOrWhiteSpace(comboDoseNumber.Text))
			{
				MessageBox.Show("请选择接种剂次！", "验证错误",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				comboDoseNumber.Focus();
				return false;
			}

			return true;
		}

		private string GenerateAppointmentID()
		{
			// 生成预约编号：AP20241224001
			string prefix = "AP" + DateTime.Now.ToString("yyyyMMdd");

			// 查询当日最大编号
			string query = $"SELECT MAX(AppointmentID) FROM Appointments WHERE AppointmentID LIKE '{prefix}%'";

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
			// 重置居民选择
			foreach (DataGridViewRow row in dataGridViewResidents.Rows)
			{
				row.Cells["Select"].Value = false;
			}

			selectedResidentID = "";
			selectedResidentName = "";

			// 重置预约信息
			comboVaccineName.SelectedIndex = 0;
			comboVaccineType.SelectedIndex = 0;
			dateTimeAppointment.Value = DateTime.Today.AddDays(1);
			comboTimeSlot.SelectedIndex = 0;
			comboDoseNumber.SelectedIndex = 0;
			comboHospital.SelectedIndex = 0;
			comboClinic.SelectedIndex = 0;
			comboDoctor.SelectedIndex = 0;
			txtRemark.Text = "请携带身份证件和健康码";

			txtResidentSearch.Clear();
			txtResidentSearch.Focus();
		}

		private void BtnPrintVoucher_Click(object sender, EventArgs e)
		{
			PrintAppointmentVoucher();
		}

		private void PrintAppointmentVoucher()
		{
			try
			{
				// 验证是否有选中的居民
				if (string.IsNullOrEmpty(selectedResidentID))
				{
					MessageBox.Show("请先选择预约的居民！", "提示",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				// 验证预约信息是否完整
				if (!ValidateAppointment())
					return;

				// 构建预约凭证内容
				StringBuilder voucher = new StringBuilder();
				voucher.AppendLine("疫苗接种预约凭证");
				voucher.AppendLine("================================");
				voucher.AppendLine($"预约编号：{GenerateAppointmentID()}");
				voucher.AppendLine($"居民姓名：{selectedResidentName}");
				voucher.AppendLine($"疫苗名称：{comboVaccineName.Text}");
				voucher.AppendLine($"疫苗类型：{comboVaccineType.Text}");
				voucher.AppendLine($"预约日期：{dateTimeAppointment.Value:yyyy年MM月dd日}");
				voucher.AppendLine($"预约时段：{comboTimeSlot.Text}");
				voucher.AppendLine($"接种剂次：{comboDoseNumber.Text}");
				voucher.AppendLine($"接种医院：{comboHospital.Text}");
				voucher.AppendLine($"接种科室：{comboClinic.Text}");
				voucher.AppendLine($"接种医生：{comboDoctor.Text}");
				voucher.AppendLine($"备　　注：{txtRemark.Text}");
				voucher.AppendLine("================================");
				voucher.AppendLine("温馨提示：");
				voucher.AppendLine("1. 请携带身份证件和健康码");
				voucher.AppendLine("2. 请提前10分钟到达接种点");
				voucher.AppendLine("3. 如有发热等症状请取消预约");
				voucher.AppendLine("4. 接种后需留观30分钟");
				voucher.AppendLine($"打印时间：{DateTime.Now:yyyy-MM-dd HH:mm}");

				// 显示预约凭证
				MessageBox.Show(voucher.ToString(), "预约凭证",
					MessageBoxButtons.OK, MessageBoxIcon.Information);

				// 这里可以添加实际打印功能
				// PrintDocument printDoc = new PrintDocument();
				// printDoc.PrintPage += PrintVoucherPage;
				// printDoc.Print();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"打印凭证失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnRefreshHistory_Click(object sender, EventArgs e)
		{
			LoadAppointmentHistory();
		}

		private void BtnCancelAppointment_Click(object sender, EventArgs e)
		{
			CancelAppointment();
		}

		private void CancelAppointment()
		{
			if (dataGridViewAppointments.SelectedRows.Count == 0)
			{
				MessageBox.Show("请选择要取消的预约记录！", "提示",
					MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			try
			{
				string appointmentID = dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value.ToString();
				string residentName = dataGridViewAppointments.SelectedRows[0].Cells["ResidentName"].Value.ToString();
				string status = dataGridViewAppointments.SelectedRows[0].Cells["Status"].Value.ToString();

				// 检查预约状态
				if (status == "已取消" || status == "已完成")
				{
					MessageBox.Show($"该预约已{status}，不能取消！", "提示",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				DialogResult result = MessageBox.Show($"确定要取消居民【{residentName}】的预约吗？",
					"取消预约确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
					// 更新预约状态为已取消
					string updateQuery = $"UPDATE Appointments SET Status = '已取消', CancelTime = GETDATE() WHERE AppointmentID = '{appointmentID}'";

					sqlCommand.CommandText = updateQuery;

					if (sqlConnection.State != ConnectionState.Open)
						sqlConnection.Open();

					int rowsAffected = sqlCommand.ExecuteNonQuery();

					sqlConnection.Close();

					if (rowsAffected > 0)
					{
						MessageBox.Show("预约取消成功！", "成功",
							MessageBoxButtons.OK, MessageBoxIcon.Information);

						// 刷新预约记录
						LoadAppointmentHistory();
					}
					else
					{
						MessageBox.Show("取消失败，请重试！", "错误",
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"取消预约失败：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void BtnExportHistory_Click(object sender, EventArgs e)
		{
			ExportAppointmentHistory();
		}

		private void ExportAppointmentHistory()
		{
			try
			{
				if (dataGridViewAppointments.RowCount == 0)
				{
					MessageBox.Show("没有数据可以导出！", "提示",
						MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				SaveFileDialog saveFileDialog = new SaveFileDialog();
				saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
				saveFileDialog.Title = "导出预约记录";
				saveFileDialog.FileName = $"疫苗接种预约记录_{DateTime.Now:yyyyMMdd_HHmmss}";

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

		private void DataGridViewAppointments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
			{
				ShowAppointmentDetail();
			}
		}

		private void ShowAppointmentDetail()
		{
			if (dataGridViewAppointments.SelectedRows.Count == 0)
				return;

			try
			{
				string appointmentID = dataGridViewAppointments.SelectedRows[0].Cells["AppointmentID"].Value.ToString();

				// 查询预约详细信息
				string query = @"
                    SELECT 
                        a.*,
                        r.Name as ResidentName,
                        r.IDCard,
                        r.Phone,
                        r.AllergyHistory
                    FROM Appointments a
                    JOIN Residents r ON a.ResidentID = r.ResidentID
                    WHERE a.AppointmentID = @AppointmentID";

				sqlCommand.CommandText = query;
				sqlCommand.Parameters.Clear();
				sqlCommand.Parameters.AddWithValue("@AppointmentID", appointmentID);

				if (sqlConnection.State != ConnectionState.Open)
					sqlConnection.Open();

				using (SqlDataReader reader = sqlCommand.ExecuteReader())
				{
					if (reader.Read())
					{
						StringBuilder detail = new StringBuilder();
						detail.AppendLine($"预约编号：{reader["AppointmentID"]}");
						detail.AppendLine($"居民姓名：{reader["ResidentName"]}");
						detail.AppendLine($"身份证号：{reader["IDCard"]}");
						detail.AppendLine($"联系电话：{reader["Phone"]}");
						detail.AppendLine($"过敏历史：{reader["AllergyHistory"]}");
						detail.AppendLine($"疫苗名称：{reader["VaccineName"]}");
						detail.AppendLine($"疫苗类型：{reader["VaccineType"]}");
						detail.AppendLine($"预约日期：{Convert.ToDateTime(reader["AppointmentDate"]):yyyy-MM-dd}");
						detail.AppendLine($"预约时段：{reader["TimeSlot"]}");
						detail.AppendLine($"接种剂次：{reader["DoseNumber"]}");
						detail.AppendLine($"接种医院：{reader["Hospital"]}");
						detail.AppendLine($"接种科室：{reader["Clinic"]}");
						detail.AppendLine($"接种医生：{reader["Doctor"]}");
						detail.AppendLine($"备　　注：{reader["Remark"]}");
						detail.AppendLine($"预约状态：{reader["Status"]}");
						detail.AppendLine($"创建时间：{Convert.ToDateTime(reader["CreateTime"]):yyyy-MM-dd HH:mm}");
						detail.AppendLine($"操作人员：{reader["Operator"]}");

						if (reader["CancelTime"] != DBNull.Value)
						{
							detail.AppendLine($"取消时间：{Convert.ToDateTime(reader["CancelTime"]):yyyy-MM-dd HH:mm}");
						}

						MessageBox.Show(detail.ToString(), "预约记录详情",
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
				labelTitle.Text = "疫苗接种预约";
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

			if (dataTableAppointments != null)
				dataTableAppointments.Dispose();

			base.OnFormClosing(e);
		}
	}
}