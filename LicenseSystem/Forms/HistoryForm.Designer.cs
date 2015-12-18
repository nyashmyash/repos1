namespace SysOfIssuingLicKeysApplication.Forms
{
    partial class HistoryForm
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
            this.dataGridHistory = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridHistory
            // 
            this.dataGridHistory.AllowUserToAddRows = false;
            this.dataGridHistory.AllowUserToDeleteRows = false;
            this.dataGridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistory.Location = new System.Drawing.Point(3, 12);
            this.dataGridHistory.Name = "dataGridHistory";
            this.dataGridHistory.ReadOnly = true;
            this.dataGridHistory.RowTemplate.Height = 24;
            this.dataGridHistory.Size = new System.Drawing.Size(904, 472);
            this.dataGridHistory.TabIndex = 0;
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 489);
            this.Controls.Add(this.dataGridHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HistoryForm";
            this.Text = "История";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridHistory;
    }
}