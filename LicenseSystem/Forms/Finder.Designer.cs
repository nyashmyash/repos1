namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class Finder
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.butnFind = new System.Windows.Forms.Button();
            this.maskText = new System.Windows.Forms.TextBox();
            this.keyValueLbl = new System.Windows.Forms.Label();
            this.isTest = new System.Windows.Forms.CheckBox();
            this.checkOptions = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Location = new System.Drawing.Point(314, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 107);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пром. даты начала лиц. периода";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(6, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 38);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePicker4);
            this.groupBox2.Controls.Add(this.dateTimePicker3);
            this.groupBox2.Location = new System.Drawing.Point(314, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 107);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Пром. даты конца лиц. периода";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Location = new System.Drawing.Point(6, 66);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 0;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Location = new System.Drawing.Point(6, 38);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 0;
            // 
            // butnFind
            // 
            this.butnFind.Location = new System.Drawing.Point(439, 254);
            this.butnFind.Name = "butnFind";
            this.butnFind.Size = new System.Drawing.Size(75, 33);
            this.butnFind.TabIndex = 1;
            this.butnFind.Text = "Искать";
            this.butnFind.UseVisualStyleBackColor = true;
            this.butnFind.Click += new System.EventHandler(this.butnFind_Click);
            // 
            // maskText
            // 
            this.maskText.Location = new System.Drawing.Point(112, 38);
            this.maskText.Name = "maskText";
            this.maskText.Size = new System.Drawing.Size(196, 22);
            this.maskText.TabIndex = 2;
            // 
            // keyValueLbl
            // 
            this.keyValueLbl.AutoSize = true;
            this.keyValueLbl.Location = new System.Drawing.Point(12, 38);
            this.keyValueLbl.Name = "keyValueLbl";
            this.keyValueLbl.Size = new System.Drawing.Size(94, 17);
            this.keyValueLbl.TabIndex = 3;
            this.keyValueLbl.Text = "Маска ключа";
            // 
            // isTest
            // 
            this.isTest.AutoSize = true;
            this.isTest.Location = new System.Drawing.Point(12, 66);
            this.isTest.Name = "isTest";
            this.isTest.Size = new System.Drawing.Size(131, 21);
            this.isTest.TabIndex = 4;
            this.isTest.Text = "Тестовый ключ";
            this.isTest.UseVisualStyleBackColor = true;
            // 
            // checkOptions
            // 
            this.checkOptions.FormattingEnabled = true;
            this.checkOptions.Items.AddRange(new object[] {
            "Маска ключа",
            "Тестовый ключ",
            "Дата начала лиц. периода",
            "Дата начала конца. периода"});
            this.checkOptions.Location = new System.Drawing.Point(12, 152);
            this.checkOptions.Name = "checkOptions";
            this.checkOptions.Size = new System.Drawing.Size(228, 89);
            this.checkOptions.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Параметры для поиска";
            // 
            // Finder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 293);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkOptions);
            this.Controls.Add(this.isTest);
            this.Controls.Add(this.keyValueLbl);
            this.Controls.Add(this.maskText);
            this.Controls.Add(this.butnFind);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Finder";
            this.Text = "Finder";
            this.Load += new System.EventHandler(this.Finder_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Button butnFind;
        private System.Windows.Forms.TextBox maskText;
        private System.Windows.Forms.Label keyValueLbl;
        private System.Windows.Forms.CheckBox isTest;
        private System.Windows.Forms.CheckedListBox checkOptions;
        private System.Windows.Forms.Label label1;
    }
}