namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class ChangeCode
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
            this.newCodeLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.changeBtn = new System.Windows.Forms.Button();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // newCodeLbl
            // 
            this.newCodeLbl.AutoSize = true;
            this.newCodeLbl.Location = new System.Drawing.Point(12, 31);
            this.newCodeLbl.Name = "newCodeLbl";
            this.newCodeLbl.Size = new System.Drawing.Size(156, 17);
            this.newCodeLbl.TabIndex = 0;
            this.newCodeLbl.Text = "Новый код устройства";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Новое значение лиц. ключа";
            // 
            // changeBtn
            // 
            this.changeBtn.Location = new System.Drawing.Point(338, 104);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(90, 29);
            this.changeBtn.TabIndex = 3;
            this.changeBtn.Text = "Применить";
            this.changeBtn.UseVisualStyleBackColor = true;
            this.changeBtn.Click += new System.EventHandler(this.changeKey_Click);
            // 
            // textCode
            // 
            this.textCode.Location = new System.Drawing.Point(209, 31);
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(219, 22);
            this.textCode.TabIndex = 4;
            // 
            // textKey
            // 
            this.textKey.Location = new System.Drawing.Point(209, 76);
            this.textKey.Name = "textKey";
            this.textKey.Size = new System.Drawing.Size(219, 22);
            this.textKey.TabIndex = 4;
            // 
            // ChangeCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 141);
            this.Controls.Add(this.textKey);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.newCodeLbl);
            this.Name = "ChangeCode";
            this.Text = "Изменить код устройства";
            this.Load += new System.EventHandler(this.ChangeCode_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label newCodeLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeBtn;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textKey;
    }
}