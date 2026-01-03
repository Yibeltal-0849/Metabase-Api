using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.BidOpening
{
    public class GetBidOpeningLoadAllVm : IMapFrom<Bid_Opening>
    {

		public string Participant_ID { get; set; }
		public System.DateTime? Techinical_Opening_Date { get; set; }
		public byte[] Techinical_Document_PDF_Format { get; set; }
		public System.DateTime? Financial_Opening_Date { get; set; }
		public byte[] Financial_Document_Password_Protected { get; set; }
		public string Remark { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public System.DateTime? Last_Updated { get; set; }

		public void Mapping(Profile profile)
        {
            profile.CreateMap<Bid_Opening, GetBidOpeningLoadAllVm>();
        }
    }
}
