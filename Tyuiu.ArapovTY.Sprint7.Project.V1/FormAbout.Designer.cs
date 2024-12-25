namespace Tyuiu.ArapovTY.Sprint7.Project.V1
{
    partial class FormAbout_ATY
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout_ATY));
            groupBoxAdmin_ATY = new GroupBox();
            pictureBoxMe_ATY = new PictureBox();
            buttonClose_ATY = new Button();
            groupBoxProgram_ATY = new GroupBox();
            labelInfo_ATY = new Label();
            groupBoxAdmin_ATY.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_ATY).BeginInit();
            groupBoxProgram_ATY.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxAdmin_ATY
            // 
            groupBoxAdmin_ATY.BackColor = Color.LemonChiffon;
            groupBoxAdmin_ATY.Controls.Add(pictureBoxMe_ATY);
            groupBoxAdmin_ATY.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxAdmin_ATY.Location = new Point(12, 12);
            groupBoxAdmin_ATY.Margin = new Padding(3, 4, 3, 4);
            groupBoxAdmin_ATY.Name = "groupBoxAdmin_ATY";
            groupBoxAdmin_ATY.Padding = new Padding(3, 4, 3, 4);
            groupBoxAdmin_ATY.Size = new Size(338, 492);
            groupBoxAdmin_ATY.TabIndex = 0;
            groupBoxAdmin_ATY.TabStop = false;
            groupBoxAdmin_ATY.Text = "Фоточка разраба:";
            // 
            // pictureBoxMe_ATY
            // 
            pictureBoxMe_ATY.BackColor = Color.Ivory;
            pictureBoxMe_ATY.Image = (Image)resources.GetObject("pictureBoxMe_ATY.Image");
            pictureBoxMe_ATY.Location = new Point(16, 56);
            pictureBoxMe_ATY.Margin = new Padding(3, 4, 3, 4);
            pictureBoxMe_ATY.Name = "pictureBoxMe_ATY";
            pictureBoxMe_ATY.Size = new Size(289, 408);
            pictureBoxMe_ATY.TabIndex = 1;
            pictureBoxMe_ATY.TabStop = false;
            // 
            // buttonClose_ATY
            // 
            buttonClose_ATY.BackColor = Color.Red;
            buttonClose_ATY.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonClose_ATY.Location = new Point(545, 431);
            buttonClose_ATY.Margin = new Padding(3, 4, 3, 4);
            buttonClose_ATY.Name = "buttonClose_ATY";
            buttonClose_ATY.Size = new Size(234, 74);
            buttonClose_ATY.TabIndex = 1;
            buttonClose_ATY.Text = "Закрыть";
            buttonClose_ATY.UseVisualStyleBackColor = false;
            buttonClose_ATY.Click += buttonClose_ATY_Click;
            // 
            // groupBoxProgram_ATY
            // 
            groupBoxProgram_ATY.BackColor = Color.LemonChiffon;
            groupBoxProgram_ATY.Controls.Add(labelInfo_ATY);
            groupBoxProgram_ATY.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            groupBoxProgram_ATY.Location = new Point(356, 12);
            groupBoxProgram_ATY.Margin = new Padding(3, 4, 3, 4);
            groupBoxProgram_ATY.Name = "groupBoxProgram_ATY";
            groupBoxProgram_ATY.Padding = new Padding(3, 4, 3, 4);
            groupBoxProgram_ATY.Size = new Size(423, 399);
            groupBoxProgram_ATY.TabIndex = 2;
            groupBoxProgram_ATY.TabStop = false;
            groupBoxProgram_ATY.Text = "О программе:";
            // 
            // labelInfo_ATY
            // 
            labelInfo_ATY.AutoSize = true;
            labelInfo_ATY.BackColor = Color.LemonChiffon;
            labelInfo_ATY.Font = new Font("Times New Roman", 10.8F, FontStyle.Italic, GraphicsUnit.Point, 204);
            labelInfo_ATY.Location = new Point(6, 36);
            labelInfo_ATY.Name = "labelInfo_ATY";
            labelInfo_ATY.Size = new Size(411, 280);
            labelInfo_ATY.TabIndex = 0;
            labelInfo_ATY.Text = resources.GetString("labelInfo_ATY.Text");
            // 
            // FormAbout_ATY
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(791, 516);
            Controls.Add(groupBoxProgram_ATY);
            Controls.Add(buttonClose_ATY);
            Controls.Add(groupBoxAdmin_ATY);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormAbout_ATY";
            Text = "Сведения о программе";
            groupBoxAdmin_ATY.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxMe_ATY).EndInit();
            groupBoxProgram_ATY.ResumeLayout(false);
            groupBoxProgram_ATY.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxAdmin_ATY;
        private Button buttonClose_ATY;
        private GroupBox groupBoxProgram_ATY;
        private PictureBox pictureBoxMe_ATY;
        private Label labelInfo_ATY;
    }
}