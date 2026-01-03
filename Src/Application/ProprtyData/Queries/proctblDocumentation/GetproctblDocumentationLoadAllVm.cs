using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Quiries.proctblDocumentation
{
    public class GetproctblDocumentationLoadAllVm : IMapFrom<tblDocumentation>
    {
		public long? id { get; set; }
		public long? Region { get; set; }
		public string Contact_Person { get; set; }
		public string Contact_Phone { get; set; }
		public long? Type { get; set; }
		public System.Guid? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[]? Last_Modified { get; set; }
		public bool? Enable { get; set; }
		public string Data_Owner { get; set; }
		public bool? Regional_Approve { get; set; }
		public bool? Federal_Approve { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblDocumentation, GetproctblDocumentationLoadAllVm>();
        }
    }
}
