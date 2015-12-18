namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class RightsForm
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
            this.checkedRights = new System.Windows.Forms.CheckedListBox();
            this.userComb = new System.Windows.Forms.ComboBox();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.RightsLbl = new System.Windows.Forms.Label();
            this.groupsLbl = new System.Windows.Forms.Label();
            this.comboGroups = new System.Windows.Forms.ComboBox();
            this.setRights = new System.Windows.Forms.Button();
            this.combGrUser = new System.Windows.Forms.ComboBox();
            this.checkIsRightsGroup = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassw = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxGroup = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.combOperatons = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkedRights
            // 
            this.checkedRights.FormattingEnabled = true;
            this.checkedRights.Items.AddRange(new object[] {
            "Право подключаться к системе",
            "Право редактировать информацию",
            "Право видеть значение лицензионного ключа",
            "Право выдавать лицензионный ключ",
            "Право выдавать тестовый лицензионный ключ",
            "Право редактировать роли"});
            this.checkedRights.Location = new System.Drawing.Point(12, 137);
            this.checkedRights.Name = "checkedRights";
            this.checkedRights.Size = new System.Drawing.Size(348, 174);
            this.checkedRights.TabIndex = 0;
            // 
            // userComb
            // 
            this.userComb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.userComb.FormattingEnabled = true;
            this.userComb.Location = new System.Drawing.Point(174, 18);
            this.userComb.Name = "userComb";
            this.userComb.Size = new System.Drawing.Size(186, 24);
            this.userComb.TabIndex = 1;
            this.userComb.SelectedIndexChanged += new System.EventHandler(this.userComb_SelectedIndexChanged);
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.Location = new System.Drawing.Point(22, 21);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(101, 17);
            this.userNameLbl.TabIndex = 2;
            this.userNameLbl.Text = "Пользователь";
            // 
            // RightsLbl
            // 
            this.RightsLbl.AutoSize = true;
            this.RightsLbl.Location = new System.Drawing.Point(12, 114);
            this.RightsLbl.Name = "RightsLbl";
            this.RightsLbl.Size = new System.Drawing.Size(217, 17);
            this.RightsLbl.TabIndex = 2;
            this.RightsLbl.Text = "Права групп или пользователя:";
            // 
            // groupsLbl
            // 
            this.groupsLbl.AutoSize = true;
            this.groupsLbl.Location = new System.Drawing.Point(22, 55);
            this.groupsLbl.Name = "groupsLbl";
            this.groupsLbl.Size = new System.Drawing.Size(153, 17);
            this.groupsLbl.TabIndex = 2;
            this.groupsLbl.Text = "Группы пользователя";
            // 
            // comboGroups
            // 
            this.comboGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboGroups.FormattingEnabled = true;
            this.comboGroups.Location = new System.Drawing.Point(9, 21);
            this.comboGroups.Name = "comboGroups";
            this.comboGroups.Size = new System.Drawing.Size(212, 24);
            this.comboGroups.TabIndex = 3;
            this.comboGroups.SelectedIndexChanged += new System.EventHandler(this.comboGroups_SelectedIndexChanged);
            // 
            // setRights
            // 
            this.setRights.Location = new System.Drawing.Point(15, 82);
            this.setRights.Name = "setRights";
            this.setRights.Size = new System.Drawing.Size(160, 29);
            this.setRights.TabIndex = 5;
            this.setRights.Text = "Установить права";
            this.setRights.UseVisualStyleBackColor = true;
            this.setRights.Click += new System.EventHandler(this.setRights_Click);
            // 
            // combGrUser
            // 
            this.combGrUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combGrUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.combGrUser.FormattingEnabled = true;
            this.combGrUser.Location = new System.Drawing.Point(174, 52);
            this.combGrUser.Name = "combGrUser";
            this.combGrUser.Size = new System.Drawing.Size(186, 24);
            this.combGrUser.TabIndex = 3;
            // 
            // checkIsRightsGroup
            // 
            this.checkIsRightsGroup.AutoSize = true;
            this.checkIsRightsGroup.Location = new System.Drawing.Point(27, 46);
            this.checkIsRightsGroup.Name = "checkIsRightsGroup";
            this.checkIsRightsGroup.Size = new System.Drawing.Size(203, 21);
            this.checkIsRightsGroup.TabIndex = 7;
            this.checkIsRightsGroup.Text = "Работать с правами групп";
            this.checkIsRightsGroup.UseVisualStyleBackColor = true;
            this.checkIsRightsGroup.CheckedChanged += new System.EventHandler(this.checkIsRightsGroup_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkIsRightsGroup);
            this.groupBox1.Controls.Add(this.comboGroups);
            this.groupBox1.Location = new System.Drawing.Point(411, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 73);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Все группы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(123, 29);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(117, 22);
            this.textBoxLogin.TabIndex = 11;
            // 
            // textBoxPassw
            // 
            this.textBoxPassw.Location = new System.Drawing.Point(123, 66);
            this.textBoxPassw.Name = "textBoxPassw";
            this.textBoxPassw.Size = new System.Drawing.Size(117, 22);
            this.textBoxPassw.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxLogin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxPassw);
            this.groupBox2.Location = new System.Drawing.Point(455, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создать пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBoxGroup);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(455, 243);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 56);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Создать группу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя";
            // 
            // textBoxGroup
            // 
            this.textBoxGroup.Location = new System.Drawing.Point(123, 24);
            this.textBoxGroup.Name = "textBoxGroup";
            this.textBoxGroup.Size = new System.Drawing.Size(117, 22);
            this.textBoxGroup.TabIndex = 11;
            // 
            // btnMake
            // 
            this.btnMake.Location = new System.Drawing.Point(607, 18);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(95, 24);
            this.btnMake.TabIndex = 17;
            this.btnMake.Text = "Выполнить";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // combOperatons
            // 
            this.combOperatons.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combOperatons.FormattingEnabled = true;
            this.combOperatons.Location = new System.Drawing.Point(420, 18);
            this.combOperatons.Name = "combOperatons";
            this.combOperatons.Size = new System.Drawing.Size(181, 24);
            this.combOperatons.TabIndex = 16;
            // 
            // RightsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 327);
            this.Controls.Add(this.btnMake);
            this.Controls.Add(this.combOperatons);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.setRights);
            this.Controls.Add(this.combGrUser);
            this.Controls.Add(this.RightsLbl);
            this.Controls.Add(this.groupsLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.userComb);
            this.Controls.Add(this.checkedRights);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "RightsForm";
            this.Text = "Менеджер прав пользователей";
            this.Load += new System.EventHandler(this.RightsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedRights;
        private System.Windows.Forms.ComboBox userComb;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label RightsLbl;
        private System.Windows.Forms.Label groupsLbl;
        private System.Windows.Forms.ComboBox comboGroups;
        private System.Windows.Forms.Button setRights;
        private System.Windows.Forms.ComboBox combGrUser;
        private System.Windows.Forms.CheckBox checkIsRightsGroup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.ComboBox combOperatons;
    }
}