using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetAnnualStrategicPlanAssignmentLoadAll;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyASGDID
{
    public class GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyASGDID : IRequest<GetAnnualStrategicPlanAssignmentLoadAllListVm>
    {
        public string ASGD_ID { get; set; }
    }
}
