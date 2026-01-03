using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.BidResult
{
    public class GetBidResultLoadAllVm : IMapFrom<_Bid_Result>
    {

        public System.Guid Bid_Result { get; set; }
        public string Participant_ID { get; set; }
        public bool? PreQulification_Is_Passed { get; set; }
        public double? Technical_Score { get; set; }
        public double? Financial_Score { get; set; }
        public double? Total_Rank { get; set; }
        public bool? Is_Approved { get; set; }
        public System.Guid? Document_ID { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<_Bid_Result, GetBidResultLoadAllVm>();
        }
    }
}
