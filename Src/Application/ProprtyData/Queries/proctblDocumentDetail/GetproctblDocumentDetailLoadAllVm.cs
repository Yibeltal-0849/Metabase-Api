using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblDocumentDetail
{
    public class GetproctblDocumentDetailLoadAllVm : IMapFrom<tblDocumentDetail>
    {
		public long id { get; set; }
		public long Document_id { get; set; }
		public string Author { get; set; }
		public string Title { get; set; }
		public string Publisher { get; set; }
		public System.DateTime Publicationed_Date { get; set; }
		public string Volume { get; set; }
		public int Number { get; set; }
		public int Pages { get; set; }
		public string TypeCategory { get; set; }
		public string ISBN { get; set; }
		public string Abstract { get; set; }
		public string URL { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblDocumentDetail, GetproctblDocumentDetailLoadAllVm>();
        }
    }
}
