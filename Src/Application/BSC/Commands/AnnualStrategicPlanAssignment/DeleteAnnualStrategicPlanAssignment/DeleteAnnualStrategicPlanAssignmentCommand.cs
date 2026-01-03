using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.AnnualStrategicPlanAssignment.DeleteAnnualStrategicPlanAssignment
{
    public class DeleteAnnualStrategicPlanAssignmentCommand : IRequest<IList<Proc_Annual_Strategic_Plan_Assignment_ASPA_ID>>
    {
        public Guid ASPA_ID { get; set; }
    }
}
