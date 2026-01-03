using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Queries.proctblImport
{
    public class GetproctblImportLoadAllVm : IMapFrom<tblImport>
    {
        public long id { get; set; }
        public long Company_id { get; set; }
        public long? Energy_Chain_id { get; set; }
        public long? Energy_id { get; set; }
        public long Supplier_id { get; set; }
        public System.DateTime Imported_Period { get; set; }
        public decimal Value { get; set; }
        public long Unit { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<tblImport, GetproctblImportLoadAllVm>();
        }
    }
}
