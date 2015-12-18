using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOfIssuingLicKeysApplication.Items;

namespace SysOfIssuingLicKeysApplication
{
    enum HeaderCompGrid 
    {
        hdrName = 0,
        hdrNumb = 1,
        hdrLimit = 2,
        hdrCountAll = 3,
        hdrCountActive = 4
    }
    public partial class CompanyForm : Form
    {
        public int currentElemId = -1;
        private int indx = 0;
        private List<ItemCompany> listComp;
        private int curSortCol = 0;
        public CompanyForm()
        {
            InitializeComponent();     
        }

        private void FindComp_Click(object sender, EventArgs e)
        {
            int indx = 0;
            foreach (ItemCompany c in listComp)
            {
               dataComp.Rows[indx].Visible = true;
               indx++;
            }    
                            
        }
        private ItemCompany getValues()
        {
            bool err = false;
            string strerr = "Неправильные данные:";
           
        
            int limit = 0;
            if (String.IsNullOrEmpty(textBoxName.Text) || textBoxName.Text.Length > 256)
            {
                strerr += " название компании";
                err = true;
            }
            if (String.IsNullOrEmpty(textBoxNameContract.Text) || textBoxNameContract.Text.Length > 128)
            {
                strerr += " номер договора";
                err = true;
            }
            if (String.IsNullOrEmpty(textBoxLimit.Text) || !Int32.TryParse(textBoxLimit.Text, out limit))
            {
                strerr += " лимит"; err = true;
            }
            if (err)
            {
                MessageBox.Show(strerr);
                return new ItemCompany() { Id = -1};
            }
            return new ItemCompany { LimitKeys = limit, Name = textBoxName.Text, NumberContract = textBoxNameContract.Text };
        }
        private void setValues(ItemCompany comp)
        {
            textBoxLimit.Text = comp.LimitKeys.ToString();
            textBoxName.Text  = comp.Name;
            textBoxNameContract.Text = comp.NumberContract;
            valCntKeys.Text = SqlAcessors.CompanyAcessor.GetCount(comp.Id).ToString();
        }
        private void changeRO(bool ro)
        {
            textBoxLimit.ReadOnly = ro;
            textBoxName.ReadOnly = ro;
            textBoxNameContract.ReadOnly = ro;
        }
        private void setHeaders()
        {
            dataComp.Columns[(int)HeaderCompGrid.hdrName].HeaderCell.Value = "Имя организации";
            dataComp.Columns[(int)HeaderCompGrid.hdrNumb].HeaderCell.Value = "Номер договора";
            dataComp.Columns[(int)HeaderCompGrid.hdrLimit].HeaderCell.Value = "Лимит ключей"; 
        }
        /*private void RemoveNewHeaders()
        {
            if (dataComp.Columns.Contains("cntKeys"))
                dataComp.Columns.Remove("cntKeys");
            if (dataComp.Columns.Contains("cntKeysActive"))
                dataComp.Columns.Remove("cntKeysActive");
        }*/
        private void AddNewHeaders()
        {
            dataComp.Columns.Add("cntKeys", "Кол-во выданных ключей ");
            dataComp.Columns.Add("cntKeysActive", "Кол-во активных тест. ключей");
        }
        private void Find_Click(object sender, EventArgs e)
        {
           int indx =0;
           foreach(ItemCompany c in listComp)
           {
               if (!c.Name.Contains(textBoxName.Text))
               {
                   dataComp.Rows[indx].Visible = false;
               }
               indx++;
           }
           dataComp.Invalidate();
        }

        private void dataComp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
           
            setValues(listComp[e.RowIndex]);
            valCntKeys.Text = dataComp.Rows[e.RowIndex].Cells[(int)HeaderCompGrid.hdrCountAll].Value.ToString();
            cntActivTestKeys.Text = dataComp.Rows[e.RowIndex].Cells[(int)HeaderCompGrid.hdrCountActive].Value.ToString();
            indx = e.RowIndex;
        }
        private void LoadData()
        {
            dataComp.Columns.Clear();
            if (currentElemId == -1)
                listComp = SqlAcessors.CompanyAcessor.SelCompanies();
            else
            {
                listComp = new List<ItemCompany>();
                listComp.Add(SqlAcessors.CompanyAcessor.SelComp(currentElemId));
                FindComp.Visible = false;
                Find.Visible = false;
                combOperatons.Visible = false;
                btnMake.Visible = false;
               // currentElemId = 0;
            }
            dataComp.DataSource = listComp;
            
            if (listComp.Count != 0)
            {
                int i = 0;
                AddNewHeaders();

                foreach (ItemCompany c in listComp)
                {
                    dataComp.Rows[i].Cells[(int)HeaderCompGrid.hdrCountAll].Value = SqlAcessors.CompanyAcessor.GetCount(c.Id).ToString();
                    dataComp.Rows[i].Cells[(int)HeaderCompGrid.hdrCountActive].Value = SqlAcessors.CompanyAcessor.GetCountsWithTestKeys(c.Id).ToString();
                    i++;
                }
                setHeaders();
                setValues(listComp[0]);
                indx = 0;
            }
            Sort(curSortCol);
        }
        private void CompanyForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            combOperatons.Items.Add("Просмотр");
            combOperatons.Items.Add("Изменить");
            combOperatons.Items.Add("Добавить");
            combOperatons.Items.Add("Удалить");
            combOperatons.SelectedIndex = 0;

