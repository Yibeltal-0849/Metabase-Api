using Application.Common.Mappings;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Quiries.procAnnualStrategicGoalsDetails
{
    public class GetprocAnnualStrategicGoalsDetailsLoadAllVm : IMapFrom<proc_AnnualStrategicGoalsDetails>
    {
        public string ASGD_ID { get; set; }
        public string Annual_Strategic_GoalID { get; set; }
        public string Strategic_Goal { get; set; }
        public double? Goal_Value_In_per { get; set; }
        public string Goal_Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<proc_AnnualStrategicGoalsDetails, GetprocAnnualStrategicGoalsDetailsLoadAllVm>();
        }
    }
}
