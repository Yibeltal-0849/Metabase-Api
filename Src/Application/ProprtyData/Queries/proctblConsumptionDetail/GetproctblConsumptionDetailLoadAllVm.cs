using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblConsumptionDetail
{
    public class GetproctblConsumptionDetailLoadAllVm : IMapFrom<tblConsumptionDetail>
    {
        public long? id { get; set; }
        public long Consumption_id { get; set; }
        public long SubSector_Id { get; set; }
        public long Unit_Id { get; set; }
        public string Sector_Number { get; set; }
        public decimal? Collected_Birr { get; set; }
        public decimal? Used_Amount { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblConsumptionDetail, GetproctblConsumptionDetailLoadAllVm>();
        }
    }
}
