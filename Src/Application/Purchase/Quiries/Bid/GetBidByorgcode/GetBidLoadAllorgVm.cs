using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.Bid.GetBidByorgcode
{
    public class GetBidLoadAllorgVm : IMapFrom<BidOrg>
	{

		public System.Guid Bid_ID { get; set; }
		public System.Guid? Application_Code { get; set; }
		public string Applcation_No { get; set; }
		public string Bid_No { get; set; }
		public string PO_ID { get; set; }
		public System.Guid? Bid_Type { get; set; }
		public string Initiative_NO { get; set; }
		public string Bid_Description { get; set; }
		public System.DateTime? Bid_StartDate { get; set; }
		public System.DateTime? Bid_EndDate { get; set; }
		public System.DateTime? Bid_OpeningDate { get; set; }
		public bool? Bid_Published { get; set; }
		public string Bid_Publisher { get; set; }
		public System.DateTime? Published_Date { get; set; }
		public System.Guid organization_code { get; set; }
        public System.Guid? Bid_Method { get; set; }
        public double? Bid_Price { get; set; }
        public System.DateTime? financial_OpeningDate { get; set; }

        public void Mapping(Profile profile)
		{
			profile.CreateMap<BidOrg, GetBidLoadAllorgVm>();
		}
	}
}
