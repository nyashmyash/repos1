namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.userName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboGroups = new System.Windows.Forms.ComboBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textPassw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(116, 140);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 33);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(197, 140);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 33);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Отмена";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // userName
            // 
            this.userName.AutoSize = true;
            this.userName.Location = new System.Drawing.Point(12, 34);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(129, 17);
            this.userName.TabIndex = 2;
            this.userName.Text = "имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "группа";
            this.label3.Visible = false;
            // 
            // comboGroups
            // 
            this.comboGroups.FormattingEnabled = true;
            this.comboGroups.Location = new System.Drawing.Point(149, 110);
            this.comboGroups.Name = "comboGroups";
            this.comboGroups.Size = new System.Drawing.Size(121, 24);
            this.comboGroups.TabIndex = 5;
            this.comboGroups.Visible = false;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(149, 31);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(121, 22);
            this.textName.TabIndex = 6;
            // 
            // textPassw
            // 
            this.textPassw.Location = new System.Drawing.Point(149, 73);
            this.textPassw.Name = "textPassw";
            this.textPassw.Size = new System.Drawing.Size(121, 22);
            this.textPassw.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 182);
            this.Controls.Add(this.textPassw);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.comboGroups);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(500, 600);
            this.Name = "Login";
            this.Text = "Войти";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label userName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboGroups;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textPassw;
    }
}