using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommunityHospital
{
	public partial class MainForm : Form
	{
		private Panel panelContentHost;
		private Form activeContentForm;

		public MainForm()
		{
			InitializeComponent();
			InitializeForm();
		}

		private void InitializeForm()
		{
			// 设置窗体属性
			this.Text = $"社区医院疫苗接种管理系统 - 主界面 [{LoginForm.GlobalSettings.CurrentUser}]";

			// 初始化状态栏信息
			UpdateStatusBar();

			// 初始化内容承载面板（用于“切换界面”显示各功能窗体）
			EnsureContentHost();
			EnsureHomeMenuItem();
		}

		private void EnsureContentHost()
		{
			if (panelContentHost != null)
				return;

			panelContentHost = new Panel
			{
				Name = "panelContentHost",
				Dock = DockStyle.Fill,
				BackColor = Color.White,
				Visible = false
			};

			// 放到 toolStripContainer 的 ContentPanel 里，和 panelMain 同级
			toolStripContainer.ContentPanel.Controls.Add(panelContentHost);
			panelContentHost.BringToFront();
		}

		private void EnsureHomeMenuItem()
		{
			// 在“文件”菜单里加一个“返回主页”，避免用户进入子界面后无法返回
			foreach (ToolStripItem item in 文件ToolStripMenuItem.DropDownItems)
			{
				if (item is ToolStripMenuItem mi && mi.Name == "返回主页ToolStripMenuItem")
					return;
			}

			var homeItem = new ToolStripMenuItem
			{
				Name = "返回主页ToolStripMenuItem",
				Text = "返回主页"
			};
			homeItem.Click += (s, e) => ShowHome();

			// 插到“退出系统”前面（更顺手）
			int insertIndex = Math.Max(0, 文件ToolStripMenuItem.DropDownItems.IndexOf(退出系统ToolStripMenuItem));
			文件ToolStripMenuItem.DropDownItems.Insert(insertIndex, homeItem);
		}

		private void UpdateStatusBar()
		{
			// 设置用户信息
			toolStripStatusLabelUser.Text = $"用户：{LoginForm.GlobalSettings.CurrentUser}";

			// 设置时间
			timerClock_Tick(null, null);

			// 设置系统状态
			toolStripStatusLabelStatus.Text = "系统正常";

			// 设置版本信息
			toolStripStatusLabelVersion.Text = "版本：v1.0.0";
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			// 窗体加载时的动画效果
			this.Opacity = 0;
			Timer fadeInTimer = new Timer();
			fadeInTimer.Interval = 10;
			fadeInTimer.Tick += (s, ev) =>
			{
				if (this.Opacity < 1)
					this.Opacity += 0.05;
				else
					fadeInTimer.Stop();
			};
			fadeInTimer.Start();

			// 加载统计数据
			LoadStatistics();
		}

		private void LoadStatistics()
		{
			// 这里应该从数据库加载实时统计数据
			// 模拟数据
			labelStat1Value.Text = "1,245";  // 居民总数
			labelStat2Value.Text = "856";   // 本月接种人次
			labelStat3Value.Text = "23";    // 待审核预约
			labelStat4Value.Text = "156";   // 库存预警数
		}

		// 时钟定时器
		private void timerClock_Tick(object sender, EventArgs e)
		{
			toolStripStatusLabelTime.Text = $"时间：{DateTime.Now:yyyy-MM-dd HH:mm:ss}";
		}

		#region 菜单事件处理

		// 文件菜单
		private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("确定要退出系统吗？", "退出确认",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		// 居民档案管理菜单
		private void 新建档案ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new ResidentAddForm());
		}

		private void 档案查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenForm(new ResidentQueryForm());
		}

		private void 档案维护ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new ResidentEditForm());
		}

		private void 档案统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开档案统计功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// 疫苗管理菜单
		private void 疫苗入库ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenForm(new VaccineStockForm());
		}

		private void 库存查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new VaccineQueryForm());
		}

		private void 过期提醒ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new VaccineExpireForm());
		}

		private void 库存盘点ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开库存盘点功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// 预约管理菜单
		private void 新建预约ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenForm(new AppointmentAddForm());
		}

		private void 审核预约ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new AppointmentReviewForm());
		}

		private void 预约查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new AppointmentQueryForm());
		}

		private void 预约统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开预约统计功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// 接种记录菜单
		private void 登记接种ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenForm(new RecordAddForm());
		}

		private void 记录查询ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new RecordQueryForm());
		}

		private void 记录维护ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//OpenForm(new RecordEditForm());
		}

		private void 接种统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开接种统计功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// 统计报表菜单
		private void 疫苗接种统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenForm(new ReportVaccineForm());
		}

		private void 年龄段统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// OpenForm(new ReportAgeForm());
		}

		private void 库存统计ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//OpenForm(new ReportInventoryForm());
		}

		private void 防疫报表ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开防疫报表功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		// 系统管理菜单
		private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开用户管理功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void 角色权限ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开角色权限功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void 系统设置ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开系统设置功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void 操作日志ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("打开操作日志功能", "提示",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void 关于系统ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("社区医院疫苗接种管理系统\n版本：v1.0.0\n© 2024 版权所有",
				"关于系统", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		#endregion

		#region 工具栏事件处理

		private void toolStripButtonNewResident_Click(object sender, EventArgs e)
		{
			//OpenForm(new ResidentAddForm());
		}

		private void toolStripButtonQueryResident_Click(object sender, EventArgs e)
		{
			OpenForm(new ResidentQueryForm());
		}

		private void toolStripButtonStockIn_Click(object sender, EventArgs e)
		{
			OpenForm(new VaccineStockForm());
		}

		private void toolStripButtonInventory_Click(object sender, EventArgs e)
		{
			//OpenForm(new VaccineQueryForm());
		}

		private void toolStripButtonNewAppointment_Click(object sender, EventArgs e)
		{
			OpenForm(new AppointmentAddForm());
		}

		private void toolStripButtonAppointmentReview_Click(object sender, EventArgs e)
		{
			//OpenForm(new AppointmentReviewForm());
		}

		private void toolStripButtonVaccinationRecord_Click(object sender, EventArgs e)
		{
			OpenForm(new RecordAddForm());
		}

		private void toolStripButtonQueryRecord_Click(object sender, EventArgs e)
		{
			//OpenForm(new RecordQueryForm());
		}

		private void toolStripButtonReports_Click(object sender, EventArgs e)
		{
			OpenForm(new ReportVaccineForm());
		}

		#endregion

		#region 快捷操作按钮事件处理

		private void buttonQuickResident_Click(object sender, EventArgs e)
		{
			OpenForm(new ResidentQueryForm());
		}

		private void buttonQuickVaccine_Click(object sender, EventArgs e)
		{
			OpenForm(new VaccineStockForm());
		}

		private void buttonQuickAppointment_Click(object sender, EventArgs e)
		{
			OpenForm(new AppointmentAddForm());
		}

		private void buttonQuickRecord_Click(object sender, EventArgs e)
		{
			OpenForm(new RecordAddForm());
		}

		private void buttonQuickReport_Click(object sender, EventArgs e)
		{
			OpenForm(new ReportVaccineForm());
		}

		#endregion

		#region 辅助方法

		private void ShowHome()
		{
			try
			{
				if (activeContentForm != null)
				{
					// 关闭当前内容窗体，回到主页
					var closing = activeContentForm;
					activeContentForm = null;
					closing.Close();
					closing.Dispose();
				}

				if (panelContentHost != null)
				{
					panelContentHost.Controls.Clear();
					panelContentHost.Visible = false;
				}

				panelMain.Visible = true;
				panelMain.BringToFront();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"返回主页时出错：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void OpenForm(Form form)
		{
			try
			{
				EnsureContentHost();

				// 清理上一个界面
				if (activeContentForm != null)
				{
					var old = activeContentForm;
					activeContentForm = null;
					old.Close();
					old.Dispose();
				}

				// 隐藏主页面板，显示内容面板
				panelMain.Visible = false;
				panelContentHost.Visible = true;
				panelContentHost.BringToFront();
				panelContentHost.Controls.Clear();

				// 将窗体嵌入到内容面板中显示
				form.TopLevel = false;
				form.FormBorderStyle = FormBorderStyle.None;
				form.Dock = DockStyle.Fill;
				form.WindowState = FormWindowState.Normal;

				activeContentForm = form;
				form.FormClosed += (s, e) =>
				{
					if (ReferenceEquals(activeContentForm, form))
						activeContentForm = null;

					// 关闭子界面后自动回到主页
					if (panelContentHost != null)
					{
						panelContentHost.Controls.Clear();
						panelContentHost.Visible = false;
					}

					panelMain.Visible = true;
					panelMain.BringToFront();
				};

				panelContentHost.Controls.Add(form);
				form.Show();
				form.BringToFront();
			}
			catch (Exception ex)
			{
				MessageBox.Show($"打开窗体时出错：{ex.Message}", "错误",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LogActivity(string activity)
		{
			// 记录活动到最近活动列表
			string timestamp = DateTime.Now.ToString("HH:mm");
			listBoxRecentActivity.Items.Insert(0, $"{timestamp} - {activity}");

			// 保持最近活动列表最多10条
			if (listBoxRecentActivity.Items.Count > 10)
			{
				listBoxRecentActivity.Items.RemoveAt(10);
			}
		}

		#endregion
	}
}