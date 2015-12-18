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
    enum HeaderKeyGrid
    {
        hdrKeyVal = 0,
        hdrDateStart = 1,
        hdrDateEnd = 2,
        hdrTestMark = 3,
    }
    public partial class KeysForm : Form
    {

        public int currentElemId = -1;
        private int currId = 0;
        List<ItemKey> listKeys;
        private int curSortCol = 0;
        public KeysForm()
        {
            InitializeComponent();
        }

        private void KeysForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            combOperatons.Items.Add("Просмотр");
            //combOperatons.Items.Add("Изменить");
            combOperatons.Items.Add("Добавить");
            combOperatons.Items.Add("Удалить");
            combOperatons.SelectedIndex = 0;
            dataKeys.ColumnHeaderMouseClick += (o, g) =>
            {
                DataGridView grid = (o as DataGridView);
                Sort(g.ColumnIndex);
                curSortCol = g.ColumnIndex;
                grid.Invalidate();
            };
            LoadData(); 
        }

        private void AllKeys_Click(object sender, EventArgs e)
        {
            int indx = 0;
            foreach (ItemKey d in listKeys)
            {
                dataKeys.Rows[indx].Visible = true;
                indx++;
            }                    
        }
        private void setHeaders()
        {
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                dataKeys.Columns[(int)HeaderKeyGrid.hdrKeyVal].Visible = false;
    
            }
            dataKeys.Columns[(int)HeaderKeyGrid.hdrKeyVal].HeaderCell.Value = "Значение ключа";
            dataKeys.Columns[(int)HeaderKeyGrid.hdrKeyVal].Width = 240;
            dataKeys.Columns[(int)HeaderKeyGrid.hdrDateStart].HeaderCell.Value = "Дата начала лицензионного периода";
            dataKeys.Columns[(int)HeaderKeyGrid.hdrDateEnd].HeaderCell.Value = "Дата окончания лицензионного периода";
            dataKeys.Columns[(int)HeaderKeyGrid.hdrTestMark].HeaderCell.Value = "Тестовый ключ";
        }
        private void LoadData()
        {
            if (currentElemId == -1)
                listKeys= SqlAcessors.KeyAcessor.SelKeys();
            else
            {
                listKeys = new List<ItemKey>();
                listKeys.Add(SqlAcessors.KeyAcessor.SelKey(currentElemId));
                btnAllKeys.Visible = false;
                btnFindKey.Visible = false;
                btnFullFinder.Visible = false;
                textFindKey.Visible = false;
                findKeylbl.Visible = false;
                combOperatons.Visible = false;
                btnMake.Visible = false;
            }
            dataKeys.DataSource = listKeys;
           

            if (listKeys.Count != 0)
            {
                setValues(listKeys[0]);
                currId = 0;
                setHeaders();
                
            }
            Sort(curSortCol); 
        }
        private void setValues(ItemKey k)
        {
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                textBoxKeyName.Visible = false;
            }
            textBoxKeyName.Text = k.KeyValue;
            dateStart.Value = (DateTime)k.DateStart;
            dateEnd.Value = (DateTime)k.DateEnd;
            isTest.Checked = Convert.ToBoolean(k.TestMark);
        }

        private void dataKeys_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            setValues(listKeys[e.RowIndex]);
            currId = e.RowIndex;
        }

        private void findKey_Click(object sender, EventArgs e)
        {
            if (combOperatons.SelectedIndex != 0)
                return;
            if (textFindKey.Text == "")
            {
                MessageBox.Show("Введите ключ!");
                return;
            }
            int indx = 0;
            ItemKey key = SqlAcessors.KeyAcessor.FindKeys(textFindKey.Text);
            if (key !=null )
                foreach (ItemKey k in listKeys)
                {                    
                    if(k.Id!=key.Id)
                        dataKeys.Rows[indx].Visible = false;
                    indx++;
                }       
               
            
        }

        private void FullFinder_Click(object sender, EventArgs e)
        {
            if (combOperatons.SelectedIndex != 0)
                return;
            Finder frm = new Finder();
            frm.listKeys = new List<ItemKey>();
            frm.ShowDialog();
            if (frm.listKeys.Count!=0)
            {
                CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[dataKeys.DataSource];
                currencyManager1.SuspendBinding();
             
                for (int j = 0; j < dataKeys.Rows.Count; j++)
                    if  (dataKeys.Rows[j].Visible) dataKeys.Rows[j].Visible = false;
                      
                foreach (ItemKey k in frm.listKeys)
                {
                    for (int j = 0; j < dataKeys.Rows.Count; j++ )
                    {
                        if (listKeys[j].Id == k.Id)
                        {
                            dataKeys.Rows[j].Visible = true;
                            break; 
                        }
                    }            
                }
                currencyManager1.ResumeBinding();
                setValues(frm.listKeys[0]);
                currId = 0;
            }
            dataKeys.Invalidate();

        }
        private void Sort(int ColumnIndex)
        {
            if (ColumnIndex == (int)HeaderCompGrid.hdrName)
            {
                var sort = from s in listKeys
                           orderby s.KeyValue
                           select s;
                int i = 0;
                foreach (ItemKey d in sort)
                {
                    ItemKey temp = new ItemKey(listKeys[i]);
                    listKeys[i] = new ItemKey(d);
                    i++;
                }

            }
            if (ColumnIndex == (int)HeaderCompGrid.hdrNumb)
            {
                var sort = from s in listKeys
                           orderby s.DateStart
                           select s;
                int i = 0;
                foreach (ItemKey d in sort)
                {
                    ItemKey temp = new ItemKey(listKeys[i]);
                    listKeys[i] = new ItemKey(d);
                    i++;
                }

            }
            if (ColumnIndex == (int)HeaderCompGrid.hdrLimit)
            {
                var sort = from s in listKeys
                           orderby s.DateEnd
                           select s;
                int i = 0;
                foreach (ItemKey d in sort)
                {
                    ItemKey temp = new ItemKey(listKeys[i]);
                    listKeys[i] = new ItemKey(d);
                    i++;
                }

            }
            if (ColumnIndex == 3)
             {
                 var sort = from s in listKeys
                            orderby s.TestMark
                            select s;
                 int i = 0;
                 foreach (ItemKey d in sort)
                 {
                     ItemKey temp = new ItemKey(listKeys[i]);
                     listKeys[i] = new ItemKey(d);
                     i++;
                 }

             }
         
        }
        private void btnCont_Click(object sender, EventArgs e)
        {
            if (combOperatons.SelectedIndex != 0)
                return;
            ContDate d = new ContDate();
            d.keyId = listKeys[currId].Id;
            d.EndDate = (DateTime)listKeys[currId].DateEnd;
            d.ShowDialog();
            listKeys[currId].DateEnd = d.EndDate;
            setValues(listKeys[currId]);
            dataKeys.Invalidate();
        }
        private void changeRO(bool ro)
        {
            textBoxKeyName.ReadOnly = ro;
            dateStart.Enabled = !ro;
            dateEnd.Enabled = !ro ;
            isTest.AutoCheck = !ro;

        }
        private void combOperatons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combOperatons.SelectedIndex == 0 || combOperatons.SelectedIndex == 2)
                changeRO(true);
            else
                changeRO(false);
            if (combOperatons.SelectedIndex == 1)
            {
                ItemKey keys = new ItemKey();
                setValues(keys);
                dataKeys.Enabled = false;
                return;
            }
            else
                dataKeys.Enabled = true;
            if (listKeys != null) setValues(listKeys[currId]);
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            /*if (combOperatons.SelectedIndex == 1)
            {
                ItemKey itm = getValues();
                if (itm.Id != -1)
                {
                    itm.Id = listKeys[currId].Id;
                    if (SqlAcessors.KeyAcessor.UpdateKey(itm))
                    {
                        MessageBox.Show("Изменены данные ключа");
                        LoadData();
                    }
                    return;
                }
            }*/
            if (combOperatons.SelectedIndex == 1)
            {
                ItemKey itm = getValues();
                if (itm.Id != -1)
                {
                    if (SqlAcessors.KeyAcessor.AddKey(itm))
                    {
                        MessageBox.Show("Добавлен ключ");
                        LoadData();
                        ItemKey keys = new ItemKey();
                        setValues(keys);
                    }
                    return;
                }
            }
            if (combOperatons.SelectedIndex == 2)
            {
                if (SqlAcessors.KeyAcessor.DelKey(listKeys[currId].Id))
                {
                    MessageBox.Show("Удален ключ");
                    LoadData();
                }
                return;

            }

        }

        private ItemKey getValues()
        {
            bool err = false;
            string strerr = "Неправильные данные:";
            if (String.IsNullOrEmpty(textBoxKeyName.Text) || textBoxKeyName.Text.Length>64)
            {
                strerr += " лецинзионный ключ";
                err = true;
            }
            if (dateStart.Value.Year == 1)
            {
                strerr += " дата начала периода";
                err = true;
            }
            if (dateEnd.Value.Year == 1)
            {
                strerr += " дата конца периода"; err = true;
            }
           
            if (err)
            {
                MessageBox.Show(strerr);
                return new ItemKey() { Id = -1 };
            }
            return new ItemKey { KeyValue = textBoxKeyName.Text, DateStart = dateStart.Value, DateEnd = dateEnd.Value, TestMark = Convert.ToInt32(isTest.Checked) };

        }

        private void dataKeys_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == (int)HeaderKeyGrid.hdrTestMark)
            {
             
                e.Value = listKeys[e.RowIndex].TestMark > 0 ? "Да" : "Нет";
            }
        }

    }
}
