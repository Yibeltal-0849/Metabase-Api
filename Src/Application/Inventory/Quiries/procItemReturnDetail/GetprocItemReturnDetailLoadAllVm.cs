using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Quiries.procItemReturnDetail
{
    public class GetprocItemReturnDetailLoadAllVm : IMapFrom<ItemReturnDetail>
    {
        public long Request_DetailID { get; set; }
        public string Requsition_ID { get; set; }
        public string Item_ID { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
        public bool? Is_PO { get; set; }
        public bool? From_Store { get; set; }
        public string Log { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemReturnDetail, GetprocItemReturnDetailLoadAllVm>();
        }
    }
}
