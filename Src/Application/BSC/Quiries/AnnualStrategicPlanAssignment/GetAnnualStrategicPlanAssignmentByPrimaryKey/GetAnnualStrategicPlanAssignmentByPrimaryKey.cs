using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetAnnualStrategicPlanAssignmentLoadAll;

namespace XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment.GetAnnualStrategicPlanAssignmentByPrimaryKey
{
    public class GetAnnualStrategicPlanAssignmentByPrimaryKey : IRequest<GetAnnualStrategicPlanAssignmentLoadAllListVm>
    {
        public Guid ASPA_ID { get; set; }
    }
}
