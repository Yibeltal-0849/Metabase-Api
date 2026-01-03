using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblGroupcons
{
    public class GetproctblGroupconsLoadAllVm : IMapFrom<tblGroupcons>
    {
        public long id { get; set; }
        public long? SubSector_id { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblGroupcons, GetproctblGroupconsLoadAllVm>();
        }
    }
}
