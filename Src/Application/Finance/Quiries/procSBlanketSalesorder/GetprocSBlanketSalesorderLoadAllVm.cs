using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procSBlanketSalesorder
{
    public class GetprocSBlanketSalesorderLoadAllVm : IMapFrom<SBlanketSalesOrder>
    {
        public string Sales_Blanket_Order_Line { get; set; }
        public int? Qty_to_Ship { get; set; }
        public int? Quantity_Shipped { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public System.DateTime? Shipment_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SBlanketSalesOrder, GetprocSBlanketSalesorderLoadAllVm>();
        }
    }
}
