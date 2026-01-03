using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetailsGroupByPerspective
{
    public class GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllVm : IMapFrom<AnnualStrategicGoalsDetailsGroupByPerspective>
    {
        public System.Guid ASGDGP_ID { get; set; }
        public string Perspective_ID { get; set; }
        public string ASGD_ID { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AnnualStrategicGoalsDetailsGroupByPerspective, GetprocAnnualStrategicGoalsDetailsGroupByPerspectiveLoadAllVm>();
        }
    }
}
