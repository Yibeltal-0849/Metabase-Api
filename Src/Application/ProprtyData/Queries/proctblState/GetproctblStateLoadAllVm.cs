using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblState
{
    public class GetproctblStateLoadAllVm : IMapFrom<tblState>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblState, GetproctblStateLoadAllVm>();
        }
    }
}
