using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblVariable
{
    public class GetproctblVariableLoadAllVm : IMapFrom<tblVariable>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public bool? IsNumber { get; set; }
        public string Unit { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblVariable, GetproctblVariableLoadAllVm>();
        }
    }
}
