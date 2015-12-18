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
    public partial class Login : Form
    {
        public bool exit = false;
        private List<User> usersList;
        private List<Group> usersGroup;
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;

            usersList = SqlAcessors.UserAndGroupAcessor.SelUsers();
            User us1 = usersList[0];
            textName.Text = us1.Name;
            textPassw.Text = us1.Password;
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            List<User> list = SqlAcessors.UserAndGroupAcessor.SelUsers(textName.Text, textPassw.Text);
            if (list.Count == 0)
            {
                exit = true;
                MessageBox.Show("Неправильный логин или пароль");
                return;
            }
            else
            {
                int Type =0;
                            
                usersGroup = SqlAcessors.UserAndGroupAcessor.SelGroupsForUser(textName.Text);
                                
                if (usersGroup.Count != 0)
                {
                    foreach (Group g in usersGroup)
                    {
                       Type |= g.GroupType ?? 0;
                    }
                }
                else
                    Type = list[0].Type ?? 0;

                if (SqlAcessors.UserAndGroupAcessor.getValueUserRight(Type, (int)SqlAcessors.RightsFlags.rLogin))
                {
                    SqlAcessors.UserAndGroupAcessor.curUser = list[0];
                    SqlAcessors.UserAndGroupAcessor.listGroup = usersGroup;
                    
                    exit = false;
                    Close();
                }
                else
                    MessageBox.Show("У вас нет прав входа в систему");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exit = true;
            Close();
        }
    }
}
