using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblVarableBasedTables
{
    public class GetproctblVarableBasedTablesLoadAllVm : IMapFrom<tblVarableBasedTables>
    {
        public long id { get; set; }
        public string Name { get; set; }
        public string Type_Table_Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblVarableBasedTables, GetproctblVarableBasedTablesLoadAllVm>();
        }
    }
}
