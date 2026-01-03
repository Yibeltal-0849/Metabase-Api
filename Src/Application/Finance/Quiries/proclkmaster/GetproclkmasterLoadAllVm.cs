using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proclkmaster
{
    public class GetproclkmasterLoadAllVm : IMapFrom<lkmaster>
    {

        public System.Guid lkmaster_Code { get; set; }
        public string description { get; set; }
        public System.Guid parent { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<lkmaster, GetproclkmasterLoadAllVm>();
        }
    }
}
