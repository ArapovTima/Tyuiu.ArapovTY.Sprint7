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
            panelName_ATY = new Panel();
            labelName_ATY = new Label();
            buttonHelp_ATY = new Button();
            toolTipProject_ATY = new ToolTip(components);
            buttonOpenFile_ATY = new Button();
            buttonSaveFile_ATY = new Button();
            openFileDialogProject_ATY = new OpenFileDialog();
            saveFileDialogProject_ATY = new SaveFileDialog();
            groupBoxDataEntry_ATY = new GroupBox();
            textBoxZakazID_ATY = new TextBox();
            labelZakazID_ATY = new Label();
            labelInfoMaster_ATY = new Label();
            groupBoxInfoMaster_ATY = new GroupBox();
            buttonPerform_ATY = new Button();
            radioButtonMaster2_ATY = new RadioButton();
            radioButtonMaster7_ATY = new RadioButton();
            radioButtonMaster6_ATY = new RadioButton();
            radioButtonMaster5_ATY = new RadioButton();
            radioButtonMaster4_ATY = new RadioButton();
            radioButtonMaster3_ATY = new RadioButton();
            radioButtonMaster1_ATY = new RadioButton();
            textBoxResultInfoID_ATY = new TextBox();
            textBoxResultMaster_ATY = new TextBox();
            buttonSearch_ATY = new Button();
            panelName_ATY.SuspendLayout();
            groupBoxDataEntry_ATY.SuspendLayout();
            groupBoxInfoMaster_ATY.SuspendLayout();
            SuspendLayout();
            // 
            // panelName_ATY
            // 
            panelName_ATY.Controls.Add(labelName_ATY);
            panelName_ATY.Location = new Point(5, 5);
            panelName_ATY.Name = "panelName_ATY";
            panelName_ATY.Size = new Size(1071, 71);
            panelName_ATY.TabIndex = 0;
            // 
            // labelName_ATY
            // 
            labelName_ATY.AutoSize = true;
            labelName_ATY.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelName_ATY.Location = new Point(7, 15);
            labelName_ATY.Name = "labelName_ATY";
            labelName_ATY.Size = new Size(442, 38);
            labelName_ATY.TabIndex = 0;
            labelName_ATY.Text = "Авторемонтная мастерская";
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
            toolTipProject_ATY.SetToolTip(buttonOpenFile_ATY, "Выберите нужный файл для обработки");
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
            groupBoxDataEntry_ATY.Location = new Point(5, 82);
            groupBoxDataEntry_ATY.Name = "groupBoxDataEntry_ATY";
            groupBoxDataEntry_ATY.Size = new Size(312, 100);
            groupBoxDataEntry_ATY.TabIndex = 4;
            groupBoxDataEntry_ATY.TabStop = false;
            groupBoxDataEntry_ATY.Text = "Информация о заказе";
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
            labelZakazID_ATY.Size = new Size(206, 20);
            labelZakazID_ATY.TabIndex = 0;
            labelZakazID_ATY.Text = "Введите айди своего заказа:";
            // 
            // labelInfoMaster_ATY
            // 
            labelInfoMaster_ATY.AutoSize = true;
            labelInfoMaster_ATY.Location = new Point(6, 31);
            labelInfoMaster_ATY.Name = "labelInfoMaster_ATY";
            labelInfoMaster_ATY.Size = new Size(459, 20);
            labelInfoMaster_ATY.TabIndex = 2;
            labelInfoMaster_ATY.Text = "Выберите ФИО мастера, чтобы посмотреть информацию о нём:\r\n";
            // 
            // groupBoxInfoMaster_ATY
            // 
            groupBoxInfoMaster_ATY.Controls.Add(buttonPerform_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster2_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster7_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster6_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster5_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster4_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster3_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(radioButtonMaster1_ATY);
            groupBoxInfoMaster_ATY.Controls.Add(labelInfoMaster_ATY);
            groupBoxInfoMaster_ATY.Location = new Point(323, 86);
            groupBoxInfoMaster_ATY.Name = "groupBoxInfoMaster_ATY";
            groupBoxInfoMaster_ATY.Size = new Size(1070, 96);
            groupBoxInfoMaster_ATY.TabIndex = 5;
            groupBoxInfoMaster_ATY.TabStop = false;
            groupBoxInfoMaster_ATY.Text = "Мастера";
            // 
            // buttonPerform_ATY
            // 
            buttonPerform_ATY.BackColor = Color.LightGreen;
            buttonPerform_ATY.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonPerform_ATY.ForeColor = SystemColors.ControlText;
            buttonPerform_ATY.Location = new Point(762, 29);
            buttonPerform_ATY.Name = "buttonPerform_ATY";
            buttonPerform_ATY.Size = new Size(286, 50);
            buttonPerform_ATY.TabIndex = 10;
            buttonPerform_ATY.Text = "Посмотреть информацию";
            buttonPerform_ATY.UseVisualStyleBackColor = false;
            // 
            // radioButtonMaster2_ATY
            // 
            radioButtonMaster2_ATY.AutoSize = true;
            radioButtonMaster2_ATY.Location = new Point(626, 27);
            radioButtonMaster2_ATY.Name = "radioButtonMaster2_ATY";
            radioButtonMaster2_ATY.Size = new Size(106, 24);
            radioButtonMaster2_ATY.TabIndex = 9;
            radioButtonMaster2_ATY.TabStop = true;
            radioButtonMaster2_ATY.Text = "Петров Т.А";
            radioButtonMaster2_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster7_ATY
            // 
            radioButtonMaster7_ATY.AutoSize = true;
            radioButtonMaster7_ATY.Location = new Point(626, 66);
            radioButtonMaster7_ATY.Name = "radioButtonMaster7_ATY";
            radioButtonMaster7_ATY.Size = new Size(106, 24);
            radioButtonMaster7_ATY.TabIndex = 8;
            radioButtonMaster7_ATY.TabStop = true;
            radioButtonMaster7_ATY.Text = "Волков Д.В";
            radioButtonMaster7_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster6_ATY
            // 
            radioButtonMaster6_ATY.AutoSize = true;
            radioButtonMaster6_ATY.Location = new Point(485, 66);
            radioButtonMaster6_ATY.Name = "radioButtonMaster6_ATY";
            radioButtonMaster6_ATY.Size = new Size(129, 24);
            radioButtonMaster6_ATY.TabIndex = 7;
            radioButtonMaster6_ATY.TabStop = true;
            radioButtonMaster6_ATY.Text = "Григорьев К.А";
            radioButtonMaster6_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster5_ATY
            // 
            radioButtonMaster5_ATY.AutoSize = true;
            radioButtonMaster5_ATY.Location = new Point(305, 66);
            radioButtonMaster5_ATY.Name = "radioButtonMaster5_ATY";
            radioButtonMaster5_ATY.Size = new Size(120, 24);
            radioButtonMaster5_ATY.TabIndex = 6;
            radioButtonMaster5_ATY.TabStop = true;
            radioButtonMaster5_ATY.Text = "Кузнецов Р.С";
            radioButtonMaster5_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster4_ATY
            // 
            radioButtonMaster4_ATY.AutoSize = true;
            radioButtonMaster4_ATY.Location = new Point(153, 66);
            radioButtonMaster4_ATY.Name = "radioButtonMaster4_ATY";
            radioButtonMaster4_ATY.Size = new Size(126, 24);
            radioButtonMaster4_ATY.TabIndex = 5;
            radioButtonMaster4_ATY.TabStop = true;
            radioButtonMaster4_ATY.Text = "Воробьёв И.В";
            radioButtonMaster4_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster3_ATY
            // 
            radioButtonMaster3_ATY.AutoSize = true;
            radioButtonMaster3_ATY.Location = new Point(6, 66);
            radioButtonMaster3_ATY.Name = "radioButtonMaster3_ATY";
            radioButtonMaster3_ATY.Size = new Size(116, 24);
            radioButtonMaster3_ATY.TabIndex = 4;
            radioButtonMaster3_ATY.TabStop = true;
            radioButtonMaster3_ATY.Text = "Соколов А.А";
            radioButtonMaster3_ATY.UseVisualStyleBackColor = true;
            // 
            // radioButtonMaster1_ATY
            // 
            radioButtonMaster1_ATY.AutoSize = true;
            radioButtonMaster1_ATY.Location = new Point(485, 29);
            radioButtonMaster1_ATY.Name = "radioButtonMaster1_ATY";
            radioButtonMaster1_ATY.Size = new Size(110, 24);
            radioButtonMaster1_ATY.TabIndex = 3;
            radioButtonMaster1_ATY.TabStop = true;
            radioButtonMaster1_ATY.Text = "Иванов С.О";
            radioButtonMaster1_ATY.UseVisualStyleBackColor = true;
            // 
            // textBoxResultInfoID_ATY
            // 
            textBoxResultInfoID_ATY.Location = new Point(5, 188);
            textBoxResultInfoID_ATY.Multiline = true;
            textBoxResultInfoID_ATY.Name = "textBoxResultInfoID_ATY";
            textBoxResultInfoID_ATY.ScrollBars = ScrollBars.Vertical;
            textBoxResultInfoID_ATY.Size = new Size(618, 215);
            textBoxResultInfoID_ATY.TabIndex = 6;
            // 
            // textBoxResultMaster_ATY
            // 
            textBoxResultMaster_ATY.Location = new Point(650, 188);
            textBoxResultMaster_ATY.Multiline = true;
            textBoxResultMaster_ATY.Name = "textBoxResultMaster_ATY";
            textBoxResultMaster_ATY.ScrollBars = ScrollBars.Vertical;
            textBoxResultMaster_ATY.Size = new Size(743, 215);
            textBoxResultMaster_ATY.TabIndex = 7;
            // 
            // buttonSearch_ATY
            // 
            buttonSearch_ATY.BackColor = Color.LightGreen;
            buttonSearch_ATY.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonSearch_ATY.Location = new Point(218, 26);
            buttonSearch_ATY.Name = "buttonSearch_ATY";
            buttonSearch_ATY.Size = new Size(88, 59);
            buttonSearch_ATY.TabIndex = 2;
            buttonSearch_ATY.Text = "Поиск";
            buttonSearch_ATY.UseVisualStyleBackColor = false;
            // 
            // FormMainLoad_ATY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1405, 709);
            Controls.Add(textBoxResultMaster_ATY);
            Controls.Add(textBoxResultInfoID_ATY);
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
        private RadioButton radioButtonMaster2_ATY;
        private RadioButton radioButtonMaster7_ATY;
        private RadioButton radioButtonMaster6_ATY;
        private RadioButton radioButtonMaster5_ATY;
        private RadioButton radioButtonMaster4_ATY;
        private RadioButton radioButtonMaster3_ATY;
        private RadioButton radioButtonMaster1_ATY;
        private Button buttonPerform_ATY;
        private TextBox textBoxResultInfoID_ATY;
        private TextBox textBoxResultMaster_ATY;
        private Button buttonSearch_ATY;
    }
}
