using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblResourceFacility
{
    public class GetproctblResourceFacilityLoadAllVm : IMapFrom<tblResourceFacility>
    {
        public long id { get; set; }
        public long? Resource_id { get; set; }
        public long? Facility_id { get; set; }
        public System.DateTime? Created_Date { get; set; }
        public long? Created_By { get; set; }
        public System.DateTime? Update_Date { get; set; }
        public long? Update_by { get; set; }
        public byte[] Last_Modified { get; set; }
        public bool? Enable { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblResourceFacility, GetproctblResourceFacilityLoadAllVm>();
        }
    }
}
