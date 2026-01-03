using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procSSalesReturnOrder
{
    public class GetprocSSalesReturnOrderLoadAllVm : IMapFrom<SSalesReturnOrder>
    {
        public string Sales_Return_Order_Line { get; set; }
        public System.Guid? Return_Reason_Code { get; set; }
        public int? Return_Qty_to_Receive { get; set; }
        public int? Return_Qty_Received { get; set; }
        public int? Qty_to_Invoice { get; set; }
        public int? Quantity_Invoiced { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SSalesReturnOrder, GetprocSSalesReturnOrderLoadAllVm>();
        }
    }
}
