using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOfIssuingLicKeysApplication.Items;

namespace SysOfIssuingLicKeysApplication.Forms
{
    public partial class ChangeCode : Form
    {
        public ItemDevice device;
        public ChangeCode()
        {
            InitializeComponent();
        }

        private void ChangeCode_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            textCode.Text = device.Code;
            textKey.Text = SqlAcessors.KeyAcessor.SelKey(device.IdKey).KeyValue;
        }

        private void changeKey_Click(object sender, EventArgs e)
        {
            if (textCode.Text.Length > 32 || textKey.Text.Length > 64)
                MessageBox.Show("Слишком длинный ключи");
            HistoryOfDevice hist = new HistoryOfDevice();
            hist.CodeValue = device.Code;
            hist.NewCodeValue = textCode.Text;
            hist.KeyValue = SqlAcessors.KeyAcessor.SelKey(device.IdKey).KeyValue;
            hist.NewKeyValue = textKey.Text;
            hist.OriginalIDCode = device.Id;
            SqlAcessors.HistoryDeviceAcessor.AddHistory(hist);
            SqlAcessors.KeyAcessor.UpdateKey(device.IdKey, textKey.Text);
            SqlAcessors.DeviceAcessor.UpdateCode(device.Id, textCode.Text);
            
            device.Code = textCode.Text;
            Close();
        }
    }
}
