using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblConsumption
{
    public class GetproctblConsumptionLoadAllVm : IMapFrom<tblConsumption>
    {
        public long id { get; set; }
        public string Tranaction_Id { get; set; }
        public long? Companys_id { get; set; }
        public long? Energy_Id { get; set; }
        public bool? Complited { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblConsumption, GetproctblConsumptionLoadAllVm>();
        }
    }
}
