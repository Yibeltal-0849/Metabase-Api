using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblVarableBasedTableDetail
{
    public class GetproctblVarableBasedTableDetailLoadAllVm : IMapFrom<tblVarableBasedTableDetail>
    {
        public long id { get; set; }
        public long Table_id { get; set; }
        public long EnergyChain_id { get; set; }
        public long Type_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblVarableBasedTableDetail, GetproctblVarableBasedTableDetailLoadAllVm>();
        }
    }
}
