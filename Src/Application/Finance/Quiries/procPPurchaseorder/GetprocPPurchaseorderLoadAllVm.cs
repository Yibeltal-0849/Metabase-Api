using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procPPurchaseorder
{
    public class GetprocPPurchaseorderLoadAllVm : IMapFrom<PPurchaseOrder>
    {
        public System.Guid? Purchase_Line_ID { get; set; }
        public double? Direct_Unit_Cost_Excl_VAT { get; set; }
        public double? Qty_to_Receive { get; set; }
        public double? Quantity_Received { get; set; }
        public double? Qty_to_Invoice { get; set; }
        public double? Quantity_Invoiced { get; set; }
        public double? Qty_to_Assign { get; set; }
        public double? Qty_Assigned { get; set; }
        public System.DateTime? Planned_Receipt_Date { get; set; }
        public System.DateTime? Expected_Receipt_Date { get; set; }
        public System.DateTime? Order_Date { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PPurchaseOrder, GetprocPPurchaseorderLoadAllVm>();
        }
    }
}
