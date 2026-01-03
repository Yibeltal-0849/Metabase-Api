using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.BSC.Quiries.AnnualStrategicPlanAssignment;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.AnnualStrategicPlanAssignment.UpdateAnnualStrategicPlanAssignment
{
    public class UpdateAnnualStrategicPlanAssignmentCommand : GetAnnualStrategicPlanAssignmentLoadAllVm, IRequest<IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>>
    {
    }
}
