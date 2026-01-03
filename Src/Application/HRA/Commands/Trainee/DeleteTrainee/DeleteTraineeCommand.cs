using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Trainee.DeleteTrainee
{
    /// @author  Shimels Alem  DeleteCTrainee stored procedure.
    
    public class DeleteTraineeCommand : IRequest<IList<Trainee_Training_Planed_ID>>
    {
        public Guid? Training_Planed_ID { get; set; }
    }
}
