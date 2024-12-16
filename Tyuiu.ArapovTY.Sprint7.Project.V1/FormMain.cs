using Tyuiu.ArapovTY.Sprint7.Project.V1.Lib;
namespace Tyuiu.ArapovTY.Sprint7.Project.V1
{
    public partial class FormMainLoad_ATY : Form
    {
        public FormMainLoad_ATY()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        static int rows;
        static int columns;
        static string openFilePath;

        private void buttonHelp_ATY_Click(object sender, EventArgs e)
        {
            FormAbout_ATY formAbout = new FormAbout_ATY();
            formAbout.ShowDialog();
        }

        private void buttonHelp_ATY_MouseEnter(object sender, EventArgs e)
        {
            toolTipProject_ATY.ToolTipTitle = "Справка";
        }
    }
}
