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
using System.Collections;

namespace SysOfIssuingLicKeysApplication.Forms
{
    enum HeaderDeviceGrid
    {
        hdrCode = 0,
        hdrSurnameOwner = 1,
        hdrPositionOwner = 2,
      
    }
   
    public partial class DeviceForm : Form
    {
        public int currentElemId = -1;
        private int currId = 0;
        private int curSortCol = 0;
        List<ItemDevice> listDev;
        List<ItemCompany> complist;
        ToolStripMenuItem toolStripItem1 = new ToolStripMenuItem();

        public DeviceForm()
        {
            InitializeComponent();
        }

        private void changeCode_Click(object sender, EventArgs e)
        {
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                MessageBox.Show("У вас нет прав просматривать лицензионные ключи");
                return;
            }
            int id = 0;
            id = listDev[currId].IdKey;
            if (id == 0)
            {
                MessageBox.Show("У этого устройства нет ключа!"); return;
            }
            ChangeCode fm = new ChangeCode();
            fm.device = listDev[currId];
            fm.ShowDialog();
            dataDevice.Invalidate();
            setValues(fm.device);
        }

        private void Find_Click(object sender, EventArgs e)
        {
            int indx = 0;
            foreach (ItemDevice d in listDev)
            {
                dataDevice.Rows[indx].Visible = true;
                indx++;
            }    
        }
        private void setValues(ItemDevice dev)
        {
            textCodeDev.Text = dev.Code;
            textSurn.Text = dev.SurnameOwner;
            textPos.Text = dev.PositionOwner;
            int i = 0;
            foreach (ItemCompany c in complist)
            {
                if (dev.IdCompany == c.Id)
                    orgCombBox.SelectedIndex = i;
                i++;
            }
            
        }
        private ItemDevice getValues()
        {
            bool err = false;
            string strerr = "Неправильные данные:";
            if (String.IsNullOrEmpty(textCodeDev.Text) || textCodeDev.Text.Length > 32)
            {
                strerr += " код устройства";
                err = true;
            }
            if (String.IsNullOrEmpty(textSurn.Text) || textSurn.Text.Length > 128)
            {
                strerr += " фамилия владельца";
                err = true;
            }
            if (String.IsNullOrEmpty(textPos.Text) || textPos.Text.Length > 128)
            {
                strerr += " должность владельца"; err = true;
            }
            if (err)
            {
                MessageBox.Show(strerr);
                return new ItemDevice() { Id = -1 };
            }
            return new ItemDevice { Code = textCodeDev.Text, SurnameOwner = textSurn.Text, PositionOwner = textPos.Text };
  
        }
        private void setHeaders()
        {
            dataDevice.Columns[(int)HeaderDeviceGrid.hdrCode].HeaderCell.Value = "Ключ устр-ва";
            dataDevice.Columns[(int)HeaderDeviceGrid.hdrCode].Width = 210;
            dataDevice.Columns[(int)HeaderDeviceGrid.hdrSurnameOwner].HeaderCell.Value = "Фамилия вл-ца";
            dataDevice.Columns[(int)HeaderDeviceGrid.hdrPositionOwner].HeaderCell.Value = "Должность вл-ца";
 
        }

