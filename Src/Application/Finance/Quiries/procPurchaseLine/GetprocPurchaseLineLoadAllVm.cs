using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procPurchaseLine
{
    public class GetprocPurchaseLineLoadAllVm : IMapFrom<PurchaseLine>
    {
		public System.Guid Purchase_Line_ID { get; set; }
		public string Trans_NO { get; set; }
		public string Type { get; set; }
		public string No { get; set; }
		public string Description { get; set; }
		public string Location_Code { get; set; }
		public long? Quantity { get; set; }
		public string Unit { get; set; }
		public System.Double? Unit_Price_Excl_VAT { get; set; }
		public System.Double? Line_Amount_Excl_VAT { get; set; }
		public System.Double? Line_Discount_Per { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<PurchaseLine, GetprocPurchaseLineLoadAllVm>();
        }
    }
}
