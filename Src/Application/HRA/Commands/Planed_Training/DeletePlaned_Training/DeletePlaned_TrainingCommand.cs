using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Planed_Training.DeletePlaned_Training
{
    /// @author  Shimels Alem  proc_Planed_TrainingDelete stored procedure.
    
    public class DeletePlaned_TrainingCommand : IRequest<IList<PlanedTraining_Training_Planed_ID>>
    {
        public Guid Training_Planed_ID { get; set; }
    }
}
