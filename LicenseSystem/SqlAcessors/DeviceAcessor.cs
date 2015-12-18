using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SysOfIssuingLicKeysApplication.Items;

namespace SysOfIssuingLicKeysApplication.SqlAcessors
{
    class DeviceAcessor
    {
        public static List<ItemDevice> SelDevicesWithoutKeys()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from dev in dc.GetTable<Device>()
                     where dev.IdKey == null
                        select new ItemDevice(dev)).ToList<ItemDevice>();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static List<ItemDevice> SelDevices()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                var v = (from dev in dc.GetTable<Device>()
                         select new ItemDevice(dev));
                return v.ToList<ItemDevice>();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static List<ItemDevice> SelDevices(string code)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                if (code != "")
                {
                    return (from dev in dc.GetTable<Device>()
                            where dev.Code.Contains(code)

                            select new ItemDevice(dev)).ToList<ItemDevice>();
                }

                return (from dev in dc.GetTable<Device>()
                        select new ItemDevice(dev)).ToList<ItemDevice>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static ItemDevice SelDevice(int Id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                return (from dev in dc.GetTable<Device>()
                    where dev.Id == Id

                    select new ItemDevice(dev)).SingleOrDefault<ItemDevice>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }
        public static int getNextIndex()
        {
            DataClasses1DataContext dc = new DataClasses1DataContext();

            var v = (from d in dc.GetTable<Device>()
                     where d.Id == dc.GetTable<Device>().Max(dv => dv.Id)
                     select d
                      ).SingleOrDefault<Device>();
            return (int)v.Id + 1;
        }
        public static ItemDevice SelDeviceForIdKey(int Id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
            
                return (from dev in dc.GetTable<Device>()
                   where dev.IdKey == Id
                 
                   select new ItemDevice(dev)).SingleOrDefault<ItemDevice>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;                        
        }
        public static List<ItemDevice> SelDeviceForIdComp(int Id)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();

                return (from dev in dc.GetTable<Device>()
                    where dev.IdCompany == Id

                    select new ItemDevice(dev)).ToList<ItemDevice>();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }
             return null;  
        }
        public static void UpdateCode(int Id, string value)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();

                var matchedKey = (from d in dc.GetTable<Device>()
                                  where d.Id == Id

                                  select d
                            ).SingleOrDefault<Device>();
                matchedKey.Code = value;
                
                dc.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static bool SetKey(int Id, int IdKey)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();

                var matchedKey = (from d in dc.GetTable<Device>()
                                  where d.Id == Id

                                  select d
                            ).SingleOrDefault<Device>();
                if (matchedKey.IdKey!=null)
                {
                    MessageBox.Show("У этого устройства уже есть ключ");
                    return false;
                }

                matchedKey.IdKey = IdKey;
               
                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        public static bool UpdateDevice(ItemDevice itm)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();

                var matchedKey = (from d in dc.GetTable<Device>()
                                  where d.Id == itm.Id

                                  select d
                            ).SingleOrDefault<Device>();
                if (matchedKey.IdKey != null)
                {
                    MessageBox.Show("У этого устройства уже есть ключ");
                    return false;
                }

                //matchedKey.Code = itm.Code;
                matchedKey.PositionOwner = itm.PositionOwner;
                matchedKey.SurnameOwner = itm.SurnameOwner;

                dc.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }

        internal static bool AddDevice(ItemDevice itm)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                Device dev = new Device { Id = getNextIndex(), Code = itm.Code, PositionOwner = itm.PositionOwner, SurnameOwner = itm.SurnameOwner, IdCompany = itm.IdCompany };
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Device> devTable = dc.GetTable<Device>();

                devTable.InsertOnSubmit(dev);
                devTable.Context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public static bool DelDevice(int id)
        {
            try
            {
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return false;
                }
                DataClasses1DataContext dc = new DataClasses1DataContext();
                System.Data.Linq.Table<Device> compTable = dc.GetTable<Device>();

                var matchedKey = (from d in dc.GetTable<Device>()
                                  where d.Id == id
                                  select d
                          ).SingleOrDefault<Device>();


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
