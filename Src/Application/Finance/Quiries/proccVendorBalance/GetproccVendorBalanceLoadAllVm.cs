using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccVendorBalance
{
    public class GetproccVendorBalanceLoadAllVm : IMapFrom<CVendorBalance>
    {

        public long Id { get; set; }
        public string Org_id { get; set; }
        public string Vendor_ID { get; set; }
        public System.DateTime Date { get; set; }
        public string Invoice_Number { get; set; }
        public string Purchase_Order_Number { get; set; }
        public decimal? Amount { get; set; }
        public string A_or_R_Account { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CVendorBalance, GetproccVendorBalanceLoadAllVm>();
        }
    }
}
