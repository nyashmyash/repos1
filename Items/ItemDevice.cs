using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysOfIssuingLicKeysApplication.Items
{
    public class ItemDevice
    {
        public int Id = 0;
        public int IdCompany = 0;
        public int IdKey = 0;
        public string Code { get; set; }

        public string SurnameOwner { get; set; }

        public string PositionOwner { get; set; }
        public ItemDevice() { }
        public ItemDevice(Device dev) { Code = dev.Code; Id = dev.Id; IdCompany = dev.IdCompany ?? 0; IdKey = dev.IdKey ?? 0; PositionOwner = dev.PositionOwner; SurnameOwner = dev.SurnameOwner; }
        public ItemDevice(ItemDevice dev)
        {
            Id = dev.Id;
            IdCompany = dev.IdCompany;
            IdKey = dev.IdKey;
            Code = dev.Code;
            SurnameOwner = dev.SurnameOwner;
            PositionOwner = dev.PositionOwner;
        }
    }
}
