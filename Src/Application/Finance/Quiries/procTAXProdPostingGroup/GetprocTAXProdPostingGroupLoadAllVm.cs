using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procTAXProdPostingGroup
{
    public class GetprocTAXProdPostingGroupLoadAllVm : IMapFrom<TaxProdPostingGroup>
    {

        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TaxProdPostingGroup, GetprocTAXProdPostingGroupLoadAllVm>();
        }
    }
}
