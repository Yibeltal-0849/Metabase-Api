using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procSSalesorder
{
    public class GetprocSSalesorderLoadAllVm : IMapFrom<SSalesOrder>
    {
        public string Sales_Order_Line { get; set; }
        public int? Reserved_Quantity { get; set; }
        public int? Qty_to_Ship { get; set; }
        public int? Quantity_Shipped { get; set; }
        public int? Qty_to_Invoice { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public System.DateTime? Planned_Delivery_Date { get; set; }
        public System.DateTime? Planned_Shipment_Date { get; set; }
        public System.DateTime? Shipment_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SSalesOrder, GetprocSSalesorderLoadAllVm>();
        }
    }
}
