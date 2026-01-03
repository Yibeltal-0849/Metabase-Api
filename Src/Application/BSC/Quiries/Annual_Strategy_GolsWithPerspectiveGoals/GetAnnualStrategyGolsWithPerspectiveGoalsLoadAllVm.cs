using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Quiries.Annual_Strategy_GolsWithPerspective
{
    public class GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllVm : IMapFrom<Proc_Annual_Strategy_GolsWithPerspective>
    {
        public System.Guid?PerspectiveGoal_ID { get; set; }
        public string Perspective_ID { get; set; }
        public string Annual_Strategic_GoalID { get; set; }
        public double? Perspective_Value_IN_Per { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Proc_Annual_Strategy_GolsWithPerspective, GetAnnualStrategyGolsWithPerspectiveGoalsLoadAllVm>();
        }
    }
}
