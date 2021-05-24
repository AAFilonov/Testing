
namespace RentService
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownCostPerDayFind = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostFind = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxBrandFind = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNumberFind = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxFindNum = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNumberAdd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrandAdd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownCostAdd = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCostPerDayAdd = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxTypeAdd = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPerDayFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostFind)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPerDayAdd)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.textBoxType);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.numericUpDownCostPerDayFind);
            this.panel2.Controls.Add(this.numericUpDownCostFind);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textBoxBrandFind);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.textBoxNumberFind);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(15, 149);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 187);
            this.panel2.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Тип";
            // 
            // numericUpDownCostPerDayFind
            // 
            this.numericUpDownCostPerDayFind.Location = new System.Drawing.Point(130, 96);
            this.numericUpDownCostPerDayFind.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownCostPerDayFind.Name = "numericUpDownCostPerDayFind";
            this.numericUpDownCostPerDayFind.ReadOnly = true;
            this.numericUpDownCostPerDayFind.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCostPerDayFind.TabIndex = 7;
            // 
            // numericUpDownCostFind
            // 
            this.numericUpDownCostFind.Location = new System.Drawing.Point(130, 70);
            this.numericUpDownCostFind.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownCostFind.Name = "numericUpDownCostFind";
            this.numericUpDownCostFind.ReadOnly = true;
            this.numericUpDownCostFind.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCostFind.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Стоиомсть аренды";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Стоимость";
            // 
            // textBoxBrandFind
            // 
            this.textBoxBrandFind.Location = new System.Drawing.Point(67, 44);
            this.textBoxBrandFind.Name = "textBoxBrandFind";
            this.textBoxBrandFind.ReadOnly = true;
            this.textBoxBrandFind.Size = new System.Drawing.Size(175, 20);
            this.textBoxBrandFind.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Марка";
            // 
            // textBoxNumberFind
            // 
            this.textBoxNumberFind.Location = new System.Drawing.Point(67, 18);
            this.textBoxNumberFind.Name = "textBoxNumberFind";
            this.textBoxNumberFind.ReadOnly = true;
            this.textBoxNumberFind.Size = new System.Drawing.Size(175, 20);
            this.textBoxNumberFind.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Номер";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.textBoxFindNum);
            this.panel3.Controls.Add(this.buttonFind);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(313, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(294, 350);
            this.panel3.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Номер";
            // 
            // textBoxFindNum
            // 
            this.textBoxFindNum.Location = new System.Drawing.Point(82, 21);
            this.textBoxFindNum.Name = "textBoxFindNum";
            this.textBoxFindNum.Size = new System.Drawing.Size(200, 20);
            this.textBoxFindNum.TabIndex = 10;
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(207, 51);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 11;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер";
            // 
            // textBoxNumberAdd
            // 
            this.textBoxNumberAdd.Location = new System.Drawing.Point(67, 18);
            this.textBoxNumberAdd.MaxLength = 50;
            this.textBoxNumberAdd.Name = "textBoxNumberAdd";
            this.textBoxNumberAdd.Size = new System.Drawing.Size(175, 20);
            this.textBoxNumberAdd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Марка";
            // 
            // textBoxBrandAdd
            // 
            this.textBoxBrandAdd.Location = new System.Drawing.Point(67, 44);
            this.textBoxBrandAdd.MaxLength = 50;
            this.textBoxBrandAdd.Name = "textBoxBrandAdd";
            this.textBoxBrandAdd.Size = new System.Drawing.Size(175, 20);
            this.textBoxBrandAdd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Стоимость";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Стоиомсть аренды";
            // 
            // numericUpDownCostAdd
            // 
            this.numericUpDownCostAdd.Location = new System.Drawing.Point(130, 70);
            this.numericUpDownCostAdd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownCostAdd.Name = "numericUpDownCostAdd";
            this.numericUpDownCostAdd.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCostAdd.TabIndex = 6;
            // 
            // numericUpDownCostPerDayAdd
            // 
            this.numericUpDownCostPerDayAdd.Location = new System.Drawing.Point(130, 96);
            this.numericUpDownCostPerDayAdd.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDownCostPerDayAdd.Name = "numericUpDownCostPerDayAdd";
            this.numericUpDownCostPerDayAdd.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownCostPerDayAdd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Тип";
            // 
            // comboBoxTypeAdd
            // 
            this.comboBoxTypeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeAdd.FormattingEnabled = true;
            this.comboBoxTypeAdd.Location = new System.Drawing.Point(82, 125);
            this.comboBoxTypeAdd.Name = "comboBoxTypeAdd";
            this.comboBoxTypeAdd.Size = new System.Drawing.Size(160, 21);
            this.comboBoxTypeAdd.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.comboBoxTypeAdd);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.numericUpDownCostPerDayAdd);
            this.panel1.Controls.Add(this.numericUpDownCostAdd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxBrandAdd);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxNumberAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 242);
            this.panel1.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(182, 204);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 10;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(67, 128);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(175, 20);
            this.textBoxType.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 386);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPerDayFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostFind)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCostPerDayAdd)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownCostPerDayFind;
        private System.Windows.Forms.NumericUpDown numericUpDownCostFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxBrandFind;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNumberFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxFindNum;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNumberAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrandAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownCostAdd;
        private System.Windows.Forms.NumericUpDown numericUpDownCostPerDayAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxTypeAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxType;
    }
}

