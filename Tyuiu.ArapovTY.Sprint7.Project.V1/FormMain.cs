using System.IO;
using System.Windows.Forms;
using Tyuiu.ArapovTY.Sprint7.Project.V1.Lib;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Tyuiu.ArapovTY.Sprint7.Project.V1
{
    public partial class FormMainLoad_ATY : Form
    {
        public FormMainLoad_ATY()
        {
            InitializeComponent();
            openFileDialogProject_ATY.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogProject_ATY.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilepath;
        string path = $@"C:\Sprint7\АЙДИ СПРИНТ.csv";
        static int cost;
        static int date;
        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            FormAbout_ATY formAbout = new FormAbout_ATY();
            formAbout.ShowDialog();
        }

        private void buttonHelp_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "Справка";
        }

        private void buttonOpenFile_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "Открыть файл";
        }

        private void buttonSaveFile_ATY_Click(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "Сохранить в файл";
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
                    MessageBox.Show("В базе данных нет такого айди!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch
            {
                MessageBox.Show("Введите верные данные!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
    }
}
