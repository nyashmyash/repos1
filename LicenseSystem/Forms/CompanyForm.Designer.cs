namespace SysOfIssuingLicKeysApplication
{
    partial class CompanyForm
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
            this.NameCompLbl = new System.Windows.Forms.Label();
            this.NumberOrder = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxNameContract = new System.Windows.Forms.TextBox();
            this.textBoxLimit = new System.Windows.Forms.TextBox();
            this.FindComp = new System.Windows.Forms.Button();
            this.dataComp = new System.Windows.Forms.DataGridView();
            this.cntKeys = new System.Windows.Forms.Label();
            this.valCntKeys = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cntActivTestKeys = new System.Windows.Forms.Label();
            this.Find = new System.Windows.Forms.Button();
            this.combOperatons = new System.Windows.Forms.ComboBox();
            this.btnMake = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataComp)).BeginInit();
            this.SuspendLayout();
            // 
            // NameCompLbl
            // 
            this.NameCompLbl.AutoSize = true;
            this.NameCompLbl.Location = new System.Drawing.Point(33, 22);
            this.NameCompLbl.Name = "NameCompLbl";
            this.NameCompLbl.Size = new System.Drawing.Size(123, 17);
            this.NameCompLbl.TabIndex = 0;
            this.NameCompLbl.Text = "Имя организации";
            // 
            // NumberOrder
            // 
            this.NumberOrder.AutoSize = true;
            this.NumberOrder.Location = new System.Drawing.Point(33, 57);
            this.NumberOrder.Name = "NumberOrder";
            this.NumberOrder.Size = new System.Drawing.Size(115, 17);
            this.NumberOrder.TabIndex = 0;
            this.NumberOrder.Text = "Номер договора";
            // 
            // limit
            // 
            this.limit.AutoSize = true;
            this.limit.Location = new System.Drawing.Point(33, 94);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(103, 17);
            this.limit.TabIndex = 0;
            this.limit.Text = "Лимит ключей";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(195, 22);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(278, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxNameContract
            // 
            this.textBoxNameContract.Location = new System.Drawing.Point(195, 57);
            this.textBoxNameContract.Name = "textBoxNameContract";
            this.textBoxNameContract.ReadOnly = true;
            this.textBoxNameContract.Size = new System.Drawing.Size(278, 22);
            this.textBoxNameContract.TabIndex = 1;
            // 
            // textBoxLimit
            // 
            this.textBoxLimit.Location = new System.Drawing.Point(195, 91);
            this.textBoxLimit.Name = "textBoxLimit";
            this.textBoxLimit.ReadOnly = true;
            this.textBoxLimit.Size = new System.Drawing.Size(278, 22);
            this.textBoxLimit.TabIndex = 1;
            this.textBoxLimit.Text = "0";
            // 
            // FindComp
            // 
            this.FindComp.Location = new System.Drawing.Point(490, 20);
            this.FindComp.Name = "FindComp";
            this.FindComp.Size = new System.Drawing.Size(84, 54);
            this.FindComp.TabIndex = 2;
            this.FindComp.Text = "Показать все";
            this.FindComp.UseVisualStyleBackColor = true;
            this.FindComp.Click += new System.EventHandler(this.FindComp_Click);
            // 
            // dataComp
            // 
            this.dataComp.AllowUserToAddRows = false;
            this.dataComp.AllowUserToDeleteRows = false;
            this.dataComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataComp.Location = new System.Drawing.Point(9, 230);
            this.dataComp.Name = "dataComp";
            this.dataComp.ReadOnly = true;
            this.dataComp.RowTemplate.Height = 24;
            this.dataComp.Size = new System.Drawing.Size(565, 299);
            this.dataComp.TabIndex = 3;
            this.dataComp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataComp_CellClick);
            // 
            // cntKeys
            // 
            this.cntKeys.AutoSize = true;
            this.cntKeys.Location = new System.Drawing.Point(33, 130);
            this.cntKeys.Name = "cntKeys";
            this.cntKeys.Size = new System.Drawing.Size(208, 17);
            this.cntKeys.TabIndex = 4;
            this.cntKeys.Text = "Количество выданных ключей";
            // 
            // valCntKeys
            // 
            this.valCntKeys.AutoSize = true;
            this.valCntKeys.Location = new System.Drawing.Point(427, 130);
            this.valCntKeys.Name = "valCntKeys";
            this.valCntKeys.Size = new System.Drawing.Size(16, 17);
            this.valCntKeys.TabIndex = 5;
            this.valCntKeys.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(298, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество действующих тестовых ключей ";
            // 
            // cntActivTestKeys
            // 
            this.cntActivTestKeys.AutoSize = true;
            this.cntActivTestKeys.Location = new System.Drawing.Point(427, 167);
            this.cntActivTestKeys.Name = "cntActivTestKeys";
            this.cntActivTestKeys.Size = new System.Drawing.Size(16, 17);
            this.cntActivTestKeys.TabIndex = 5;
            this.cntActivTestKeys.Text = "0";
            // 
            // Find
            // 
            this.Find.Location = new System.Drawing.Point(490, 80);
            this.Find.Name = "Find";
            this.Find.Size = new System.Drawing.Size(84, 37);
            this.Find.TabIndex = 6;
            this.Find.Text = "Поиск";
            this.Find.UseVisualStyleBackColor = true;
            this.Find.Click += new System.EventHandler(this.Find_Click);
            // 
            // combOperatons
            // 
            this.combOperatons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combOperatons.FormattingEnabled = true;
            this.combOperatons.Location = new System.Drawing.Point(35, 200);
            this.combOperatons.Name = "combOperatons";
            this.combOperatons.Size = new System.Drawing.Size(181, 24);
            this.combOperatons.TabIndex = 7;
            this.combOperatons.SelectedIndexChanged += new System.EventHandler(this.combOperatons_SelectedIndexChanged);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(222, 200);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(95, 24);
            this.btnMake.TabIndex = 8;
            this.btnMake.Text = "Выполнить";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // CompanyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 541);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.combOperatons);
            this.Controls.Add(this.Find);
            this.Controls.Add(this.cntActivTestKeys);
            this.Controls.Add(this.valCntKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cntKeys);
            this.Controls.Add(this.dataComp);
            this.Controls.Add(this.FindComp);
            this.Controls.Add(this.textBoxLimit);
            this.Controls.Add(this.textBoxNameContract);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.NumberOrder);
            this.Controls.Add(this.NameCompLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CompanyForm";
            this.Text = "Организация";
            this.Load += new System.EventHandler(this.CompanyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameCompLbl;
        private System.Windows.Forms.Label NumberOrder;
        private System.Windows.Forms.Label limit;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxNameContract;
        private System.Windows.Forms.TextBox textBoxLimit;
        private System.Windows.Forms.Button FindComp;
        private System.Windows.Forms.DataGridView dataComp;
        private System.Windows.Forms.Label cntKeys;
        private System.Windows.Forms.Label valCntKeys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cntActivTestKeys;
        private System.Windows.Forms.Button Find;
        private System.Windows.Forms.ComboBox combOperatons;
        private System.Windows.Forms.Button btnMake;
    }
}

