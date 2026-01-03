using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Quiries.BidSubmission
{
    public class GetBidSubmissionLoadAllVm : IMapFrom<Bid_Submission>
    {

		public string Participant_ID { get; set; }
		public byte[] Techinical_Document_PDF_Format { get; set; }
		public byte[] Financial_Document_Password_Protected { get; set; }
		public string Token_to_Financial_Document { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public System.DateTime? Updated_Date { get; set; }
		public System.DateTime? Last_Updated_Date { get; set; }
		public bool? Submited { get; set; }
		public System.Guid? Submited_By_User { get; set; }
		public System.DateTime? Submited_Date { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<Bid_Submission, GetBidSubmissionLoadAllVm>();
        }
    }
}
