using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.Training.GetTrainingLoadAll;

namespace Application.HRA.Quiries.Training.GetTrainingByPrimaryKey
{
    /// @author  Shimels Alem proc_TrainingLoadByPrimaryKey stored procedure.

    public class GetTrainingByPrimaryKey : IRequest<GetTrainingLoadAllListVm>
    {
        public string Training_ID { get; set; }
    }
}
