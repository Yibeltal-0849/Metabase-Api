using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procWithPostingGroup
{
    public class GetprocWithPostingGroupLoadAllVm : IMapFrom<With_Posting_Group>
    {

        public string Code { get; set; }
        public string Description { get; set; }
        public float Double { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<With_Posting_Group, GetprocWithPostingGroupLoadAllVm>();
        }
    }
}
