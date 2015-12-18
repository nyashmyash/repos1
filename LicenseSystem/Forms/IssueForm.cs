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
    public partial class IssueForm : Form
    {
        private List<ItemCompany> listCompany;
        private List<ItemKey> listKey;
        private List<ItemDevice> listDevice;
        public IssueForm()
        {
            InitializeComponent();
        }

        private void IssueForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            LoadData();
            foreach (ItemCompany s in listCompany)
                nameOrgComb.Items.Add(s.Name);
            foreach (ItemKey k in listKey)
                licKeycomb.Items.Add(k.KeyValue);
       
        }
        private void LoadData()
        {
            listCompany = SqlAcessors.CompanyAcessor.SelCompanies();     
            listKey = SqlAcessors.KeyAcessor.SelKeys();
            listDevice = SqlAcessors.DeviceAcessor.SelDevices();
        }

        private void nameOrgComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyDeviceComb.Items.Clear();
            foreach(ItemDevice d in listDevice)
            {
                if (d.IdCompany == listCompany[nameOrgComb.SelectedIndex].Id)
                    keyDeviceComb.Items.Add(d.Code);  
            }
        }

        private void ok_Click(object sender, EventArgs e)
        {
            if (nameOrgComb.SelectedIndex != -1 && keyDeviceComb.SelectedIndex != -1 && licKeycomb.SelectedIndex != -1)
            {
                ItemKey key = listKey[licKeycomb.SelectedIndex];
                ItemCompany comp = listCompany[nameOrgComb.SelectedIndex];
                ItemDevice dev = new ItemDevice();
                foreach (ItemDevice d in listDevice)
                {
                    if (d.Code == keyDeviceComb.Items[keyDeviceComb.SelectedIndex].ToString())
                    { dev = d; break; }
                }
                if (dev.IdKey == 0)
                {
                    int cnt = SqlAcessors.CompanyAcessor.GetCountLimitedKeys(comp.Id);

                    if (key.TestMark == 0 && cnt >= comp.LimitKeys)
                    {
                        MessageBox.Show("Превышен лимит ключей!");
                        return;
                    }
                    if (SqlAcessors.DeviceAcessor.SetKey(dev.Id, key.Id))
                    { 
                        MessageBox.Show("Ключ установлен");
                        LoadData();
                    }
                }
                else
                 MessageBox.Show("У этого устройства уже есть ключ"); 
                
            }
            else
            {
                MessageBox.Show("Выбирите значения!");
                return;
            }
        }

        private void btnInfCmp_Click(object sender, EventArgs e)
        {
            if (nameOrgComb.SelectedIndex != -1)
            {
                CompanyForm fm = new CompanyForm();
                fm.currentElemId = listCompany[nameOrgComb.SelectedIndex].Id;
                fm.ShowDialog();
            }
        }

        private void btnInfDevice_Click(object sender, EventArgs e)
        {
            if (keyDeviceComb.SelectedIndex != -1) 
            {
                DeviceForm fm = new DeviceForm();
                foreach (ItemDevice d in listDevice)
                {
                    if (d.Code == keyDeviceComb.Items[keyDeviceComb.SelectedIndex].ToString())
                    {  fm.currentElemId = d.Id; break; }
                }
                fm.ShowDialog();
            }

        }

        private void btnInfKey_Click(object sender, EventArgs e)
        {
            if (licKeycomb.SelectedIndex != -1)
            {
                KeysForm fm = new KeysForm();
                fm.currentElemId = listKey[licKeycomb.SelectedIndex].Id;
                fm.ShowDialog();
            }
        }
    }
}
