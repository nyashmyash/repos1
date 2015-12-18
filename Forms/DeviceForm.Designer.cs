namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class DeviceForm
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
            this.deviceCodeLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.textCodeDev = new System.Windows.Forms.TextBox();
            this.textSurn = new System.Windows.Forms.TextBox();
            this.textPos = new System.Windows.Forms.TextBox();
            this.dataDevice = new System.Windows.Forms.DataGridView();
            this.changeCode = new System.Windows.Forms.Button();
            this.btnOrg = new System.Windows.Forms.Button();
            this.keyBtn = new System.Windows.Forms.Button();
            this.btnMake = new System.Windows.Forms.Button();
            this.combOperatons = new System.Windows.Forms.ComboBox();
            this.orgCombBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // deviceCodeLbl
            // 
            this.deviceCodeLbl.AutoSize = true;
            this.deviceCodeLbl.Location = new System.Drawing.Point(26, 26);
            this.deviceCodeLbl.Name = "deviceCodeLbl";
            this.deviceCodeLbl.Size = new System.Drawing.Size(121, 17);
            this.deviceCodeLbl.TabIndex = 0;
            this.deviceCodeLbl.Text = "Ключ устройства";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Location = new System.Drawing.Point(26, 61);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(222, 17);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "Фамилия владельца устройства";
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(26, 96);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(233, 17);
            this.positionLbl.TabIndex = 2;
            this.positionLbl.Text = "Должность владельца устройства";
            // 
            // textCodeDev
            // 
            this.textCodeDev.Location = new System.Drawing.Point(277, 23);
            this.textCodeDev.Name = "textCodeDev";
            this.textCodeDev.ReadOnly = true;
            this.textCodeDev.Size = new System.Drawing.Size(266, 22);
            this.textCodeDev.TabIndex = 3;
            // 
            // textSurn
            // 
            this.textSurn.Location = new System.Drawing.Point(277, 58);
            this.textSurn.Name = "textSurn";
            this.textSurn.ReadOnly = true;
            this.textSurn.Size = new System.Drawing.Size(266, 22);
            this.textSurn.TabIndex = 4;
            // 
            // textPos
            // 
            this.textPos.Location = new System.Drawing.Point(277, 93);
            this.textPos.Name = "textPos";
            this.textPos.ReadOnly = true;
            this.textPos.Size = new System.Drawing.Size(266, 22);
            this.textPos.TabIndex = 5;
            // 
            // dataDevice
            // 
            this.dataDevice.AllowUserToAddRows = false;
            this.dataDevice.AllowUserToDeleteRows = false;
            this.dataDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDevice.Location = new System.Drawing.Point(4, 186);
            this.dataDevice.Name = "dataDevice";
            this.dataDevice.ReadOnly = true;
            this.dataDevice.RowTemplate.Height = 24;
            this.dataDevice.Size = new System.Drawing.Size(539, 247);
            this.dataDevice.TabIndex = 7;
            this.dataDevice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDevice_CellClick);
            // 
            // changeCode
            // 
            this.changeCode.Location = new System.Drawing.Point(4, 121);
            this.changeCode.Name = "changeCode";
            this.changeCode.Size = new System.Drawing.Size(161, 29);
            this.changeCode.TabIndex = 9;
            this.changeCode.Text = "Изменить код устр-ва";
            this.changeCode.UseVisualStyleBackColor = true;
            this.changeCode.Click += new System.EventHandler(this.changeCode_Click);
            // 
            // btnOrg
            // 
            this.btnOrg.Location = new System.Drawing.Point(277, 121);
            this.btnOrg.Name = "btnOrg";
            this.btnOrg.Size = new System.Drawing.Size(154, 29);
            this.btnOrg.TabIndex = 10;
            this.btnOrg.Text = "Инф об орагнизации";
            this.btnOrg.UseVisualStyleBackColor = true;
            this.btnOrg.Click += new System.EventHandler(this.btnOrg_Click);
            // 
            // keyBtn
            // 
            this.keyBtn.Location = new System.Drawing.Point(436, 121);
            this.keyBtn.Name = "keyBtn";
            this.keyBtn.Size = new System.Drawing.Size(107, 29);
            this.keyBtn.TabIndex = 11;
            this.keyBtn.Text = "Инф. о ключе";
            this.keyBtn.UseVisualStyleBackColor = true;
            this.keyBtn.Click += new System.EventHandler(this.keyBtn_Click);
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(191, 156);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(95, 24);
            this.btnMake.TabIndex = 13;
            this.btnMake.Text = "Выполнить";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // combOperatons
            // 
            this.combOperatons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combOperatons.FormattingEnabled = true;
            this.combOperatons.Location = new System.Drawing.Point(4, 156);
            this.combOperatons.Name = "combOperatons";
            this.combOperatons.Size = new System.Drawing.Size(181, 24);
            this.combOperatons.TabIndex = 12;
            this.combOperatons.SelectedIndexChanged += new System.EventHandler(this.combOperatons_SelectedIndexChanged);
            // 
            // orgCombBox
            // 
            this.orgCombBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orgCombBox.FormattingEnabled = true;
            this.orgCombBox.Location = new System.Drawing.Point(376, 156);
            this.orgCombBox.Name = "orgCombBox";
            this.orgCombBox.Size = new System.Drawing.Size(167, 24);
            this.orgCombBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Компания";
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 440);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orgCombBox);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.combOperatons);
            this.Controls.Add(this.keyBtn);
            this.Controls.Add(this.btnOrg);
            this.Controls.Add(this.changeCode);
            this.Controls.Add(this.dataDevice);
            this.Controls.Add(this.textPos);
            this.Controls.Add(this.textSurn);
            this.Controls.Add(this.textCodeDev);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.deviceCodeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeviceForm";
            this.Text = "Устройство";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deviceCodeLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.TextBox textCodeDev;
        private System.Windows.Forms.TextBox textSurn;
        private System.Windows.Forms.TextBox textPos;
        private System.Windows.Forms.DataGridView dataDevice;
        private System.Windows.Forms.Button changeCode;
        private System.Windows.Forms.Button btnOrg;
        private System.Windows.Forms.Button keyBtn;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.ComboBox combOperatons;
        private System.Windows.Forms.ComboBox orgCombBox;
        private System.Windows.Forms.Label label1;
    }
}