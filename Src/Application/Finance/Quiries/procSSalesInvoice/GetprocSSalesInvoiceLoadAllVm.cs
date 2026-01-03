using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procSSalesInvoice
{
    public class GetprocSSalesInvoiceLoadAllVm : IMapFrom<SSalesInvoice>
    {
        public string Sales_Invoice_Line { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<SSalesInvoice, GetprocSSalesInvoiceLoadAllVm>();
        }
    }
}
