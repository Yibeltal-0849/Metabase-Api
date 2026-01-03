using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblFacilityType
{
    public class GetproctblFacilityTypeLoadAllVm : IMapFrom<tblFacility_Type>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Enable { get; set; }
        public System.DateTime? Created_Date { get; set; }
        public long? Created_By { get; set; }
        public System.DateTime? Update_Date { get; set; }
        public byte[] Last_Modified { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblFacility_Type, GetproctblFacilityTypeLoadAllVm>();
        }
    }
}
