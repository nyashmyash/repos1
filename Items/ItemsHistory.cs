using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOfIssuingLicKeysApplication.Items
{
    public class ItemsHistoryDevice
    {
        public string CodeValue { get; set; }

        public string NewCodeValue { get; set; }

        public string KeyValue { get; set; }

        public string NewKeyValue { get; set; }
    }
    public class ItemsHistoryKey
    {
        public string Key { get; set; }

        public DateTime FromTime { get; set; }

        public DateTime ToTime { get; set; }

        public string Reason { get; set; }

        public int CountDays { get; set; }
    }
}
