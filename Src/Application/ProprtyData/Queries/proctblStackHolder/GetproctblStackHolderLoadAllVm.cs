using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblStackHolder
{
    public class GetproctblStackHolderLoadAllVm : IMapFrom<tblStackHolder>
    {
		public long id { get; set; }
		public long Address_id { get; set; }
		public string Name { get; set; }
		public string WebSite { get; set; }
		public bool? IsLocal { get; set; }
		public string Capital { get; set; }
		public string Mistion { get; set; }
		public string Vistion { get; set; }
		public string Objective { get; set; }
		public long Involvement_id { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblStackHolder, GetproctblStackHolderLoadAllVm>();
        }
    }
}
