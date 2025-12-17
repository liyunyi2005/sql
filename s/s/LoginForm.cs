using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CommunityHospital
{
	public partial class LoginForm : Form
	{
		// 用于窗体拖动的变量
		private bool isDragging = false;
		private Point startPoint = Point.Empty;

		public LoginForm()
		{
			InitializeComponent();
			InitializeCustomEvents();
			ApplyPlaceholderText();
		}

		private void InitializeCustomEvents()
		{
			// 设置文本框焦点事件
			txtUsername.Enter += (s, e) => {
				if (txtUsername.Text == "用户名")
				{
					txtUsername.Text = "";
					txtUsername.ForeColor = Color.Black;
					lblUsername.Visible = false;
				}
			};

			txtUsername.Leave += (s, e) => {
				if (string.IsNullOrWhiteSpace(txtUsername.Text))
				{
					txtUsername.Text = "用户名";
					txtUsername.ForeColor = Color.Gray;
					lblUsername.Visible = true;
				}
			};

			txtPassword.Enter += (s, e) => {
				lblPassword.Visible = false;
			};

			txtPassword.Leave += (s, e) => {
				if (string.IsNullOrWhiteSpace(txtPassword.Text))
				{
					lblPassword.Visible = true;
				}
			};
		}

		private void ApplyPlaceholderText()
		{
			// 初始设置
			txtUsername.ForeColor = Color.Gray;
			txtPassword.ForeColor = Color.Black;
		}

		private void BtnLogin_Click(object sender, EventArgs e)
		{
			string username = txtUsername.Text.Trim();
			string password = txtPassword.Text;

			// 验证输入
			if (username == "用户名" || string.IsNullOrWhiteSpace(username))
			{
				ShowErrorMessage("请输入用户名！");
				txtUsername.Focus();
				return;
			}

			if (string.IsNullOrWhiteSpace(password))
			{
				ShowErrorMessage("请输入密码！");
				txtPassword.Focus();
				return;
			}

			// 模拟登录验证（实际应连接数据库）
			if (ValidateLogin(username, password))
			{
				ShowSuccessMessage("登录成功！");

				// 保存用户信息到全局变量或配置文件
				GlobalSettings.CurrentUser = username;
				GlobalSettings.LoginTime = DateTime.Now;

				this.Hide();
				MainForm mainForm = new MainForm();
				mainForm.Show();
			}
			else
			{
				ShowErrorMessage("用户名或密码错误！");
				txtPassword.SelectAll();
				txtPassword.Focus();
			}
		}

		private bool ValidateLogin(string username, string password)
		{
			// 这里应该连接数据库进行验证
			// 模拟数据
			if (username == "admin" && password == "123456")
				return true;
			if (username == "doctor" && password == "123456")
				return true;
			if (username == "nurse" && password == "123456")
				return true;

			return false;
		}

		private void BtnCancel_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("确定要退出系统吗？", "退出确认",
				MessageBoxButtons.YesNo, MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				Application.Exit();
			}
		}

		private void BtnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void BtnMinimize_Click(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}

		// 窗体拖动功能
		private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				isDragging = true;
				startPoint = new Point(e.X, e.Y);
			}
		}

		private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
		{
			if (isDragging)
			{
				Point newPoint = this.PointToScreen(new Point(e.X, e.Y));
				newPoint.Offset(-startPoint.X, -startPoint.Y);
				this.Location = newPoint;
			}
		}

		private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
		{
			isDragging = false;
		}

		// 键盘快捷键支持
		private void TxtUsername_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				txtPassword.Focus();
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		private void TxtPassword_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				BtnLogin_Click(sender, e);
				e.Handled = true;
				e.SuppressKeyPress = true;
			}
		}

		// 自定义消息显示方法
		private void ShowErrorMessage(string message)
		{
			lblTitle.ForeColor = Color.Red;
			lblTitle.Text = message;

			// 2秒后恢复原文本
			Timer timer = new Timer();
			timer.Interval = 2000;
			timer.Tick += (s, e) => {
				lblTitle.Text = "用户登录";
				lblTitle.ForeColor = Color.FromArgb(0, 102, 204);
				timer.Stop();
				timer.Dispose();
			};
			timer.Start();
		}

		private void ShowSuccessMessage(string message)
		{
			lblTitle.ForeColor = Color.Green;
			lblTitle.Text = message;
		}

		private void LoginForm_Load(object sender, EventArgs e)
		{
			// 窗体加载时的动画效果
			this.Opacity = 0;
			Timer fadeInTimer = new Timer();
			fadeInTimer.Interval = 10;
			fadeInTimer.Tick += (s, ev) => {
				if (this.Opacity < 1)
					this.Opacity += 0.05;
				else
					fadeInTimer.Stop();
			};
			fadeInTimer.Start();

			// 设置默认焦点
			if (txtUsername.Text == "用户名")
			{
				txtUsername.Focus();
			}
			else
			{
				txtPassword.Focus();
			}
		}

		// 添加一些静态工具类用于全局设置
		public static class GlobalSettings
		{
			public static string CurrentUser { get; set; }
			public static DateTime LoginTime { get; set; }
			public static string UserRole { get; set; }
		}
	}
}