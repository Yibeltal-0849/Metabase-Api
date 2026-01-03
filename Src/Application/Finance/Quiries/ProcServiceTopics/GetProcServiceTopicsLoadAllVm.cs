using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.ProcServiceTopics
{
    public class GetProcServiceTopicsLoadAllVm : IMapFrom<Service_Topics>
    {
        public System.Guid topic_Code { get; set; }
        public System.Guid service_Code { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Service_Topics, GetProcServiceTopicsLoadAllVm>();
        }
    }
}
