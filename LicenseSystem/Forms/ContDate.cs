using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOfIssuingLicKeysApplication.Forms
{
    public partial class ContDate : Form
    {
        public int keyId = 0;
        public DateTime EndDate;
        public ContDate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > EndDate)
            {
                HistoryOfKey hist = new HistoryOfKey();
                hist.KeyId = keyId;
                hist.Reason = textBox1.Text;
                hist.FromTime = EndDate;
                hist.ToTime = dateTimePicker1.Value;
                EndDate = dateTimePicker1.Value;
                SqlAcessors.HistoryKeyAcessor.AddHistory(hist);
                Close();
            }
            else
                MessageBox.Show("Неправильная дата");
        }

        private void ContDate_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            dateTimePicker1.Value = EndDate;
        }
    }
}
