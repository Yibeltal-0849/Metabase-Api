using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.BidAward
{
    public class GetBidAwardLoadAllVm : IMapFrom<Bid_Award>
    {
		public System.Guid Bid_Award_ID { get; set; }
		public System.Guid? Bid_Result { get; set; }
		public string Award_Letter_Number { get; set; }
		public double? Award_Amount_Inc_VAT { get; set; }
		public string Currency { get; set; }
		public System.Guid? Bid_Award_Status { get; set; }
		public string Remark { get; set; }
		public System.Guid? created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Bid_Award, GetBidAwardLoadAllVm>();
        }
    }
}
