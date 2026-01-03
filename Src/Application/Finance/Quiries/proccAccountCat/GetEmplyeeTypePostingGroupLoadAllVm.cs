using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccAccountCat
{
    public class GetproccAccountCatLoadAllVm : IMapFrom<CAccountCat>
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<CAccountCat, GetproccAccountCatLoadAllVm>();
        }
    }
}
