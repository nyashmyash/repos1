using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace SysOfIssuingLicKeysApplication.SqlAcessors
{
    enum RightsFlags
    {
        /*
          1. Право подключаться к системе;
2. Право редактировать информацию;
3. Право видеть значение лицензионного ключа;
4. Право выдавать лицензионный ключ;
5. Право выдавать тестовый лицензионный ключ;
6. Право редактировать роли.
         */
        rLogin = 1,
        rEdit = 2,
        rViewLicKey = 4,
        rPutKey = 8,
        rPutTestKey = 16,
        rEditRoles = 32
    }
  
    class UserAndGroupAcessor
    {
        public static User curUser;
        public static List<Group> listGroup = new List<Group>();
        
        public static bool getValueCurrentUserRight(int index)
        {
            int val = 0;
            if (listGroup.Count != 0)
            {
                foreach (Group g in listGroup)
                { 
                    val |= g.GroupType ?? 0; 
                }
                val &= index;
            }
            else
                val = (curUser.Type ?? 0) & index;

            return Convert.ToBoolean(val);
        }
        public static bool getValueUserRight(int value, int index)
        {
            int i = value & index;

            return Convert.ToBoolean(i);
        }
        public static bool AddUser(User user)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<User> userTable = dc.GetTable<User>();
                user.Id = getNextUsrIndex();
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return false;
                }
                userTable.InsertOnSubmit(user);
                userTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static int getNextUsrIndex()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var v = (from d in dc.GetTable<User>()
                     where d.Id == dc.GetTable<User>().Max(dv => dv.Id)
                     select d
                      ).SingleOrDefault<User>();
            return (int)v.Id + 1;
        }
        public static int getNextGrIndex()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var v = (from d in dc.GetTable<Group>()
                     where d.Id == dc.GetTable<Group>().Max(dv => dv.Id)
                     select d
                      ).SingleOrDefault<Group>();
            return (int)v.Id + 1;
        }
        public static bool DelUser(int id)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<User> ugt = dc.GetTable<User>();
                int cnt = 0;
                cnt = (from usergr in dc.GetTable<UserToGroup>()
                       where usergr.UserID == id
                       select usergr
                          ).ToList<UserToGroup>().Count;
                if (cnt != 0)
                {
                    MessageBox.Show("Невозможно удалить пользователя, т.к. он в группе");
                    return false;
                }

                var matchedKey = (from u in dc.GetTable<User>()
                                  where u.Id == id
                                  select u
                          ).SingleOrDefault<User>();


                ugt.DeleteOnSubmit(matchedKey);
                ugt.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool DelGr(int id)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Group> ugt = dc.GetTable<Group>();
                int cnt = 0;
                cnt = (from usergr in dc.GetTable<UserToGroup>()
                       where usergr.GroupID == id
                       select usergr
                          ).ToList<UserToGroup>().Count;
                if (cnt != 0)
                {
                    MessageBox.Show("Невозможно удалить группу, т.к. у в ней есть ползователи");
                    return false;
                }

                var matchedKey = (from g in dc.GetTable<Group>()
                                  where g.Id == id
                                  select g
                          ).SingleOrDefault<Group>();


                ugt.DeleteOnSubmit(matchedKey);
                ugt.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool AddGroup(Group gr)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Group> userTable = dc.GetTable<Group>();
                gr.Id = getNextGrIndex();
                userTable.InsertOnSubmit(gr);
                userTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static User GetUser(string name)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                List<User> list = (from usr in dc.GetTable<User>()
                                   where usr.Name == name
                                   select usr).ToList<User>();
                if (list.Count != 0)
                    return list[0];
                else
                    return new User();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static void SetUserRight(int id,int type)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var matchedKey = (from usr in dc.GetTable<User>()
                                  where usr.Id == id
                                  select usr).SingleOrDefault<User>();

                matchedKey.Type = type;
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool SetUserGroup(int id, int groupId)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var matchedKey = (from u_gr in dc.GetTable<UserToGroup>()
                                  where u_gr.UserID == id && u_gr.GroupID == groupId
                                  select u_gr
                                   ).SingleOrDefault<UserToGroup>();
               
                if (matchedKey != null)
                {
                    MessageBox.Show("Пользователь уже добавлен в эту группу");
                    return false;
                }

                UserToGroup ugr = new UserToGroup();
                ugr.GroupID = groupId;
                ugr.UserID = id;

                System.Data.Linq.Table<UserToGroup> userTable = dc.GetTable<UserToGroup>();
                userTable.InsertOnSubmit(ugr);
                userTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false; 
        }
        public static bool DelUserGroup(int id, int groupId)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var matchedKey = (from u_gr in dc.GetTable<UserToGroup>()
                                  where u_gr.UserID == id && u_gr.GroupID == groupId
                                  select u_gr
                                     ).SingleOrDefault<UserToGroup>();            
                if (matchedKey == null)
                {
                    MessageBox.Show("У пользователя нет такой группы");
                    return false;
                }
                dc.GetTable<UserToGroup>().DeleteOnSubmit(matchedKey);
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }
        public static List<User> SelUsers()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from usr in dc.GetTable<User>()
                        select usr).ToList<User>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
       /** public static List<string> SelUsersDist()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return (from usr in dc.GetTable<User>()
                   select usr.Name
                   ).Distinct().OrderBy(n => n).ToList<string>();
        }*/
        public static List<User> SelUsers(string name, string psw)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from usr in dc.GetTable<User>()
                        where usr.Name == name && usr.Password == psw
                        select usr).ToList<User>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
      
        public static List<Group> SelGroups()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from usr in dc.GetTable<Group>()
                        select usr).ToList<Group>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static List<Group> SelGroupsForUser(string name)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from usr in dc.GetTable<User>()
                        from gr in dc.GetTable<Group>()
                        from u_gr in dc.GetTable<UserToGroup>()
                        where usr.Name == name && gr.Id == u_gr.GroupID && u_gr.UserID == usr.Id
                        select gr).ToList<Group>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static void SetGroupRight(int id, int type)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEditRoles))
                {
                    MessageBox.Show("У вас нет прав редактировать роли");
                    return;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var matchedKey = (from gr in dc.GetTable<Group>()
                                  where gr.Id == id
                                  select gr).SingleOrDefault<Group>();
                matchedKey.GroupType = type;
               
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        /*public static void DelGroupRight(string name, string namegr)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            var matchedKey = (from usr in dc.GetTable<User>()
                              from gr in dc.GetTable<Group>()
                              from u_gr in dc.GetTable<UserToGroup>()
                              where gr.Id == u_gr.GroupID && u_gr.UserID == usr.Id && usr.Name == name && gr.GroupName == namegr 
                              select usr).SingleOrDefault<User>();

            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return;
                }
                dc.GetTable<User>().DeleteOnSubmit(matchedKey);
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }*/
      
    }
}
