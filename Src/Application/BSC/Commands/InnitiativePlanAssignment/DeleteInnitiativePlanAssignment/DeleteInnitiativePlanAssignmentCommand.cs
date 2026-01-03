using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.Bsc;

namespace XOKA.Application.BSC.Commands.InnitiativePlanAssignment.DeleteInnitiativePlanAssignment
{
    /// @author  Shimels Alem  Innitiative_Plan_AssignmentDelete stored procedure.

    public class DeleteInnitiativePlanAssignmentCommand : IRequest<IList<Innitiative_Plan_Assignment_IPA_ID>>
    {
        public Guid IPA_ID { get; set; }
    }
}
