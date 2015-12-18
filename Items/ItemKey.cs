using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOfIssuingLicKeysApplication.Items
{
    public class ItemKey
    {
        public int Id = 0;
  
        public string KeyValue { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }

        public int TestMark { get; set; }
        public ItemKey() { DateStart = DateTime.Now; DateEnd = DateTime.Now; }
        public ItemKey(ItemKey keys) { Id = keys.Id; DateEnd = (DateTime)keys.DateEnd; DateStart = (DateTime)keys.DateStart; KeyValue = keys.KeyValue; TestMark = keys.TestMark; }
       
        public ItemKey(Key keys) { Id = keys.Id; DateEnd = (DateTime)keys.DateEnd; DateStart = (DateTime)keys.DateStart; KeyValue = keys.KeyValue; TestMark = keys.TestMark ?? 0; }
       
    }
}
