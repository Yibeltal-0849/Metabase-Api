using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.proccPaymentMethod
{
    public class GetproccPaymentMethodLoadAllVm : IMapFrom<CPaymentMethod>
    {

        public long Id { get; set; }
        public string Method { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CPaymentMethod, GetproccPaymentMethodLoadAllVm>();
        }
    }
}
