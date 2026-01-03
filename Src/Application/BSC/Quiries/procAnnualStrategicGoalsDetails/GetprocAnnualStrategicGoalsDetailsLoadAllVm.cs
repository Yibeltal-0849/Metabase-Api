using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Quiries.procAnnualStrategicGoalsDetails
{
    public class GetprocAnnualStrategicGoalsDetailsLoadAllVm : IMapFrom<AnnualStrategicGoalsDetails>
    {
        public string ASGD_ID { get; set; }
        public string Annual_Strategic_GoalID { get; set; }
        public string Strategic_Goal { get; set; }
        public System.Double? Goal_Value_In_Per { get; set; }
        public string Goal_Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AnnualStrategicGoalsDetails, GetprocAnnualStrategicGoalsDetailsLoadAllVm>();
        }
    }
}
