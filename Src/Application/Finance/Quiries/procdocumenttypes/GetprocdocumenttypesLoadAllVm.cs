using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procdocumenttypes
{
    public class GetprocdocumenttypesLoadAllVm : IMapFrom<documenttypes>
    {
        public System.Guid document_type_code { get; set; }
        public string description { get; set; }
        public bool? is_synched { get; set; }
        public System.DateTime? date_synched { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<documenttypes, GetprocdocumenttypesLoadAllVm>();
        }
    }
}
