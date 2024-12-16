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
            openFileDialogProject_ATY = new OpenFileDialog();
            saveFileDialogProject_ATY = new SaveFileDialog();
            panelName_ATY.SuspendLayout();
            SuspendLayout();
            // 
            // panelName_ATY
            // 
            panelName_ATY.Controls.Add(labelName_ATY);
            panelName_ATY.Location = new Point(5, 5);
            panelName_ATY.Name = "panelName_ATY";
            panelName_ATY.Size = new Size(455, 71);
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
            buttonHelp_ATY.Location = new Point(1292, 5);
            buttonHelp_ATY.Name = "buttonHelp_ATY";
            buttonHelp_ATY.Size = new Size(77, 71);
            buttonHelp_ATY.TabIndex = 1;
            toolTipProject_ATY.SetToolTip(buttonHelp_ATY, "Показать информацию о разработчике");
            buttonHelp_ATY.UseVisualStyleBackColor = true;
            buttonHelp_ATY.Click += buttonHelp_ATY_Click;
            buttonHelp_ATY.MouseEnter += buttonHelp_ATY_MouseEnter;
            // 
            // openFileDialogProject_ATY
            // 
            openFileDialogProject_ATY.FileName = "openFileDialog1";
            // 
            // FormMainLoad_ATY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1381, 525);
            Controls.Add(buttonHelp_ATY);
            Controls.Add(panelName_ATY);
            Name = "FormMainLoad_ATY";
            Text = "Спринт 7 | Project | Вариант 1 | Арапов Т.Я";
            panelName_ATY.ResumeLayout(false);
            panelName_ATY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelName_ATY;
        private Label labelName_ATY;
        private Button buttonHelp_ATY;
        private ToolTip toolTipProject_ATY;
        private OpenFileDialog openFileDialogProject_ATY;
        private SaveFileDialog saveFileDialogProject_ATY;
    }
}
