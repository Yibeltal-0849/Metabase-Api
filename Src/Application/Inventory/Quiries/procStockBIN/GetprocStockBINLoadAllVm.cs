using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.procStockBIN
{
    public class GetprocStockBINLoadAllVm : IMapFrom<Stock_BIN>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Stock_BIN, GetprocStockBINLoadAllVm>();
        }
    }
}
