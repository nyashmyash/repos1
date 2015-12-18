namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class KeysForm
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
            this.components = new System.ComponentModel.Container();
            this.keyValueLbl = new System.Windows.Forms.Label();
            this.dateStartlbl = new System.Windows.Forms.Label();
            this.dateEndlbl = new System.Windows.Forms.Label();
            this.isTest = new System.Windows.Forms.CheckBox();
            this.textBoxKeyName = new System.Windows.Forms.TextBox();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.licenseKeysDatabaseDataSet = new SysOfIssuingLicKeysApplication.LicenseKeysDatabaseDataSet();
            this.keyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.keyTableAdapter = new SysOfIssuingLicKeysApplication.LicenseKeysDatabaseDataSetTableAdapters.KeyTableAdapter();
            this.dataKeys = new System.Windows.Forms.DataGridView();
            this.btnAllKeys = new System.Windows.Forms.Button();
            this.btnFullFinder = new System.Windows.Forms.Button();
            this.textFindKey = new System.Windows.Forms.TextBox();
            this.btnFindKey = new System.Windows.Forms.Button();
            this.findKeylbl = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.combOperatons = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.licenseKeysDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // keyValueLbl
            // 
            this.keyValueLbl.AutoSize = true;
            this.keyValueLbl.Location = new System.Drawing.Point(37, 32);
            this.keyValueLbl.Name = "keyValueLbl";
            this.keyValueLbl.Size = new System.Drawing.Size(118, 17);
            this.keyValueLbl.TabIndex = 0;
            this.keyValueLbl.Text = "Значение ключа";
            // 
            // dateStartlbl
            // 
            this.dateStartlbl.AutoSize = true;
            this.dateStartlbl.Location = new System.Drawing.Point(37, 62);
            this.dateStartlbl.Name = "dateStartlbl";
            this.dateStartlbl.Size = new System.Drawing.Size(258, 17);
            this.dateStartlbl.TabIndex = 0;
            this.dateStartlbl.Text = "Дата начала лецинзионного периода";
            // 
            // dateEndlbl
            // 
            this.dateEndlbl.AutoSize = true;
            this.dateEndlbl.Location = new System.Drawing.Point(37, 91);
            this.dateEndlbl.Name = "dateEndlbl";
            this.dateEndlbl.Size = new System.Drawing.Size(281, 17);
            this.dateEndlbl.TabIndex = 0;
            this.dateEndlbl.Text = "Дата окончания лецинзионного периода";
            // 
            // isTest
            // 
            this.isTest.AutoCheck = false;
            this.isTest.AutoSize = true;
            this.isTest.Location = new System.Drawing.Point(40, 121);
            this.isTest.Name = "isTest";
            this.isTest.Size = new System.Drawing.Size(131, 21);
            this.isTest.TabIndex = 1;
            this.isTest.Text = "Тестовый ключ";
            this.isTest.UseVisualStyleBackColor = true;
            // 
            // textBoxKeyName
            // 
            this.textBoxKeyName.Location = new System.Drawing.Point(277, 29);
            this.textBoxKeyName.Name = "textBoxKeyName";
            this.textBoxKeyName.ReadOnly = true;
            this.textBoxKeyName.Size = new System.Drawing.Size(347, 22);
            this.textBoxKeyName.TabIndex = 2;
            // 
            // dateStart
            // 
            this.dateStart.Location = new System.Drawing.Point(424, 62);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 22);
            this.dateStart.TabIndex = 3;
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(424, 91);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 22);
            this.dateEnd.TabIndex = 3;
            // 
            // licenseKeysDatabaseDataSet
            // 
            this.licenseKeysDatabaseDataSet.DataSetName = "LicenseKeysDatabaseDataSet";
            this.licenseKeysDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // keyBindingSource
            // 
            this.keyBindingSource.DataMember = "Key";
            this.keyBindingSource.DataSource = this.licenseKeysDatabaseDataSet;
            // 
            // keyTableAdapter
            // 
            this.keyTableAdapter.ClearBeforeFill = true;
            // 
            // dataKeys
            // 
            this.dataKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKeys.Location = new System.Drawing.Point(3, 216);
            this.dataKeys.Name = "dataKeys";
            this.dataKeys.RowTemplate.Height = 24;
            this.dataKeys.Size = new System.Drawing.Size(632, 365);
            this.dataKeys.TabIndex = 4;
            this.dataKeys.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataKeys_CellClick);
            this.dataKeys.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataKeys_CellFormatting);
            // 
            // btnAllKeys
            // 
            this.btnAllKeys.Location = new System.Drawing.Point(40, 149);
            this.btnAllKeys.Name = "btnAllKeys";
            this.btnAllKeys.Size = new System.Drawing.Size(87, 29);
            this.btnAllKeys.TabIndex = 8;
            this.btnAllKeys.Text = "Все ключи";
            this.btnAllKeys.UseVisualStyleBackColor = true;
            this.btnAllKeys.Click += new System.EventHandler(this.AllKeys_Click);
            // 
            // btnFullFinder
            // 
            this.btnFullFinder.Location = new System.Drawing.Point(133, 150);
            this.btnFullFinder.Name = "btnFullFinder";
            this.btnFullFinder.Size = new System.Drawing.Size(172, 28);
            this.btnFullFinder.TabIndex = 10;
            this.btnFullFinder.Text = "Расширенный поиск";
            this.btnFullFinder.UseVisualStyleBackColor = true;
            this.btnFullFinder.Click += new System.EventHandler(this.FullFinder_Click);
            // 
            // textFindKey
            // 
            this.textFindKey.Location = new System.Drawing.Point(320, 165);
            this.textFindKey.Name = "textFindKey";
            this.textFindKey.Size = new System.Drawing.Size(215, 22);
            this.textFindKey.TabIndex = 2;
            // 
            // btnFindKey
            // 
            this.btnFindKey.Location = new System.Drawing.Point(541, 148);
            this.btnFindKey.Name = "btnFindKey";
            this.btnFindKey.Size = new System.Drawing.Size(85, 29);
            this.btnFindKey.TabIndex = 6;
            this.btnFindKey.Text = "Поиск";
            this.btnFindKey.UseVisualStyleBackColor = true;
            this.btnFindKey.Click += new System.EventHandler(this.findKey_Click);
            // 
            // findKeylbl
            // 
            this.findKeylbl.AutoSize = true;
            this.findKeylbl.Location = new System.Drawing.Point(317, 145);
            this.findKeylbl.Name = "findKeylbl";
            this.findKeylbl.Size = new System.Drawing.Size(218, 17);
            this.findKeylbl.TabIndex = 9;
            this.findKeylbl.Text = "Найти ключ по коду устройства";
            // 
            // btnCont
            // 
            this.btnCont.Location = new System.Drawing.Point(320, 87);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(94, 25);
            this.btnCont.TabIndex = 11;
            this.btnCont.Text = "Продлить";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(227, 184);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(95, 24);
            this.btnMake.TabIndex = 15;
            this.btnMake.Text = "Выполнить";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // combOperatons
            // 
            this.combOperatons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combOperatons.FormattingEnabled = true;
            this.combOperatons.Location = new System.Drawing.Point(40, 184);
            this.combOperatons.Name = "combOperatons";
            this.combOperatons.Size = new System.Drawing.Size(181, 24);
            this.combOperatons.TabIndex = 14;
            this.combOperatons.SelectedIndexChanged += new System.EventHandler(this.combOperatons_SelectedIndexChanged);
            // 
            // KeysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 585);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.combOperatons);
            this.Controls.Add(this.btnCont);
            this.Controls.Add(this.btnFullFinder);
            this.Controls.Add(this.findKeylbl);
            this.Controls.Add(this.btnAllKeys);
            this.Controls.Add(this.btnFindKey);
            this.Controls.Add(this.dataKeys);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.textFindKey);
            this.Controls.Add(this.textBoxKeyName);
            this.Controls.Add(this.isTest);
            this.Controls.Add(this.dateEndlbl);
            this.Controls.Add(this.dateStartlbl);
            this.Controls.Add(this.keyValueLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "KeysForm";
            this.Text = "Лицензионные ключи";
            this.Load += new System.EventHandler(this.KeysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.licenseKeysDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.keyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label keyValueLbl;
        private System.Windows.Forms.Label dateStartlbl;
        private System.Windows.Forms.Label dateEndlbl;
        private System.Windows.Forms.CheckBox isTest;
        private System.Windows.Forms.TextBox textBoxKeyName;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private LicenseKeysDatabaseDataSet licenseKeysDatabaseDataSet;
        private System.Windows.Forms.BindingSource keyBindingSource;
        private LicenseKeysDatabaseDataSetTableAdapters.KeyTableAdapter keyTableAdapter;
        private System.Windows.Forms.DataGridView dataKeys;
        private System.Windows.Forms.Button btnAllKeys;
        private System.Windows.Forms.Button btnFullFinder;
        private System.Windows.Forms.TextBox textFindKey;
        private System.Windows.Forms.Button btnFindKey;
        private System.Windows.Forms.Label findKeylbl;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.ComboBox combOperatons;
    }
}