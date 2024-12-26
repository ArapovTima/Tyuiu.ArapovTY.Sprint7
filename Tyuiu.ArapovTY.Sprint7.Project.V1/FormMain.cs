using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ArapovTY.Sprint7.Project.V1.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.DataFormats;
namespace Tyuiu.ArapovTY.Sprint7.Project.V1
{
    public partial class FormMainLoad_ATY : Form
    {
        public FormMainLoad_ATY()
        {
            InitializeComponent();
            openFileDialogProject_ATY.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            saveFileDialogProject_ATY.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilepath;
        string path = $@"C:\Users\user\source\repos\Tyuiu.ArapovTY.Sprint7\Tyuiu.ArapovTY.Sprint7.Project.V1\����.csv";
        static int cost;
        static int date;
        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            FormAbout_ATY formAbout = new FormAbout_ATY();
            formAbout.ShowDialog();
        }

        private void buttonHelp_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "�������";
        }

        private void buttonOpenFile_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "������� ����";
        }

        private void buttonSaveFile_ATY_Click(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "��������� � ����";
        }

        private void buttonSearch_ATY_Click(object sender, EventArgs e)
        {
            try
            {
                int ID = Convert.ToInt32(textBoxZakazID_ATY.Text);
                dataGridViewResultInfo_ATY.Columns.Clear();
                dataGridViewResultInfo_ATY.Rows.Clear();
                string[,] res = Array(path);
                dataGridViewResultInfo_ATY.ColumnCount = columns;
                dataGridViewResultInfo_ATY.RowCount = ID + 1;
                if (ID < rows)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            if (i == ID)
                            {
                                if (j == 0)
                                {
                                    dataGridViewResultInfo_ATY.Rows[1].Cells[j].Value = res[i, j];
                                    dataGridViewResultInfo_ATY.Columns[j].Width = 50;
                                }
                                else
                                {
                                    dataGridViewResultInfo_ATY.Rows[1].Cells[j].Value = res[i, j];
                                    dataGridViewResultInfo_ATY.Columns[j].Width = 100;
                                    dataGridViewResultInfo_ATY.Rows[i].Height = 50;
                                }
                            }
                            else
                            {
                                if (i == 0)
                                {
                                    dataGridViewResultInfo_ATY.Rows[i].Cells[j].Value = res[i, j];
                                }
                            }
                        }
                    }

                }
                else
                {
                    dataGridViewResultInfo_ATY.Columns.Clear();
                    dataGridViewResultInfo_ATY.Rows.Clear();
                    MessageBox.Show("� ���� ������ ��� ������ ����!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("������� ������ ������!", "������!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string[,] Array(string path)
        {
            string data = File.ReadAllText(path);
            data = data.Replace('\n', '\r');
            string[] lines = data.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
            rows = lines.Length;
            columns = lines[0].Split(';').Length;
            string[,] mtrx = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                string[] strok = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    mtrx[i, j] = strok[j];
                }
            }
            return mtrx;
        }

        private void buttonGraf_ATY_Click(object sender, EventArgs e)
        {
            if (chartGraf_ATY.Series.IndexOf("����") == -1)
            {
                var series = new System.Windows.Forms.DataVisualization.Charting.Series("����");
                series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
                chartGraf_ATY.Series.Add(series);
            }
            chartGraf_ATY.Series["����"].Points.Clear();
            chartGraf_ATY.Series["����"].Points.AddXY("��", 10);
            chartGraf_ATY.Series["����"].Points.AddXY("��", 15);
            chartGraf_ATY.Series["����"].Points.AddXY("��", 8);
            chartGraf_ATY.Series["����"].Points.AddXY("��", 9);
            chartGraf_ATY.Series["����"].Points.AddXY("��", 19);
            chartGraf_ATY.Series["����"].Points.AddXY("��", 20);
            chartGraf_ATY.Series["����"].Points.AddXY("��", 30);
            chartGraf_ATY.ChartAreas[0].AxisX.Title = "��� ������";
            chartGraf_ATY.ChartAreas[0].AxisY.Title = "����������";
        }

        private void buttonCheckInfoMaster_ATY_Click(object sender, EventArgs e)
        {
            try
            {
                string path = @"C:\Users\user\source\repos\Tyuiu.ArapovTY.Sprint7\Tyuiu.ArapovTY.Sprint7.Project.V1\�������.csv";
                if (File.Exists(path))
                {
                    string fileData = File.ReadAllText(path);
                    fileData = fileData.Replace('\n', '\r');
                    string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

                    int rows = lines.Length;
                    int columns = lines[0].Split(';').Length;

                    for (int i = 0; i < rows; i++)
                    {
                        string[] values = lines[i].Split(';');
                        if (radioButtonMaster1_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[0];
                        }
                        else if (radioButtonMaster2_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[1];
                        }
                        else if (radioButtonMaster3_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[2];
                        }
                        else if (radioButtonMaster4_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[3];
                        }
                        else if (radioButtonMaster5_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[4];
                        }
                        else if (radioButtonMaster6_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[5];
                        }
                        else if (radioButtonMaster7_ATY.Checked)
                        {
                            textBoxResultMasters_ATY.Text = values[6];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"������: {ex.Message}", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
