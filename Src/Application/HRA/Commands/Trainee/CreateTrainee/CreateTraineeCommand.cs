using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Domain.Entities.HRA;

namespace XOKA.Application.HRA.Commands.Trainee.CreateTrainee
{
    /// @author  Shimels Alem  CreateCTrainee stored procedure.
    
    public class CreateTraineeCommand : IRequest<IList<Trainee_Training_Planed_ID>>
    {
        public Guid? Training_Planed_ID { get; set; }
        public string Employee_ID { get; set; }
        public string Full_Name { get; set; }
        public bool? IS_Approved { get; set; }
        public Guid? Approved_By { get; set; }
        public string Remark { get; set; }
        public string Result { get; set; }
    }
}
