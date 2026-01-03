using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccPayType
{
    public class GetproccPayTypeLoadAllVm : IMapFrom<CPayType>
    {

        public string PayType { get; set; }
        public string GL_Account_Number { get; set; }
        public string OrgCode { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CPayType, GetproccPayTypeLoadAllVm>();
        }
    }
}
