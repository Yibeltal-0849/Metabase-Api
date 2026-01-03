using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblWoredas
{
    public class GetproctblWoredasLoadAllVm : IMapFrom<tblWoredas>
    {
        public long id { get; set; }
        public string description { get; set; }
        public int? zones_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblWoredas, GetproctblWoredasLoadAllVm>();
        }
    }
}
