using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.BidParticipant
{
    public class GetBidParticipantLoadAllVm : IMapFrom<Bid_Participant>
    {
		public string Participant_ID { get; set; }
		public System.Guid? Bid_DetailID { get; set; }
		public string User_id { get; set; }
		public bool? Is_Customer { get; set; }
		public bool? Is_Vendor { get; set; }
		public string Customer_Id { get; set; }
		public string Vendor_ID { get; set; }
		public string Request_Number { get; set; }
		public bool? Is_Issued { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Bid_Participant, GetBidParticipantLoadAllVm>();
        }
    }
}
