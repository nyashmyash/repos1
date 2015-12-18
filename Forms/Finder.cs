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
    public partial class Finder : Form
    {
        public List<ItemKey> listKeys;
        public Finder()
        {
            InitializeComponent();
        }

        private void butnFind_Click(object sender, EventArgs e)
        {
            string key ="";
            int test = -1;
            DateTime start1 = new DateTime();
            DateTime start2 = new DateTime();
            DateTime end1 = new DateTime();
            DateTime end2 = new DateTime();
 
            if (checkOptions.GetItemChecked(0))
                key = maskText.Text;
           
            if (checkOptions.GetItemChecked(1))
                test = Convert.ToInt32(isTest.Checked);
          
            if (checkOptions.GetItemChecked(2))
            {
                start1 = dateTimePicker1.Value;
                start2 = dateTimePicker2.Value;
            }
      
            if (checkOptions.GetItemChecked(3))
            {
                end1 = dateTimePicker3.Value;
                end2 = dateTimePicker4.Value;
            }

            listKeys = SqlAcessors.KeyAcessor.FindKeyFull(key, start1, start2, end1, end2, test);
            Close();            
        }

        private void Finder_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
        }
    }
}
