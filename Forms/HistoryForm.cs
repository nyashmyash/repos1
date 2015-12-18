using SysOfIssuingLicKeysApplication.Items;
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
    public partial class HistoryForm : Form
    {
        public int frmType = 0;
        private List<ItemsHistoryDevice> histDevice;
        private List<ItemsHistoryKey> histKey;

        public HistoryForm()
        {
            InitializeComponent();
        }
        private void setHeadersKey()
        {
            dataGridHistory.Columns[0].HeaderCell.Value = "Значение ключа";
            dataGridHistory.Columns[0].Width = 200;
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                dataGridHistory.Columns[0].Visible = false;

            }
            dataGridHistory.Columns[1].HeaderCell.Value = "Старая дата";
            dataGridHistory.Columns[2].HeaderCell.Value = "Дата по которую продлевали";
            dataGridHistory.Columns[3].HeaderCell.Value = "Причина";
            dataGridHistory.Columns[3].Width = 350;
            dataGridHistory.Columns[4].HeaderCell.Value = "Количество дней";
 
 
        }
        private void setHeadersDevice()
        {
           
            dataGridHistory.Columns[0].HeaderCell.Value = "Код устр-ва";
            dataGridHistory.Columns[1].HeaderCell.Value = "Новый код устр-ва";
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                dataGridHistory.Columns[2].Visible = false;
               
            }
            dataGridHistory.Columns[2].HeaderCell.Value = "Лиц. ключ";
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                dataGridHistory.Columns[3].Visible = false;
       
            }
            dataGridHistory.Columns[3].HeaderCell.Value = "Новый лиц. ключ";
            for  (int i = 0; i < 4; i++)
            {
                dataGridHistory.Columns[i].Width = 212;
            }


        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            if (frmType == 0)
            {
                histDevice = SqlAcessors.HistoryDeviceAcessor.SelHistory();
                dataGridHistory.DataSource = histDevice;
                setHeadersDevice();
            }
            if (frmType == 1)
            {
                histKey = SqlAcessors.HistoryKeyAcessor.SelHistory(0);
                dataGridHistory.DataSource = histKey;
                setHeadersKey();
            }
           
           
        }
    }
}
