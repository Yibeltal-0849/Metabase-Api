using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblVarableTables
{
    public class GetproctblVarableTablesLoadAllVm : IMapFrom<tblVarableTables>
    {
        public long id { get; set; }
        public long? Variable_id { get; set; }
        public long? VarB_Table_Detail_id { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblVarableTables, GetproctblVarableTablesLoadAllVm>();
        }
    }
}
