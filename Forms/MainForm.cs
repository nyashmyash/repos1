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
    enum HeaderMainFromGrid
    {
        hdrNameKey = 0,
        hdrTest= 1,
        hdrOwnerSur = 2,
        hdrOwnerPos = 3,
        hdrNameComp = 4,
        hdrNumbContr = 5,
        hdrLimitKeys = 6 
    }
    public partial class MainForm : Form
    {
        List<SqlAcessors.SelectAllInfAboutKey> mainList;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CompMenuItem_Click(object sender, EventArgs e)
        {
            CompanyForm fm = new CompanyForm();
            fm.ShowDialog();
        }

        private void KeysMenuItem_Click(object sender, EventArgs e)
        {
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                MessageBox.Show("У вас нет прав просматривать лицензионные ключи");
                return;
            }
            KeysForm fm = new KeysForm();
            fm.ShowDialog();
        }

        private void AddOrderMenuItem_Click(object sender, EventArgs e)
        {
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                MessageBox.Show("У вас нет прав видеть лицензионный ключ");
                return;
            }
            IssueForm fm = new IssueForm();
            fm.ShowDialog();
        }

        private void DevMenuItem_Click(object sender, EventArgs e)
        {
            DeviceForm fm = new DeviceForm();
            fm.ShowDialog();
        }

        private void HistoryDeviceMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm fm = new HistoryForm();
            fm.frmType = 0;
            fm.ShowDialog();
        }

        private void HistoryKeyMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm fm = new HistoryForm();
            fm.frmType = 1;
            fm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
        }

        private void UsersMenuItem_Click(object sender, EventArgs e)
        {
            RightsForm fm = new RightsForm();
            fm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainList = SqlAcessors.KeyAcessor.GetJoin();
            dataGridAll.DataSource = mainList;
            setHeaders();
            
        }
        private void setHeaders()
        {
            if( !SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
                dataGridAll.Columns[(int)HeaderMainFromGrid.hdrNameKey].Visible = false;
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrNameKey].Width = 250;
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrNameKey].HeaderCell.Value = "Значение лиц. Ключа";
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrTest].HeaderCell.Value = "Тестовый ключ";
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrOwnerSur].HeaderCell.Value = "Фамилия владельца";
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrOwnerPos].HeaderCell.Value = "Должность";
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrNameComp].HeaderCell.Value = "Название компании";
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrNumbContr].HeaderCell.Value = "Код договора";
            dataGridAll.Columns[(int)HeaderMainFromGrid.hdrLimitKeys].HeaderCell.Value = "Лимит ключей";
      
        }

        private void dataGridAll_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                dataGridAll.Rows[e.RowIndex].Selected = true;
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                Point pt = dataGridAll.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true).Location;
                pt.X += e.Location.X;
                pt.Y += e.Location.Y;
                contextMain.Show(dataGridAll, pt);
            }
        }

        private void KeyMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridAll.SelectedRows[0].Index;
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey))
            {
                MessageBox.Show("У вас нет прав просматривать лицензионные ключи");
                return;
            }
            KeysForm fm = new KeysForm();
            fm.currentElemId = mainList[ind].idKey;
            fm.ShowDialog();
        }

        private void DeviceMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridAll.SelectedRows[0].Index;

            DeviceForm fm = new DeviceForm();
            fm.currentElemId = mainList[ind].idDev;
            fm.ShowDialog();
        }

        private void CompanyMenuItem_Click(object sender, EventArgs e)
        {
            int ind = dataGridAll.SelectedRows[0].Index;

            CompanyForm fm = new CompanyForm();
            fm.currentElemId = mainList[ind].idComp;
            fm.ShowDialog();
        }

        private void dataGridAll_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == (int)HeaderMainFromGrid.hdrTest)
            {

                e.Value = mainList[e.RowIndex].test > 0 ? "Да" : "Нет";
            }
        }
       

       
    }
}
