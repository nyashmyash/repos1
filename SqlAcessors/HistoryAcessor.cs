using SysOfIssuingLicKeysApplication.Items;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOfIssuingLicKeysApplication.SqlAcessors
{
    class HistoryDeviceAcessor
    {
        public static List<ItemsHistoryDevice> SelHistory()
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from h in dc.GetTable<HistoryOfDevice>()
                        select new ItemsHistoryDevice { CodeValue = h.CodeValue, KeyValue = h.KeyValue, NewCodeValue = h.NewCodeValue, NewKeyValue = h.NewKeyValue }).ToList<ItemsHistoryDevice>();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static void AddHistory(HistoryOfDevice hist)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Table<HistoryOfDevice> histor = dc.GetTable<HistoryOfDevice>();
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return;
                }
                histor.InsertOnSubmit(hist);
                histor.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    class HistoryKeyAcessor
    {
        public static List<ItemsHistoryKey> SelHistory(int Keyid)
        {
            try
            {
                DataClasses1DataContext dc = new DataClasses1DataContext();
                return (from h in dc.GetTable<HistoryOfKey>()
                        from k in dc.GetTable<Key>()
                        where (Keyid == 0 || h.KeyId == Keyid) && k.Id == h.KeyId
                        select new ItemsHistoryKey { Key = k.KeyValue, FromTime = Convert.ToDateTime(h.FromTime), ToTime = Convert.ToDateTime(h.ToTime), Reason = h.Reason, CountDays = ((TimeSpan)(Convert.ToDateTime(h.ToTime) - Convert.ToDateTime(h.FromTime))).Days }).ToList<ItemsHistoryKey>();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null; 
        }
        public static void AddHistory(HistoryOfKey hist)
        {
            try 
            { 
                DataClasses1DataContext dc = new DataClasses1DataContext();
                Table<HistoryOfKey> histor = dc.GetTable<HistoryOfKey>();
                if (!SqlAcessors.UserAndGroupAcessor.getValueCurrentUserRight((int)SqlAcessors.RightsFlags.rEdit))
                {
                    MessageBox.Show("У вас нет прав редактировать");
                    return;
                }
                histor.InsertOnSubmit(hist);
                histor.Context.SubmitChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
