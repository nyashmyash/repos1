using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOfIssuingLicKeysApplication.Items;

namespace SysOfIssuingLicKeysApplication.SqlAcessors
{
    class SelectAllInfAboutKey
    {
        public int idKey = 0;
        public int idComp = 0;
        public int idDev = 0;
        public string nameKey { get; set; }
        public int test { get; set; }
        public string ownerSur { get; set; }
        public string ownerPos { get; set; }
        public string nameComp { get; set; }
        public string numbContr { get; set; }
        public int limitKeys { get; set; }
        
    }
    class KeyAcessor
    {
       /* public static void AddKey(Key key)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            System.Data.Linq.Table<Key> keyTable = dc.GetTable<Key>();
            if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
            {
                MessageBox.Show("У вас нет прав редактировать");
                return;
            }
            keyTable.InsertOnSubmit(key);
            keyTable.Context.SubmitChanges();
        }*/
       /* public static string GetCompName(int idkey)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return (from com in dc.GetTable<Company>()
                    from dev in dc.GetTable<Device>()
                    where dev.IdKey == idkey && dev.IdCompany == com.Id
                    select com.Name).SingleOrDefault<string>();

        }
        public static string GetOwner(int idkey)
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return (from com in dc.GetTable<Company>()
                    from dev in dc.GetTable<Device>()
                    where dev.IdKey == idkey && dev.IdCompany == com.Id
                    select dev.SurnameOwner).SingleOrDefault<string>();

        }*/
        public static List<SelectAllInfAboutKey> GetJoin()
        {
            try 
            { 
            DataClasses1DataContext dc = new DataClasses1DataContext();
            return(from dev in dc.GetTable<Device>()
                    join key in dc.GetTable<Key>() on dev.IdKey equals key.Id
                    join com in dc.GetTable<Company>() on dev.IdCompany equals com.Id
             select new SelectAllInfAboutKey
             { 
                 idKey = key.Id,
                 idDev = dev.Id,
                 idComp = com.Id,
                 nameKey = key.KeyValue, 
                 ownerSur = dev.SurnameOwner,
                 ownerPos = dev.PositionOwner,
                 test = key.TestMark ?? 0,
                 nameComp = com.Name,
                 numbContr = com.NumberContract,
                 limitKeys = com.LimitKeys ?? 0
             }).ToList<SelectAllInfAboutKey>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static List<ItemKey> SelKeys()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from keys in dc.GetTable<Key>()
                        select new ItemKey(keys)).ToList<ItemKey>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 

        }
        public static List<ItemKey> SelKeys(Key key)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                if (key.KeyValue != "" && key.KeyValue != null)
                {
                    return (from keys in dc.GetTable<Key>()
                            where keys.KeyValue.Contains(key.KeyValue)

                            select new ItemKey(keys)).ToList<ItemKey>();

                }


                return (from keys in dc.GetTable<Key>()
                        select new ItemKey(keys)).ToList<ItemKey>();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static ItemKey FindKeys(string str)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                return (from keys in dc.GetTable<Key>()
                        from d in dc.GetTable<Device>()
                        where keys.Id == d.IdKey && d.Code.Contains(str)

                        select new ItemKey(keys)).SingleOrDefault<ItemKey>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
                       // ).SingleOrDefault<Key>();
        }
        public static List<ItemKey> FindKeyFull(string str, DateTime sfrom, DateTime send, DateTime ffrom, DateTime fend, int test)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                return (from keys in dc.GetTable<Key>()
                        where (str == "" || keys.KeyValue.Contains(str)) && (sfrom.Year == 1 || (keys.DateStart > sfrom && keys.DateStart < send)) && (ffrom.Year == 1 || (keys.DateEnd > ffrom && keys.DateEnd < fend)) && (test < 0 || keys.TestMark == test)

                        select new ItemKey(keys)).ToList<ItemKey>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static ItemKey SelKey(int Id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                return (from keys in dc.GetTable<Key>()
                        where keys.Id == Id

                        select new ItemKey(keys)).SingleOrDefault<ItemKey>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static int getNextIndex()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                var v = (from d in dc.GetTable<Key>()
                         where d.Id == dc.GetTable<Key>().Max(dv => dv.Id)
                         select d
                          ).SingleOrDefault<Key>();
                return (int)v.Id + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return 0;
            }
         }
        public static bool AddKey(ItemKey ikey)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                Key key = new Key { Id = getNextIndex(), KeyValue = ikey.KeyValue, DateEnd = ikey.DateEnd, DateStart = ikey.DateStart, TestMark = ikey.TestMark };
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Key> compTable = dc.GetTable<Key>();

                compTable.InsertOnSubmit(key);
                compTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static bool UpdateKey(ItemKey ik)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Key> compTable = dc.GetTable<Key>();

                var matchedKey = (from d in dc.GetTable<Key>()
                                  where d.Id == ik.Id

                                  select d).SingleOrDefault<Key>();
                matchedKey.KeyValue = ik.KeyValue;
                matchedKey.DateStart = ik.DateStart;
                matchedKey.DateEnd = ik.DateEnd;
                matchedKey.TestMark = ik.TestMark;

                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static void UpdateKey(int Id, string value)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return ;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();

                var matchedKey = (from k in dc.GetTable<Key>()
                                  where k.Id == Id

                                  select k
                            ).SingleOrDefault<Key>();
                matchedKey.KeyValue = value;
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rViewLicKey) && !Convert.ToBoolean(matchedKey.TestMark))
                {
                    MessageBox.Show("У вас нет прав присваивать лицензионный ключ");
                    return;
                }
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rPutTestKey) && Convert.ToBoolean(matchedKey.TestMark))
                {
                    MessageBox.Show("У вас нет прав присваивать тестовый ключ");
                    return;
                }
               
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public static bool DelKey(int id)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Key> compTable = dc.GetTable<Key>();
                int cnt = 0;
                cnt = (from d in dc.GetTable<Device>()
                       where d.IdKey == id
                       select d
                          ).ToList<Device>().Count;
                if (cnt != 0)
                {
                    MessageBox.Show("Невозможно удалить ключ, т.к. у устройство ссылается на него");
                    return false;
                }

                var matchedKey = (from c in dc.GetTable<Key>()
                                  where c.Id == id
                                  select c
                          ).SingleOrDefault<Key>();


                compTable.DeleteOnSubmit(matchedKey);
                compTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        
    }
}
