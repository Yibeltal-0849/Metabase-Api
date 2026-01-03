using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetAnnualStrategicPlanAssignmentLoadAll;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyApplicationNumber
{
    public class GetprocAnnualStrategicPlanAssignmentLoadByPrimaryKeyApplicationNumber : IRequest<GetAnnualStrategicPlanAssignmentLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
