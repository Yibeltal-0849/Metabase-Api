using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procGenBusPostingGroups
{
    public class GetprocGenBusPostingGroupsLoadAllVm : IMapFrom<GenBusPostingGroups>
    {

        public string Code { get; set; }
        public string Description { get; set; }
        public string Def_VATBusPostingGroup { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<GenBusPostingGroups, GetprocGenBusPostingGroupsLoadAllVm>();
        }
    }
}