            dataComp.ColumnHeaderMouseClick += (o, g) =>
            {
                DataGridView grid = (o as DataGridView);
                Sort(g.ColumnIndex);
                curSortCol = g.ColumnIndex;
                grid.Invalidate();
            };
            LoadData();
        }
        /*   hdrName = 0,
        hdrNumb = 1,
        hdrLimit = 2,
        hdrCountAll = 3,
        hdrCountActive = 4*/
        private void Sort(int ColumnIndex)
        {
            if (ColumnIndex == (int)HeaderCompGrid.hdrName)
            {
                var sort = from s in listComp
                           orderby s.Name
                           select s;
                int i = 0;
                foreach (ItemCompany d in sort)
                {
                    ItemCompany temp = new ItemCompany(listComp[i]);
                    listComp[i] = new ItemCompany(d);
                    i++;
                }

            }
            if (ColumnIndex == (int)HeaderCompGrid.hdrNumb)
            {
                var sort = from s in listComp
                           orderby s.NumberContract
                           select s;
                int i = 0;
                foreach (ItemCompany d in sort)
                {
                    ItemCompany temp = new ItemCompany(listComp[i]);
                    listComp[i] = new ItemCompany(d);
                    i++;
                }

            }
            if (ColumnIndex == (int)HeaderCompGrid.hdrLimit)
            {
                var sort = from s in listComp
                           orderby s.LimitKeys
                           select s;
                int i = 0;
                foreach (ItemCompany d in sort)
                {
                    ItemCompany temp = new ItemCompany(listComp[i]);
                    listComp[i] = new ItemCompany(d);
                    i++;
                }

            }
           /* if (ColumnIndex == 3)
            {
                var sort = from s in listComp
                           orderby s.PositionOwner
                           select s;
                int i = 0;
                foreach (ItemCompany d in sort)
                {
                    ItemCompany temp = new ItemCompany(listComp[i]);
                    listComp[i] = new ItemCompany(d);
                    i++;
                }

            }
            if (ColumnIndex == 4)
            {
                var sort = from s in listComp
                           orderby s.PositionOwner
                           select s;
                int i = 0;
                foreach (ItemCompany d in sort)
                {
                    ItemCompany temp = new ItemCompany(listComp[i]);
                    listComp[i] = new ItemCompany(d);
                    i++;
                }

            }*/
        }
        private void btnMake_Click(object sender, EventArgs e)
        {
           
            if (combOperatons.SelectedIndex == 1)
            {
                ItemCompany itm = getValues();
                if (itm.Id != -1)
                {
                    itm.Id = listComp[indx].Id;
                    if (SqlAcessors.CompanyAcessor.UpdateCompany(itm))
                    {
                        MessageBox.Show("Изменены данные компании");
                        LoadData();                     
                    }
                    return;
                }
            }
            if (combOperatons.SelectedIndex == 2)
            {
                ItemCompany itm = getValues();
                if (itm.Id != -1)
                {
                    if (SqlAcessors.CompanyAcessor.AddCompany(itm))
                    {
                        MessageBox.Show("Добавлена компания");
                        LoadData();
                        ItemCompany comp = new ItemCompany();
                        setValues(comp);
                    }
                    return;
                }
            }
            if (combOperatons.SelectedIndex == 3)
            {
                if (SqlAcessors.CompanyAcessor.DelCompany(listComp[indx].Id))
                {
                    MessageBox.Show("Удалена компания");
                    LoadData();            
                }
                return;

            }


        }

        private void combOperatons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combOperatons.SelectedIndex == 0 || combOperatons.SelectedIndex == 3)
                changeRO(true); 
            else
                changeRO(false);
            if (combOperatons.SelectedIndex == 2)
            {
                ItemCompany comp = new ItemCompany();
                setValues(comp);
                dataComp.Enabled = false;
                return;
            }
            else
                dataComp.Enabled = true;
            if (listComp!=null) setValues(listComp[indx]);
        }

    }
}
