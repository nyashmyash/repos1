using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOfIssuingLicKeysApplication.Items;

namespace SysOfIssuingLicKeysApplication.SqlAcessors
{
    class CompanyAcessor
    {
        public static List<ItemCompany> SelCompanies()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from cmp in dc.GetTable<Company>()
                        orderby cmp.Name
                        select new ItemCompany (cmp))
                        .ToList<ItemCompany>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static List<ItemCompany> SelCompanies(ItemCompany comp)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                if (comp.Name != "" && comp.Name != null)
                {
                    return (from cmp in dc.GetTable<Company>()
                            where cmp.Name.Contains(comp.Name)

                             select new ItemCompany (cmp)
                            ).ToList<ItemCompany>();
                }


                return (from cmp in dc.GetTable<Company>()
                        select new ItemCompany(cmp)
                            ).ToList<ItemCompany>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 

        }
        public static int GetCount(int idComp)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from comp in dc.GetTable<Company>()
                        from dev in dc.GetTable<Device>()
                        from key in dc.GetTable<Key>()
                        where comp.Id == dev.IdCompany && key.Id == dev.IdKey && comp.Id == idComp && dev.IdKey != null

                        select key
                           ).ToList<Key>().Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0; 

        }
        public static int GetCountLimitedKeys(int idComp)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from comp in dc.GetTable<Company>()
                        from dev in dc.GetTable<Device>()
                        from key in dc.GetTable<Key>()
                        where comp.Id == dev.IdCompany && key.Id == dev.IdKey && comp.Id == idComp && key.TestMark == 0

                        select comp
                           ).ToList<Company>().Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0; 
        }
        public static int GetCountsWithTestKeys(int idComp)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                DateTime time = new DateTime();
                time = DateTime.Now;

                return (from comp in dc.GetTable<Company>()
                        from dev in dc.GetTable<Device>()
                        from key in dc.GetTable<Key>()
                        where comp.Id == dev.IdCompany && dev.IdCompany == idComp && key.DateStart < time && time < key.DateEnd && key.TestMark == 1 && key.Id == dev.IdKey

                        select comp
                           ).ToList<Company>().Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return 0; 

        }
        public static bool AddCompany(ItemCompany icomp)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                Company comp = new Company {Id = getNextIndex(), Name = icomp.Name, LimitKeys = icomp.LimitKeys, NumberContract = icomp.NumberContract };
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Company> compTable = dc.GetTable<Company>();
               
                compTable.InsertOnSubmit(comp);
                compTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static int getNextIndex()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();
          
            var v = (from d in dc.GetTable<Company>()
                     where d.Id == dc.GetTable<Company>().Max(dv => dv.Id)
                     select d
                      ).SingleOrDefault<Company>();
            return (int)v.Id+1;
        }
        public static bool DelCompany(int id)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Company> compTable = dc.GetTable<Company>();
                int cnt = 0;
                cnt = (from d in dc.GetTable<Device>()
                                  where d.IdCompany == id
                                  select d
                          ).ToList<Device>().Count;
                if (cnt != 0)
                {
                    MessageBox.Show("Невозможно удалить компанию, т.к. у устройство ссылается на нее");
                    return false;
                }
                
                var matchedKey = (from c in dc.GetTable<Company>()
                                  where c.Id == id 
                                  select c
                          ).SingleOrDefault<Company>();
                

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
        public static bool UpdateCompany(ItemCompany icomp)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Company> compTable = dc.GetTable<Company>();
                
                var matchedKey = (from d in dc.GetTable<Company>()
                                  where d.Id == icomp.Id

                                  select d ).SingleOrDefault<Company>();
                matchedKey.LimitKeys = icomp.LimitKeys;
                matchedKey.Name = icomp.Name;
                matchedKey.NumberContract = icomp.NumberContract;

                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public static ItemCompany SelComp(int Id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                return (from c in dc.GetTable<Company>()
                        where c.Id == Id

                        select new ItemCompany(c)
                            ).SingleOrDefault<ItemCompany>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;    
        }
    }
}
