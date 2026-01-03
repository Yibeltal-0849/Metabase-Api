using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Training_Application.DeleteTraining_Application
{
    /// @author  Shimels Alem  DeleteCTraining_Application stored procedure.
    
    public class DeleteTraining_ApplicationCommand : IRequest<IList<TrainingApplication_Training_Planed_ID>>
    {
        public Guid Training_Planed_ID { get; set; }
        public string Employee_ID { get; set; }
    }
}
