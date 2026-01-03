using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procPJobLineType
{
    public class GetprocPJobLineTypeLoadAllVm : IMapFrom<PJobLineType>
    {
        public string Code { get; set; }
        public bool? IsActive { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<PJobLineType, GetprocPJobLineTypeLoadAllVm>();
        }
    }
}
