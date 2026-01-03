using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblDemand
{
    public class GetproctblDemandLoadAllVm : IMapFrom<tblDemand>
    {
		public long? id { get; set; }
		public long? End_Use_id { get; set; }
		public long? Varable_id { get; set; }
		public string Year { get; set; }
		public long? Unit { get; set; }
		public decimal? Value { get; set; }
		public string Source { get; set; }
		public bool? Enable { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
		public void Mapping(Profile profile)
        {
            profile.CreateMap<tblDemand, GetproctblDemandLoadAllVm>();
        }
    }
}
