using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procBankAccountPostingGroup
{
    public class GAvalable_bankVm : IMapFrom<Availablebanks>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool? dufault { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Availablebanks, GAvalable_bankVm>();
        }
    }
}
