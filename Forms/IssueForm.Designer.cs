namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class IssueForm
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
            this.nameOrgComb = new System.Windows.Forms.ComboBox();
            this.nameOrgLabl = new System.Windows.Forms.Label();
            this.KeyDeviceLbl = new System.Windows.Forms.Label();
            this.keyDeviceComb = new System.Windows.Forms.ComboBox();
            this.KeyLicLbl = new System.Windows.Forms.Label();
            this.licKeycomb = new System.Windows.Forms.ComboBox();
            this.ok = new System.Windows.Forms.Button();
            this.btnInfCmp = new System.Windows.Forms.Button();
            this.btnInfDevice = new System.Windows.Forms.Button();
            this.btnInfKey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameOrgComb
            // 
            this.nameOrgComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameOrgComb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.nameOrgComb.FormattingEnabled = true;
            this.nameOrgComb.Location = new System.Drawing.Point(208, 32);
            this.nameOrgComb.Name = "nameOrgComb";
            this.nameOrgComb.Size = new System.Drawing.Size(237, 24);
            this.nameOrgComb.TabIndex = 0;
            this.nameOrgComb.SelectedIndexChanged += new System.EventHandler(this.nameOrgComb_SelectedIndexChanged);
            // 
            // nameOrgLabl
            // 
            this.nameOrgLabl.AutoSize = true;
            this.nameOrgLabl.Location = new System.Drawing.Point(40, 35);
            this.nameOrgLabl.Name = "nameOrgLabl";
            this.nameOrgLabl.Size = new System.Drawing.Size(123, 17);
            this.nameOrgLabl.TabIndex = 1;
            this.nameOrgLabl.Text = "Имя организации";
            // 
            // KeyDeviceLbl
            // 
            this.KeyDeviceLbl.AutoSize = true;
            this.KeyDeviceLbl.Location = new System.Drawing.Point(40, 79);
            this.KeyDeviceLbl.Name = "KeyDeviceLbl";
            this.KeyDeviceLbl.Size = new System.Drawing.Size(121, 17);
            this.KeyDeviceLbl.TabIndex = 2;
            this.KeyDeviceLbl.Text = "Ключ устройства";
            // 
            // keyDeviceComb
            // 
            this.keyDeviceComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.keyDeviceComb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.keyDeviceComb.FormattingEnabled = true;
            this.keyDeviceComb.Location = new System.Drawing.Point(208, 79);
            this.keyDeviceComb.Name = "keyDeviceComb";
            this.keyDeviceComb.Size = new System.Drawing.Size(237, 24);
            this.keyDeviceComb.TabIndex = 3;
            // 
            // KeyLicLbl
            // 
            this.KeyLicLbl.AutoSize = true;
            this.KeyLicLbl.Location = new System.Drawing.Point(43, 125);
            this.KeyLicLbl.Name = "KeyLicLbl";
            this.KeyLicLbl.Size = new System.Drawing.Size(144, 17);
            this.KeyLicLbl.TabIndex = 4;
            this.KeyLicLbl.Text = "Лицензионный ключ";
            // 
            // licKeycomb
            // 
            this.licKeycomb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.licKeycomb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.licKeycomb.FormattingEnabled = true;
            this.licKeycomb.Location = new System.Drawing.Point(208, 122);
            this.licKeycomb.Name = "licKeycomb";
            this.licKeycomb.Size = new System.Drawing.Size(237, 24);
            this.licKeycomb.TabIndex = 5;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(387, 170);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(115, 31);
            this.ok.TabIndex = 6;
            this.ok.Text = "Выдать ключ";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // btnInfCmp
            // 
            this.btnInfCmp.Location = new System.Drawing.Point(451, 32);
            this.btnInfCmp.Name = "btnInfCmp";
            this.btnInfCmp.Size = new System.Drawing.Size(51, 24);
            this.btnInfCmp.TabIndex = 7;
            this.btnInfCmp.Text = "инф";
            this.btnInfCmp.UseVisualStyleBackColor = true;
            this.btnInfCmp.Click += new System.EventHandler(this.btnInfCmp_Click);
            // 
            // btnInfDevice
            // 
            this.btnInfDevice.Location = new System.Drawing.Point(452, 79);
            this.btnInfDevice.Name = "btnInfDevice";
            this.btnInfDevice.Size = new System.Drawing.Size(50, 23);
            this.btnInfDevice.TabIndex = 8;
            this.btnInfDevice.Text = "инф";
            this.btnInfDevice.UseVisualStyleBackColor = true;
            this.btnInfDevice.Click += new System.EventHandler(this.btnInfDevice_Click);
            // 
            // btnInfKey
            // 
            this.btnInfKey.Location = new System.Drawing.Point(452, 122);
            this.btnInfKey.Name = "btnInfKey";
            this.btnInfKey.Size = new System.Drawing.Size(50, 23);
            this.btnInfKey.TabIndex = 9;
            this.btnInfKey.Text = "инф";
            this.btnInfKey.UseVisualStyleBackColor = true;
            this.btnInfKey.Click += new System.EventHandler(this.btnInfKey_Click);
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 213);
            this.Controls.Add(this.btnInfKey);
            this.Controls.Add(this.btnInfDevice);
            this.Controls.Add(this.btnInfCmp);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.licKeycomb);
            this.Controls.Add(this.KeyLicLbl);
            this.Controls.Add(this.keyDeviceComb);
            this.Controls.Add(this.KeyDeviceLbl);
            this.Controls.Add(this.nameOrgLabl);
            this.Controls.Add(this.nameOrgComb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IssueForm";
            this.Text = "Выдача ключа";
            this.Load += new System.EventHandler(this.IssueForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nameOrgComb;
        private System.Windows.Forms.Label nameOrgLabl;
        private System.Windows.Forms.Label KeyDeviceLbl;
        private System.Windows.Forms.ComboBox keyDeviceComb;
        private System.Windows.Forms.Label KeyLicLbl;
        private System.Windows.Forms.ComboBox licKeycomb;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button btnInfCmp;
        private System.Windows.Forms.Button btnInfDevice;
        private System.Windows.Forms.Button btnInfKey;
    }
}