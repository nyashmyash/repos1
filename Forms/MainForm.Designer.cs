namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CompMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.KeysMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DevMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PocessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddOrderMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.историяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryDeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HistoryKeyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridAll = new System.Windows.Forms.DataGridView();
            this.contextMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.KeyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeviceMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CompanyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allinfoBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).BeginInit();
            this.contextMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.PocessMenuItem,
            this.историяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CompMenuItem,
            this.KeysMenuItem,
            this.DevMenuItem,
            this.UsersMenuItem,
            this.выходToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(89, 24);
            this.toolStripMenuItem1.Text = "Сущности";
            // 
            // CompMenuItem
            // 
            this.CompMenuItem.Name = "CompMenuItem";
            this.CompMenuItem.Size = new System.Drawing.Size(177, 24);
            this.CompMenuItem.Text = "Организации";
            this.CompMenuItem.Click += new System.EventHandler(this.CompMenuItem_Click);
            // 
            // KeysMenuItem
            // 
            this.KeysMenuItem.Name = "KeysMenuItem";
            this.KeysMenuItem.Size = new System.Drawing.Size(177, 24);
            this.KeysMenuItem.Text = "Ключи";
            this.KeysMenuItem.Click += new System.EventHandler(this.KeysMenuItem_Click);
            // 
            // DevMenuItem
            // 
            this.DevMenuItem.Name = "DevMenuItem";
            this.DevMenuItem.Size = new System.Drawing.Size(177, 24);
            this.DevMenuItem.Text = "Устройства";
            this.DevMenuItem.Click += new System.EventHandler(this.DevMenuItem_Click);
            // 
            // UsersMenuItem
            // 
            this.UsersMenuItem.Name = "UsersMenuItem";
            this.UsersMenuItem.Size = new System.Drawing.Size(177, 24);
            this.UsersMenuItem.Text = "Пользователи";
            this.UsersMenuItem.Click += new System.EventHandler(this.UsersMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // PocessMenuItem
            // 
            this.PocessMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddOrderMenuItem});
            this.PocessMenuItem.Name = "PocessMenuItem";
            this.PocessMenuItem.Size = new System.Drawing.Size(93, 24);
            this.PocessMenuItem.Text = "Операции";
            // 
            // AddOrderMenuItem
            // 
            this.AddOrderMenuItem.Name = "AddOrderMenuItem";
            this.AddOrderMenuItem.Size = new System.Drawing.Size(258, 24);
            this.AddOrderMenuItem.Text = "Добавить запрос на ключ";
            this.AddOrderMenuItem.Click += new System.EventHandler(this.AddOrderMenuItem_Click);
            // 
            // историяToolStripMenuItem
            // 
            this.историяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistoryDeviceMenuItem,
            this.HistoryKeyMenuItem});
            this.историяToolStripMenuItem.Name = "историяToolStripMenuItem";
            this.историяToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.историяToolStripMenuItem.Text = "История";
            // 
            // HistoryDeviceMenuItem
            // 
            this.HistoryDeviceMenuItem.Name = "HistoryDeviceMenuItem";
            this.HistoryDeviceMenuItem.Size = new System.Drawing.Size(250, 24);
            this.HistoryDeviceMenuItem.Text = "История по устройствам";
            this.HistoryDeviceMenuItem.Click += new System.EventHandler(this.HistoryDeviceMenuItem_Click);
            // 
            // HistoryKeyMenuItem
            // 
            this.HistoryKeyMenuItem.Name = "HistoryKeyMenuItem";
            this.HistoryKeyMenuItem.Size = new System.Drawing.Size(250, 24);
            this.HistoryKeyMenuItem.Text = "История по ключам";
            this.HistoryKeyMenuItem.Click += new System.EventHandler(this.HistoryKeyMenuItem_Click);
            // 
            // dataGridAll
            // 
            this.dataGridAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAll.Location = new System.Drawing.Point(12, 31);
            this.dataGridAll.Name = "dataGridAll";
            this.dataGridAll.RowTemplate.Height = 24;
            this.dataGridAll.Size = new System.Drawing.Size(912, 385);
            this.dataGridAll.TabIndex = 1;
            this.dataGridAll.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridAll_CellFormatting);
            this.dataGridAll.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridAll_CellMouseClick);
            // 
            // contextMain
            // 
            this.contextMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.KeyMenuItem,
            this.DeviceMenuItem,
            this.CompanyMenuItem});
            this.contextMain.Name = "contextMenuStrip1";
            this.contextMain.Size = new System.Drawing.Size(172, 76);
            // 
            // KeyMenuItem
            // 
            this.KeyMenuItem.Name = "KeyMenuItem";
            this.KeyMenuItem.Size = new System.Drawing.Size(171, 24);
            this.KeyMenuItem.Text = "Ключ";
            this.KeyMenuItem.Click += new System.EventHandler(this.KeyMenuItem_Click);
            // 
            // DeviceMenuItem
            // 
            this.DeviceMenuItem.Name = "DeviceMenuItem";
            this.DeviceMenuItem.Size = new System.Drawing.Size(171, 24);
            this.DeviceMenuItem.Text = "Устройство";
            this.DeviceMenuItem.Click += new System.EventHandler(this.DeviceMenuItem_Click);
            // 
            // CompanyMenuItem
            // 
            this.CompanyMenuItem.Name = "CompanyMenuItem";
            this.CompanyMenuItem.Size = new System.Drawing.Size(171, 24);
            this.CompanyMenuItem.Text = "Организация";
            this.CompanyMenuItem.Click += new System.EventHandler(this.CompanyMenuItem_Click);
            // 
            // allinfoBtn
            // 
            this.allinfoBtn.Location = new System.Drawing.Point(785, 0);
            this.allinfoBtn.Name = "allinfoBtn";
            this.allinfoBtn.Size = new System.Drawing.Size(139, 25);
            this.allinfoBtn.TabIndex = 2;
            this.allinfoBtn.Text = "Вся информация";
            this.allinfoBtn.UseVisualStyleBackColor = true;
            this.allinfoBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 420);
            this.Controls.Add(this.allinfoBtn);
            this.Controls.Add(this.dataGridAll);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Система учёта выданных лицензионных ключей.";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAll)).EndInit();
            this.contextMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CompMenuItem;
        private System.Windows.Forms.ToolStripMenuItem KeysMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DevMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PocessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddOrderMenuItem;
        private System.Windows.Forms.ToolStripMenuItem историяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoryDeviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HistoryKeyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersMenuItem;
        private System.Windows.Forms.DataGridView dataGridAll;
        private System.Windows.Forms.Button allinfoBtn;
        private System.Windows.Forms.ContextMenuStrip contextMain;
        private System.Windows.Forms.ToolStripMenuItem KeyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeviceMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CompanyMenuItem;
    }
}