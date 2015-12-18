using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOfIssuingLicKeysApplication.Items
{
    public class ItemCompany
    {
        public int Id = 0;
        public string Name { get; set; }

        public string NumberContract { get; set; }

        public int LimitKeys { get; set; }
        public ItemCompany() { }
        public ItemCompany(ItemCompany cmp) { Id = cmp.Id; LimitKeys = cmp.LimitKeys; Name = cmp.Name; NumberContract = cmp.NumberContract; }
 
        public ItemCompany(Company cmp) { Id = cmp.Id; LimitKeys = cmp.LimitKeys ?? 0; Name = cmp.Name; NumberContract = cmp.NumberContract; }
    }
}
