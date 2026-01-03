using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Quiries.proctblCompanys
{
    public class GetproctblCompanysLoadAllVm : IMapFrom<tblCompanys>
    {
		public long id { get; set; }
		public string Name { get; set; }
		public long? Region { get; set; }
		public bool? IsLocal { get; set; }
		public string Operating_Area { get; set; }
		public decimal? Capital { get; set; }
		public string Mistion { get; set; }
		public string vistion { get; set; }
		public string Objective { get; set; }
		public byte[]? LastUpdated { get; set; }
		public string More_info { get; set; }
		public long OrgType { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblCompanys, GetproctblCompanysLoadAllVm>();
        }
    }
}
