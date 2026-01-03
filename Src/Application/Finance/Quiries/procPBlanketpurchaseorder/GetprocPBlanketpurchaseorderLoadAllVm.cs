using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procPBlanketpurchaseorder
{
    public class GetprocPBlanketpurchaseorderLoadAllVm : IMapFrom<PBlanketPurchaseOrder>
    {
        public System.Guid Purchase_Line { get; set; }
        public int? Qty_to_Receive { get; set; }
        public int? Quantity_Received { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PBlanketPurchaseOrder, GetprocPBlanketpurchaseorderLoadAllVm>();
        }
    }
}
