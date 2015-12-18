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
    public partial class RightsForm : Form
    {
        private List<User> usersList;
        private List<Group> usersGroup;
        public RightsForm()
        {
            InitializeComponent();
        }

        private void RightsForm_Load(object sender, EventArgs e)
        {
            this.Left = 700;
            this.Top = 400;
            combOperatons.Items.Add("Внести в группу");
            combOperatons.Items.Add("Удалить из группы");          
            combOperatons.Items.Add("Добавить пользователя");
            combOperatons.Items.Add("Добавить группу");
            combOperatons.Items.Add("Удалить пользователя");
            combOperatons.Items.Add("Удалить группу");
            LoadData();

        }
        private void LoadData()
        {
            comboGroups.Items.Clear();
            userComb.Items.Clear();
            usersList = SqlAcessors.UserAndGroupAcessor.SelUsers();

            foreach (User us in usersList)
            {
                userComb.Items.Add(us.Name);
            }
            userComb.SelectedIndex = 0;
            usersGroup = SqlAcessors.UserAndGroupAcessor.SelGroups();
            foreach (Group g in usersGroup)
            {
                comboGroups.Items.Add(g.GroupName);
            }
            comboGroups.SelectedIndex = 0;        
        }
        private void userComb_SelectedIndexChanged(object sender, EventArgs e)
        {
            combGrUser.Items.Clear();
            combGrUser.Invalidate();
            combGrUser.Text = "";
            int sel = userComb.SelectedIndex;
            
            List<Group> goupslist = SqlAcessors.UserAndGroupAcessor.SelGroupsForUser(usersList[sel].Name);
            foreach (Group g in goupslist)
            {
                combGrUser.Items.Add(g.GroupName);
            }
            if (goupslist.Count != 0)
            {
                combGrUser.SelectedIndex = 0;
            }
            User us = usersList[sel];
            int type = us.Type ?? 0;
            if (!checkIsRightsGroup.Checked)
                setcheck(type);
           }
        private void setcheck(int type)
        {
            checkedRights.SetItemChecked(0, (SqlAcessors.UserAndGroupAcessor.getValueUserRight(type, (int)SqlAcessors.RightsFlags.rLogin)));
            checkedRights.SetItemChecked(1, (SqlAcessors.UserAndGroupAcessor.getValueUserRight(type, (int)SqlAcessors.RightsFlags.rEdit)));
            checkedRights.SetItemChecked(2, (SqlAcessors.UserAndGroupAcessor.getValueUserRight(type, (int)SqlAcessors.RightsFlags.rViewLicKey)));
            checkedRights.SetItemChecked(3, (SqlAcessors.UserAndGroupAcessor.getValueUserRight(type, (int)SqlAcessors.RightsFlags.rPutKey)));
            checkedRights.SetItemChecked(4, (SqlAcessors.UserAndGroupAcessor.getValueUserRight(type, (int)SqlAcessors.RightsFlags.rPutTestKey)));
            checkedRights.SetItemChecked(5, (SqlAcessors.UserAndGroupAcessor.getValueUserRight(type, (int)SqlAcessors.RightsFlags.rEditRoles)));
       
        }
        private int getcheck()
        {
            int type = 0;
            type = Convert.ToInt32(checkedRights.GetItemChecked(0));
            type += Convert.ToInt32(checkedRights.GetItemChecked(1)) << 1;
            type += Convert.ToInt32(checkedRights.GetItemChecked(2)) << 2;
            type += Convert.ToInt32(checkedRights.GetItemChecked(3)) << 3;
            type += Convert.ToInt32(checkedRights.GetItemChecked(4)) << 4;
            type += Convert.ToInt32(checkedRights.GetItemChecked(5)) << 5;
            return type;
        }
        private void setRights_Click(object sender, EventArgs e)
        {
            if (SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
            {
                int type = 0;
                type = getcheck();
                if (!checkIsRightsGroup.Checked)
                {
                    User us = usersList[userComb.SelectedIndex];
                    SqlAcessors.UserAndGroupAcessor.SetUserRight(us.Id, type);
                    usersList[userComb.SelectedIndex].Type = type;
                }
                else 
                {
                    SqlAcessors.UserAndGroupAcessor.SetGroupRight(usersGroup[userComb.SelectedIndex].Id, type);
                    usersGroup[comboGroups.SelectedIndex].GroupType = type;
                }
                MessageBox.Show("Права установлены");
            }
            else
                MessageBox.Show("Вы не можете редактировать роли");
        }

        private void checkIsRightsGroup_CheckedChanged(object sender, EventArgs e)
        {
            if(checkIsRightsGroup.Checked)
            {
                setcheck((int)usersGroup[comboGroups.SelectedIndex].GroupType);
            }
        }

        private void comboGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkIsRightsGroup.Checked)
            {
                setcheck(Convert.ToInt32(usersGroup[comboGroups.SelectedIndex].GroupType));
            }
        }

        private void btnMake_Click(object sender, EventArgs e)
        {

            if (combOperatons.SelectedIndex == 0)
            {
                if (SqlAcessors.UserAndGroupAcessor.SetUserGroup(usersList[userComb.SelectedIndex].Id, usersGroup[comboGroups.SelectedIndex].Id))
                {
                    MessageBox.Show("Внесли в группу " + usersGroup[comboGroups.SelectedIndex].GroupName + " пользователя " + usersList[userComb.SelectedIndex].Name);
                    userComb_SelectedIndexChanged(sender, e);
                }

            }
            if (combOperatons.SelectedIndex == 1)
            {
                if (SqlAcessors.UserAndGroupAcessor.DelUserGroup(usersList[userComb.SelectedIndex].Id, usersGroup[comboGroups.SelectedIndex].Id))
                {
                    MessageBox.Show("Удалили из группы " + usersGroup[comboGroups.SelectedIndex].GroupName + " пользователя " + usersList[userComb.SelectedIndex].Name);
                    userComb_SelectedIndexChanged(sender, e);
                }
            }
            if (combOperatons.SelectedIndex == 2)
            {
                bool err = false;
               
                string msg = "Введите";
                if (String.IsNullOrEmpty(textBoxLogin.Text))
                { msg += " логин"; err = true; }
                if (String.IsNullOrEmpty(textBoxPassw.Text))
                { msg += " пароль"; err = true; }
                if (err)
                {
                    MessageBox.Show(msg);
                    return;
                }

                if (SqlAcessors.UserAndGroupAcessor.AddUser(new User { Name = textBoxLogin.Text, Password = textBoxPassw.Text, Type = 1 }))
                {
                    MessageBox.Show("Пользователь добавлен");
                    textBoxLogin.Text = "";
                    textBoxPassw.Text = "";
                    LoadData();
                }
            }
            if (combOperatons.SelectedIndex == 3)
            {
                bool err = false;

                string msg = "Введите";
                if (String.IsNullOrEmpty(textBoxGroup.Text))
                { msg += " имя группы"; err = true; }           
                if (err)
                {
                    MessageBox.Show(msg);
                    return;
                }
                if (SqlAcessors.UserAndGroupAcessor.AddGroup(new Group { GroupName = textBoxGroup.Text, GroupType = 1 }))
                {
                    MessageBox.Show("Группа добавлена");
                    textBoxGroup.Text = "";
                    LoadData();
                }
            }
            if (combOperatons.SelectedIndex == 4)
            {
                if (SqlAcessors.UserAndGroupAcessor.DelUser(usersList[userComb.SelectedIndex].Id))
                {
                    MessageBox.Show("Пользователь удален");
                    LoadData();
                }
            }
            if (combOperatons.SelectedIndex == 5)
            {
                if (SqlAcessors.UserAndGroupAcessor.DelGr(usersGroup[comboGroups.SelectedIndex].Id))
                {
                    MessageBox.Show("Группа удалена");

                    LoadData();
                }
            }
        }
    }
}
