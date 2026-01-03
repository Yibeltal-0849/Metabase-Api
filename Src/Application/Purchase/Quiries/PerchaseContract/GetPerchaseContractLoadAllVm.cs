using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.PerchaseContract
{
    public class GetPerchaseContractLoadAllVm : IMapFrom<Perchase_Contract>
    {
		public string Purchase_Contract { get; set; }
		public System.Guid? Bid_Award_ID { get; set; }
		public bool? IS_Bid_Security_Released { get; set; }
		public System.DateTime? Bid_Security_Release_Date { get; set; }
		public string Bid_Security_Recived_By { get; set; }
		public string Bid_Bond_Type { get; set; }
		public System.DateTime? Bid_Bond_Release_Date { get; set; }
		public double Award_Amount_Inc_VAT { get; set; }
		public string Vendor_ID { get; set; }
		public string Remark { get; set; }
		public System.DateTime? Start_Date { get; set; }
		public System.DateTime? End_Date { get; set; }
		public System.Guid? Organization_ID { get; set; }
		public System.Guid? DIV { get; set; }
		public System.Guid? Contract_Status { get; set; }
		public string Recived_By { get; set; }
		public string Currency { get; set; }
		public System.Guid? created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Perchase_Contract, GetPerchaseContractLoadAllVm>();
        }
    }
}
