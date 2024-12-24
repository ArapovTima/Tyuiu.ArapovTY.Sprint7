namespace Tyuiu.ArapovTY.Sprint7.Project.V1
{
    partial class FormMainLoad_ATY
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainLoad_ATY));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelName_ATY = new Panel();
            labelName_ATY = new Label();
            buttonHelp_ATY = new Button();
            toolTipProject_ATY = new ToolTip(components);
            buttonOpenFile_ATY = new Button();
            buttonSaveFile_ATY = new Button();
            openFileDialogProject_ATY = new OpenFileDialog();
            saveFileDialogProject_ATY = new SaveFileDialog();
            groupBoxDataEntry_ATY = new GroupBox();
            buttonSearch_ATY = new Button();
            textBoxZakazID_ATY = new TextBox();
            labelZakazID_ATY = new Label();
            labelInfoMaster_ATY = new Label();
            groupBoxInfoMaster_ATY = new GroupBox();
            buttonCheckInfoMaster_ATY = new Button();
            radioButtonMaster7_ATY = new RadioButton();
            radioButtonMaster6_ATY = new RadioButton();
            radioButtonMaster5_ATY = new RadioButton();
            radioButtonMaster4_ATY = new RadioButton();
            radioButtonMaster3_ATY = new RadioButton();
            radioButtonMaster2_ATY = new RadioButton();
            radioButtonMaster1_ATY = new RadioButton();
            dataGridViewResultInfo_ATY = new DataGridView();
            labelInfoMasterskaya_ATY = new Label();
            chartGraf_ATY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonGraf_ATY = new Button();
            textBoxResultMasters_ATY = new TextBox();
            panelName_ATY.SuspendLayout();
            groupBoxDataEntry_ATY.SuspendLayout();
            groupBoxInfoMaster_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultInfo_ATY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartGraf_ATY).BeginInit();
            SuspendLayout();
            // 
            // panelName_ATY
            // 
            panelName_ATY.BackColor = Color.CornflowerBlue;
            panelName_ATY.Controls.Add(labelName_ATY);
            panelName_ATY.Location = new Point(5, 5);
            panelName_ATY.Name = "panelName_ATY";
            panelName_ATY.Size = new Size(1071, 71);
            panelName_ATY.TabIndex = 0;
            // 
            // labelName_ATY
            // 
            labelName_ATY.AutoSize = true;
            labelName_ATY.BackColor = Color.CornflowerBlue;
            labelName_ATY.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName_ATY.Location = new Point(7, 15);
            labelName_ATY.Name = "labelName_ATY";
            labelName_ATY.Size = new Size(726, 38);
            labelName_ATY.TabIndex = 0;
            labelName_ATY.Text = "Авторемонтная мастерская \"МашиноМагия\"";
            // 
            // buttonHelp_ATY
            // 
            buttonHelp_ATY.Image = (Image)resources.GetObject("buttonHelp_ATY.Image");
            buttonHelp_ATY.Location = new Point(1309, 5);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(84, 71);
            buttonHelp_ATY.TabIndex = 1;
            toolTipProject_ATY.SetToolTip(buttonHelp_ATY, "Показать информацию о разработчике");
            buttonHelp_ATY.UseVisualStyleBackColor = true;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            buttonHelp_ATY.MouseEnter += buttonHelp_ATY_MouseEnter;
            // 
            // buttonOpenFile_ATY
            // 
            buttonOpenFile_ATY.Image = (Image)resources.GetObject("buttonOpenFile_ATY.Image");
            buttonOpenFile_ATY.Location = new Point(1107, 5);
            buttonOpenFile_ATY.Name = "buttonOpenFile_ATY";
            buttonOpenFile_ATY.Size = new Size(78, 71);
            buttonOpenFile_ATY.TabIndex = 2;
            toolTipProject_ATY.SetToolTip(buttonOpenFile_ATY, "Выберите нужный файл для загрузки");
            buttonOpenFile_ATY.UseVisualStyleBackColor = true;
            buttonOpenFile_ATY.MouseEnter += buttonOpenFile_ATY_MouseEnter;
            // 
            // buttonSaveFile_ATY
            // 
            buttonSaveFile_ATY.Image = (Image)resources.GetObject("buttonSaveFile_ATY.Image");
            buttonSaveFile_ATY.Location = new Point(1212, 5);
            buttonSaveFile_ATY.Name = "buttonSaveFile_ATY";
            buttonSaveFile_ATY.Size = new Size(79, 71);
            buttonSaveFile_ATY.TabIndex = 3;
            toolTipProject_ATY.SetToolTip(buttonSaveFile_ATY, "Сохранить обработанные данные в файл в формате CSV");
            buttonSaveFile_ATY.UseVisualStyleBackColor = true;
            buttonSaveFile_ATY.Click += buttonSaveFile_ATY_Click;
            // 
            // openFileDialogProject_ATY
            // 
            openFileDialogProject_ATY.FileName = "openFileDialog1";
            // 
            // groupBoxDataEntry_ATY
            // 
            groupBoxDataEntry_ATY.Controls.Add(buttonSearch_ATY);
            groupBoxDataEntry_ATY.Controls.Add(textBoxZakazID_ATY);
            groupBoxDataEntry_ATY.Controls.Add(labelZakazID_ATY);
            groupBoxDataEntry_ATY.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            groupBoxDataEntry_ATY.Location = new Point(5, 140);
            groupBoxDataEntry_ATY.Name = "groupBoxDataEntry_ATY";
            groupBoxDataEntry_ATY.Size = new Size(367, 102);
            groupBoxDataEntry_ATY.TabIndex = 4;
            groupBoxDataEntry_ATY.TabStop = false;
            groupBoxDataEntry_ATY.Text = "Информация о заказе";
            // 
            // buttonSearch_ATY
            // 
            buttonSearch_ATY.BackColor = Color.LightGreen;
            buttonSearch_ATY.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSearch_ATY.Location = new Point(230, 23);
            buttonSearch_ATY.Name = "buttonSearch_ATY";
            buttonSearch_ATY.Size = new Size(120, 70);
            buttonSearch_ATY.TabIndex = 2;
            buttonSearch_ATY.Text = "Поиск";
            buttonSearch_ATY.UseVisualStyleBackColor = false;
            buttonSearch_ATY.Click += buttonSearch_ATY_Click;
            // 
            // textBoxZakazID_ATY
            // 
            textBoxZakazID_ATY.Location = new Point(7, 58);
            textBoxZakazID_ATY.Name = "textBoxZakazID_ATY";
            textBoxZakazID_ATY.Size = new Size(205, 27);
            textBoxZakazID_ATY.TabIndex = 1;
            // 
            // labelZakazID_ATY
            // 
            labelZakazID_ATY.AutoSize = true;
            labelZakazID_ATY.Location = new Point(6, 35);
            labelZakazID_ATY.Name = "labelZakazID_ATY";
            labelZakazID_ATY.Size = new Size(187, 20);
            labelZakazID_ATY.TabIndex = 0;
            labelZakazID_ATY.Text = "Введите ID своего заказа:";
            // 
            // labelInfoMaster_ATY
            // 
            labelInfoMaster_ATY.AutoSize = true;
            labelInfoMaster_ATY.Location = new Point(6, 25);
            labelInfoMaster_ATY.Name = "labelInfoMaster_ATY";
            labelInfoMaster_ATY.Size = new Size(493, 40);
            labelInfoMaster_ATY.TabIndex = 2;
            labelInfoMaster_ATY.Text = "Выберите ФИО мастера, информацию о котором хотите посмотреть:\r\n\r\n";
            // 
            // groupBoxInfoMaster_ATY
            // 
            groupBoxInfoMaster_ATY.Controls.Add(buttonCheckInfoMaster_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster7_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster6_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster5_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster4_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster3_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster2_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster1_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(labelInfoMaster_ATY);
            groupBoxInfoMaster_ATY.Location = new Point(378, 125);
            groupBoxInfoMaster_ATY.Name = "groupBoxInfoMaster_ATY";
            groupBoxInfoMaster_ATY.Size = new Size(1015, 117);
            groupBoxInfoMaster_ATY.TabIndex = 5;
            groupBoxInfoMaster_ATY.TabStop = false;
            groupBoxInfoMaster_ATY.Text = "Мастера";
            // 
            // buttonCheckInfoMaster_ATY
            // 
            buttonCheckInfoMaster_ATY.BackColor = Color.LightGreen;
            buttonCheckInfoMaster_ATY.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCheckInfoMaster_ATY.Location = new Point(729, 53);
            buttonCheckInfoMaster_ATY.Name = "buttonCheckInfoMaster_ATY";
            buttonCheckInfoMaster_ATY.Size = new Size(279, 55);
            buttonCheckInfoMaster_ATY.TabIndex = 10;
            buttonCheckInfoMaster_ATY.Text = "Посмотреть информацию";
            buttonCheckInfoMaster_ATY.UseVisualStyleBackColor = false;
            buttonCheckInfoMaster_ATY.Click += buttonCheckInfoMaster_ATY_Click;
            // 
            // radioButtonMaster7_ATY
            // 
            radioButtonMaster7_ATY.AutoSize = true;
            radioButtonMaster7_ATY.Location = new Point(581, 74);
            radioButtonMaster7_ATY.Name = "radioButtonMaster7_ATY";
            radioButtonMaster7_ATY.Size = new Size(108, 24);
            radioButtonMaster7_ATY.TabIndex = 9;
            radioButtonMaster7_ATY.TabStop = true;
            radioButtonMaster7_ATY.Text = "Волков Д.Н";
            radioButtonMaster7_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster6_ATY
            // 
            radioButtonMaster6_ATY.AutoSize = true;
            radioButtonMaster6_ATY.Location = new Point(382, 73);
            radioButtonMaster6_ATY.Name = "radioButtonMaster6_ATY";
            radioButtonMaster6_ATY.Size = new Size(129, 24);
            radioButtonMaster6_ATY.TabIndex = 8;
            radioButtonMaster6_ATY.TabStop = true;
            radioButtonMaster6_ATY.Text = "Григорьев К.А";
            radioButtonMaster6_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster5_ATY
            // 
            radioButtonMaster5_ATY.AutoSize = true;
            radioButtonMaster5_ATY.Location = new Point(197, 75);
            radioButtonMaster5_ATY.Name = "radioButtonMaster5_ATY";
            radioButtonMaster5_ATY.Size = new Size(121, 24);
            radioButtonMaster5_ATY.TabIndex = 7;
            radioButtonMaster5_ATY.TabStop = true;
            radioButtonMaster5_ATY.Text = "Кузнецов В.С";
            radioButtonMaster5_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster4_ATY
            // 
            radioButtonMaster4_ATY.AutoSize = true;
            radioButtonMaster4_ATY.Location = new Point(18, 74);
            radioButtonMaster4_ATY.Name = "radioButtonMaster4_ATY";
            radioButtonMaster4_ATY.Size = new Size(131, 24);
            radioButtonMaster4_ATY.TabIndex = 6;
            radioButtonMaster4_ATY.TabStop = true;
            radioButtonMaster4_ATY.Text = "Воробьёв А.Ю";
            radioButtonMaster4_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster3_ATY
            // 
            radioButtonMaster3_ATY.AutoSize = true;
            radioButtonMaster3_ATY.Location = new Point(892, 23);
            radioButtonMaster3_ATY.Name = "radioButtonMaster3_ATY";
            radioButtonMaster3_ATY.Size = new Size(116, 24);
            radioButtonMaster3_ATY.TabIndex = 5;
            radioButtonMaster3_ATY.TabStop = true;
            radioButtonMaster3_ATY.Text = "Соколов А.А";
            radioButtonMaster3_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster2_ATY
            // 
            radioButtonMaster2_ATY.AutoSize = true;
            radioButtonMaster2_ATY.Location = new Point(711, 23);
            radioButtonMaster2_ATY.Name = "radioButtonMaster2_ATY";
            radioButtonMaster2_ATY.Size = new Size(107, 24);
            radioButtonMaster2_ATY.TabIndex = 4;
            radioButtonMaster2_ATY.TabStop = true;
            radioButtonMaster2_ATY.Text = "Петров А.В";
            radioButtonMaster2_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster1_ATY
            // 
            radioButtonMaster1_ATY.AutoSize = true;
            radioButtonMaster1_ATY.Location = new Point(523, 23);
            radioButtonMaster1_ATY.Name = "radioButtonMaster1_ATY";
            radioButtonMaster1_ATY.Size = new Size(112, 24);
            radioButtonMaster1_ATY.TabIndex = 3;
            radioButtonMaster1_ATY.TabStop = true;
            radioButtonMaster1_ATY.Text = "Иванов С.М";
            radioButtonMaster1_ATY.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultInfo_ATY
            // 
            dataGridViewResultInfo_ATY.BackgroundColor = SystemColors.ActiveCaption;
            dataGridViewResultInfo_ATY.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultInfo_ATY.ColumnHeadersVisible = false;
            dataGridViewResultInfo_ATY.Location = new Point(11, 248);
            dataGridViewResultInfo_ATY.Name = "dataGridViewResultInfo_ATY";
            dataGridViewResultInfo_ATY.RowHeadersVisible = false;
            dataGridViewResultInfo_ATY.RowHeadersWidth = 51;
            dataGridViewResultInfo_ATY.Size = new Size(361, 309);
            dataGridViewResultInfo_ATY.TabIndex = 6;
            // 
            // labelInfoMasterskaya_ATY
            // 
            labelInfoMasterskaya_ATY.AutoSize = true;
            labelInfoMasterskaya_ATY.BackColor = Color.CornflowerBlue;
            labelInfoMasterskaya_ATY.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelInfoMasterskaya_ATY.Location = new Point(5, 79);
            labelInfoMasterskaya_ATY.Name = "labelInfoMasterskaya_ATY";
            labelInfoMasterskaya_ATY.Size = new Size(704, 50);
            labelInfoMasterskaya_ATY.TabIndex = 8;
            labelInfoMasterskaya_ATY.Text = "Наша мастерская находится по адресу: г.Тюмень, ул.Ленина, д.33\r\nЧасы приёма: 8:00-20:00";
            // 
            // chartGraf_ATY
            // 
            chartGraf_ATY.BackColor = SystemColors.Highlight;
            chartGraf_ATY.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalRight;
            chartArea1.Name = "ChartArea1";
            chartGraf_ATY.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartGraf_ATY.Legends.Add(legend1);
            chartGraf_ATY.Location = new Point(1019, 248);
            chartGraf_ATY.Name = "chartGraf_ATY";
            chartGraf_ATY.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Люди";
            chartGraf_ATY.Series.Add(series1);
            chartGraf_ATY.Size = new Size(374, 242);
            chartGraf_ATY.TabIndex = 9;
            // 
            // buttonGraf_ATY
            // 
            buttonGraf_ATY.BackColor = Color.LightGreen;
            buttonGraf_ATY.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGraf_ATY.Location = new Point(1019, 496);
            buttonGraf_ATY.Name = "buttonGraf_ATY";
            buttonGraf_ATY.Size = new Size(374, 61);
            buttonGraf_ATY.TabIndex = 10;
            buttonGraf_ATY.Text = "Показать график посещаемости";
            buttonGraf_ATY.UseVisualStyleBackColor = false;
            buttonGraf_ATY.Click += buttonGraf_ATY_Click;
            // 
            // textBoxResultMasters_ATY
            // 
            textBoxResultMasters_ATY.BackColor = SystemColors.ActiveCaption;
            textBoxResultMasters_ATY.Location = new Point(384, 248);
            textBoxResultMasters_ATY.Multiline = true;
            textBoxResultMasters_ATY.Name = "textBoxResultMasters_ATY";
            textBoxResultMasters_ATY.Size = new Size(629, 309);
            textBoxResultMasters_ATY.TabIndex = 11;
            // 
            // FormMainLoad_ATY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1405, 581);
            Controls.Add(textBoxResultMasters_ATY);
            Controls.Add(buttonGraf_ATY);
            Controls.Add(chartGraf_ATY);
            Controls.Add(labelInfoMasterskaya_ATY);
            Controls.Add(dataGridViewResultInfo_ATY);
            Controls.Add(groupBoxInfoMaster_ATY);
            Controls.Add(groupBoxDataEntry_ATY);
            Controls.Add(buttonSaveFile_ATY);
            Controls.Add(buttonOpenFile_ATY);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(panelName_ATY);
            Name = "FormMainLoad_ATY";
            Text = "Спринт 7 | Project | Вариант 1 | Арапов Т.Я";
            panelName_ATY.ResumeLayout(false);
            panelName_ATY.PerformLayout();
            groupBoxDataEntry_ATY.ResumeLayout(false);
            groupBoxDataEntry_ATY.PerformLayout();
            groupBoxInfoMaster_ATY.ResumeLayout(false);
            groupBoxInfoMaster_ATY.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultInfo_ATY).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartGraf_ATY).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelName_ATY;
        private Label labelName_ATY;
        private Button buttonHelp_ATY;
        private ToolTip toolTipProject_ATY;
        private OpenFileDialog openFileDialogProject_ATY;
        private SaveFileDialog saveFileDialogProject_ATY;
        private Button buttonOpenFile_ATY;
        private Button buttonSaveFile_ATY;
        private GroupBox groupBoxDataEntry_ATY;
        private TextBox textBoxZakazID_ATY;
        private Label labelZakazID_ATY;
        private Label labelInfoMaster_ATY;
        private GroupBox groupBoxInfoMaster_ATY;
        private Button buttonSearch_ATY;
        private DataGridView dataGridViewResultInfo_ATY;
        private Label labelInfoMasterskaya_ATY;
        private RadioButton radioButtonMaster7_ATY;
        private RadioButton radioButtonMaster6_ATY;
        private RadioButton radioButtonMaster5_ATY;
        private RadioButton radioButtonMaster4_ATY;
        private RadioButton radioButtonMaster3_ATY;
        private RadioButton radioButtonMaster2_ATY;
        private RadioButton radioButtonMaster1_ATY;
        private Button buttonCheckInfoMaster_ATY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraf_ATY;
        private Button buttonGraf_ATY;
        private TextBox textBoxResultMasters_ATY;
    }
}
