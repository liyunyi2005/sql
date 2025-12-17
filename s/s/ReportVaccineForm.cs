using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace CommunityHospital
{
    public partial class ReportVaccineForm : Form
    {
        public ReportVaccineForm()
        {
            InitializeComponent();

            // 初始化统计面板
            InitializeStatsPanel();
        }

        private void InitializeStatsPanel()
        {
            // 统计指标
            string[] statTexts = { "疫苗种类：", "接种总人次：", "男性接种：", "女性接种：", "整体接种率：" };
            string[] statValues = { "8种", "1,245人次", "632人", "613人", "85.3%" };

            for (int i = 0; i < 5; i++)
            {
                Label lblStat = new Label();
                lblStat.Text = statTexts[i];
                lblStat.Font = new Font("微软雅黑", 10, FontStyle.Bold);
                lblStat.AutoSize = true;
                lblStat.Location = new Point(20 + i * 170, 30);
                lblStat.ForeColor = Color.FromArgb(102, 102, 102);

                Label lblValue = new Label();
                lblValue.Text = statValues[i];
                lblValue.Font = new Font("微软雅黑", 12, FontStyle.Bold);
                lblValue.AutoSize = true;
                lblValue.Location = new Point(20 + i * 170, 50);
                lblValue.ForeColor = Color.FromArgb(0, 102, 204);

                panelStats.Controls.Add(lblStat);
                panelStats.Controls.Add(lblValue);
            }
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            // 清空现有数据
            dataGridView.Rows.Clear();

            // 模拟查询数据
            DateTime startDate = dtpStart.Value;
            DateTime endDate = dtpEnd.Value;
            string vaccineType = cmbVaccineType.SelectedItem.ToString();

            // 根据选择的疫苗类型过滤数据
            if (vaccineType == "全部疫苗")
            {
                AddAllVaccinesData();
            }
            else if (vaccineType == "新冠疫苗")
            {
                AddCovidVaccineData();
            }
            else if (vaccineType == "流感疫苗")
            {
                AddFluVaccineData();
            }
            else if (vaccineType == "乙肝疫苗")
            {
                AddHepatitisVaccineData();
            }
            else
            {
                AddOtherVaccinesData();
            }

            // 显示查询信息
            MessageBox.Show($"已查询 {startDate:yyyy-MM-dd} 至 {endDate:yyyy-MM-dd} 的数据\n疫苗类型：{vaccineType}",
                "查询完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddAllVaccinesData()
        {
            // 添加所有疫苗数据
            dataGridView.Rows.Add(
                "新冠疫苗（灭活）",
                "科兴生物",
                "450",
                "12",
                "45",
                "280",
                "113",
                "230",
                "220",
                0.85
            );

            dataGridView.Rows.Add(
                "流感疫苗",
                "华兰生物",
                "320",
                "25",
                "38",
                "180",
                "77",
                "155",
                "165",
                0.72
            );

            dataGridView.Rows.Add(
                "乙肝疫苗",
                "深圳康泰",
                "280",
                "48",
                "52",
                "150",
                "30",
                "145",
                "135",
                0.68
            );

            dataGridView.Rows.Add(
                "水痘疫苗",
                "长春祈健",
                "195",
                "85",
                "65",
                "40",
                "5",
                "102",
                "93",
                0.91
            );
        }

        private void AddCovidVaccineData()
        {
            dataGridView.Rows.Add(
                "新冠疫苗（灭活）",
                "科兴生物",
                "450",
                "12",
                "45",
                "280",
                "113",
                "230",
                "220",
                0.85
            );

            dataGridView.Rows.Add(
                "新冠疫苗（重组）",
                "智飞生物",
                "320",
                "18",
                "52",
                "190",
                "60",
                "165",
                "155",
                0.78
            );
        }

        private void AddFluVaccineData()
        {
            dataGridView.Rows.Add(
                "流感疫苗（三价）",
                "华兰生物",
                "220",
                "18",
                "25",
                "120",
                "57",
                "105",
                "115",
                0.68
            );

            dataGridView.Rows.Add(
                "流感疫苗（四价）",
                "长春高新",
                "100",
                "7",
                "13",
                "60",
                "20",
                "50",
                "50",
                0.75
            );
        }

        private void AddHepatitisVaccineData()
        {
            dataGridView.Rows.Add(
                "乙肝疫苗",
                "深圳康泰",
                "280",
                "48",
                "52",
                "150",
                "30",
                "145",
                "135",
                0.68
            );
        }

        private void AddOtherVaccinesData()
        {
            dataGridView.Rows.Add(
                "水痘疫苗",
                "长春祈健",
                "195",
                "85",
                "65",
                "40",
                "5",
                "102",
                "93",
                0.91
            );

            dataGridView.Rows.Add(
                "肺炎疫苗",
                "辉瑞制药",
                "120",
                "35",
                "28",
                "45",
                "12",
                "60",
                "60",
                0.82
            );

            dataGridView.Rows.Add(
                "HPV疫苗",
                "默沙东",
                "180",
                "0",
                "120",
                "60",
                "0",
                "90",
                "90",
                0.88
            );
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel文件|*.xlsx|CSV文件|*.csv";
            saveFileDialog.Title = "导出报表";
            saveFileDialog.FileName = $"疫苗接种统计_{DateTime.Now:yyyyMMddHHmmss}";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                try
                {
                    // 这里可以添加实际的导出逻辑
                    // 例如使用Excel COM组件或第三方库如EPPlus

                    if (fileName.EndsWith(".csv"))
                    {
                        ExportToCSV(fileName);
                    }
                    else
                    {
                        ExportToExcel(fileName);
                    }

                    MessageBox.Show($"报表已成功导出到：{fileName}",
                        "导出成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导出失败：{ex.Message}",
                        "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToCSV(string fileName)
        {
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(fileName, false, System.Text.Encoding.UTF8))
            {
                // 写入标题
                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    sw.Write(dataGridView.Columns[i].HeaderText);
                    if (i < dataGridView.Columns.Count - 1)
                        sw.Write(",");
                }
                sw.WriteLine();

                // 写入数据
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        object cellValue = row.Cells[i].Value;
                        string value = cellValue?.ToString() ?? "";

                        // 处理逗号和引号
                        if (value.Contains(",") || value.Contains("\"") || value.Contains("\n"))
                        {
                            value = "\"" + value.Replace("\"", "\"\"") + "\"";
                        }

                        sw.Write(value);
                        if (i < dataGridView.Columns.Count - 1)
                            sw.Write(",");
                    }
                    sw.WriteLine();
                }
            }
        }

        private void ExportToExcel(string fileName)
        {
            // 这里可以使用EPPlus库来导出Excel
            // 需要先安装EPPlus NuGet包
            MessageBox.Show("Excel导出功能需要安装EPPlus库。\n已导出CSV格式文件。",
                "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            printDoc.PrintPage += (s, ev) =>
            {
                // 绘制报表内容
                Font titleFont = new Font("微软雅黑", 16, FontStyle.Bold);
                Font headerFont = new Font("微软雅黑", 10, FontStyle.Bold);
                Font contentFont = new Font("微软雅黑", 9);

                // 绘制标题
                ev.Graphics.DrawString("疫苗接种统计报表", titleFont, Brushes.Black, 100, 100);

                // 绘制统计时间
                string timeRange = $"统计时间：{dtpStart.Value:yyyy-MM-dd} 至 {dtpEnd.Value:yyyy-MM-dd}";
                ev.Graphics.DrawString(timeRange, headerFont, Brushes.Black, 100, 140);

                // 绘制表格标题
                int yPos = 180;
                int xPos = 100;
                int[] columnWidths = { 150, 120, 80, 60, 60, 80, 80, 60, 60, 80 };

                for (int i = 0; i < dataGridView.Columns.Count; i++)
                {
                    ev.Graphics.DrawString(dataGridView.Columns[i].HeaderText,
                        headerFont, Brushes.Black, xPos, yPos);
                    xPos += columnWidths[i];
                }

                // 绘制表格数据
                yPos = 210;
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    if (row.IsNewRow) continue;

                    xPos = 100;
                    for (int i = 0; i < dataGridView.Columns.Count; i++)
                    {
                        object cellValue = row.Cells[i].Value;
                        string value = cellValue?.ToString() ?? "";
                        ev.Graphics.DrawString(value, contentFont, Brushes.Black, xPos, yPos);
                        xPos += columnWidths[i];
                    }
                    yPos += 25;

                    // 如果超过一页，分页
                    if (yPos > ev.PageBounds.Height - 100)
                    {
                        ev.HasMorePages = true;
                        return;
                    }
                }

                ev.HasMorePages = false;
            };

            printDialog.Document = printDoc;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDoc.Print();
                    MessageBox.Show("报表打印成功！", "打印完成",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"打印失败：{ex.Message}", "错误",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportVaccineForm_Load(object sender, EventArgs e)
        {
            // 窗体加载时自动生成统计
            BtnQuery_Click(null, null);
        }
    }
}