        private void dataDevice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            setValues(listDev[e.RowIndex]);
            currId = e.RowIndex;
            
        }
        private void LoadData()
        {
            dataDevice.Columns.Clear();
            orgCombBox.Items.Clear();
            complist = SqlAcessors.CompanyAcessor.SelCompanies();
            foreach (ItemCompany c in complist)
                orgCombBox.Items.Add(c.Name);
            
          
            if (currentElemId == -1)
                listDev = SqlAcessors.DeviceAcessor.SelDevices();
            else
            {
                listDev = new List<ItemDevice>();
                listDev.Add(SqlAcessors.DeviceAcessor.SelDevice(currentElemId));
                combOperatons.Visible = false;
                btnMake.Visible = false;
                changeCode.Visible = false;
            }
            dataDevice.DataSource = listDev;
            if (listDev.Count != 0)
            {
                setValues(listDev[0]);
                setHeaders();
                currId = 0;
            }
            Sort(curSortCol);
        }

        private void Sort(int ColumnIndex)
        {
            if (ColumnIndex == 0)
            {
                var sort = from s in listDev
                           orderby s.Code
                           select s;
                int i = 0;
                foreach (ItemDevice d in sort)
                {
                    ItemDevice temp = new ItemDevice(listDev[i]);
                    listDev[i] = new ItemDevice(d);
                    i++;
                }
              
            }
            if (ColumnIndex == 1)
            {
                var sort = from s in listDev
                           orderby s.SurnameOwner
                           select s;
                int i = 0;
                foreach (ItemDevice d in sort)
                {
                    ItemDevice temp = new ItemDevice(listDev[i]);
                    listDev[i] = new ItemDevice(d);
                    i++;
                }
              
            }
            if (ColumnIndex == 2)
            {
                var sort = from s in listDev
                           orderby s.PositionOwner
                           select s;
                int i = 0;
                foreach (ItemDevice d in sort)
                {
                    ItemDevice temp = new ItemDevice(listDev[i]);
                    listDev[i] = new ItemDevice(d);
                    i++;
                }
 
            }
        }
        private void DeviceForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            orgCombBox.Enabled = false;
            combOperatons.Items.Add("Просмотр");
            combOperatons.Items.Add("Изменить");
            combOperatons.Items.Add("Добавить");
            combOperatons.Items.Add("Удалить");
            combOperatons.SelectedIndex = 0;
          
            dataDevice.ColumnHeaderMouseClick += (o, g) =>
            {
                DataGridView grid = (o as DataGridView);
                Sort(g.ColumnIndex);
                curSortCol = g.ColumnIndex;
                grid.Invalidate();
                //grid.Sort(new RowComparer(SortOrder.Descending));
            };
           
            LoadData(); 
        }

        private void btnOrg_Click(object sender, EventArgs e)
        {
            CompanyForm fm = new CompanyForm();
            fm.currentElemId = listDev[currId].IdCompany;
            fm.ShowDialog();
        }

        private void keyBtn_Click(object sender, EventArgs e)
        {
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                MessageBox.Show("У вас нет прав просматривать лицензионные ключи");
                return;
            }
            int id = 0;
            id = listDev[currId].IdKey;
            if (id == 0)
            { 
                MessageBox.Show("У этого устройства нет ключа!"); return; 
            }
            KeysForm fm = new KeysForm();
            fm.currentElemId = id;
            fm.ShowDialog();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {

            if (combOperatons.SelectedIndex == 1)
            {
                ItemDevice itm = getValues();
                if (itm.Id != -1)
                {
                    itm.Id = listDev[currId].Id;
                    if (SqlAcessors.DeviceAcessor.UpdateDevice(itm))
                    {
                        MessageBox.Show("Изменены данные устройства");
                        LoadData();
                    }
                    return;
                }
            }
            if (combOperatons.SelectedIndex == 2)
            {
                ItemDevice itm = getValues();
                if (itm.Id != -1)
                {
                    itm.IdCompany = complist[orgCombBox.SelectedIndex].Id;
                    if (SqlAcessors.DeviceAcessor.AddDevice(itm))
                    {
                        MessageBox.Show("Добавлено устройство ");
                        LoadData();
                        ItemDevice dev = new ItemDevice();
                        setValues(dev);
                    }
                    return;
                }
            }
            if (combOperatons.SelectedIndex == 3)
            {
                if (SqlAcessors.DeviceAcessor.DelDevice(listDev[currId].Id))
                {
                    MessageBox.Show("Удалено устройство");
                    LoadData();
                }
                return;

            }

        }
        private void changeRO(bool ro)
        {
            if (combOperatons.SelectedIndex == 2)
                textCodeDev.ReadOnly = false;
            else
                textCodeDev.ReadOnly = true;
            textSurn.ReadOnly = ro;
            textPos.ReadOnly = ro;
        }

        private void combOperatons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combOperatons.SelectedIndex == 0 || combOperatons.SelectedIndex == 3)
                changeRO(true); 
            else
                changeRO(false);
            if (combOperatons.SelectedIndex == 2)
            {
                orgCombBox.Enabled = true;
                ItemDevice dev = new ItemDevice();
                setValues(dev);
                dataDevice.Enabled = false;
               
                orgCombBox.SelectedIndex = 0;
                return;
            }
            else
                dataDevice.Enabled = true;

            if (listDev!=null)setValues(listDev[currId]);
            orgCombBox.Enabled = false;
        }
    
    }
}
