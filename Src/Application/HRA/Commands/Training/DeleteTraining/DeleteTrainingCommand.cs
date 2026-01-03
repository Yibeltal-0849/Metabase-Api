using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Training.DeleteTraining
{
    /// @author  Shimels Alem  DeleteCTraining stored procedure.
    
    public class DeleteTrainingCommand : IRequest<IList<Training_Training_ID>>
    {
        public string Training_ID { get; set; }
    }
}
