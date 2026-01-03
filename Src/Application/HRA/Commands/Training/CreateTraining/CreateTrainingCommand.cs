using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Training.CreateTraining
{
    /// @author  Shimels Alem  CreateCTraining stored procedure.
    
    public class CreateTrainingCommand : IRequest<IList<Training_Training_ID>>
    {
        public string Training_ID { get; set; }
        public string Training_Name { get; set; }
        public int? Training_Hour { get; set; }
        public string Description { get; set; }
        public double? Pass_Point { get; set; }
        public bool? Is_Active { get; set; }
    }
}
