using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Quiries.procLetterTransaction
{
    public class GetprocLetterTransactionLoadAllVm : IMapFrom<Letter_Transaction>
    {
		public System.Guid Letter_ID { get; set; }
		public System.Guid? Application_Code { get; set; }
		public string Application_NO { get; set; }
		public string Ref_No { get; set; }
		public string From { get; set; }
		public string To { get; set; }
		public bool? Is_IN { get; set; }
		public bool? IS_Out { get; set; }
		public string Subject { get; set; }
		public int? Number_Of_Page { get; set; }
		public int? Number_Of_Attachment { get; set; }
		public System.DateTime? Letter_written_Date { get; set; }
		public string Document_Details { get; set; }
		public System.Guid? Recived_By { get; set; }
		public string RecivedBy_Name { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<Letter_Transaction, GetprocLetterTransactionLoadAllVm>();
        }
    }
}
