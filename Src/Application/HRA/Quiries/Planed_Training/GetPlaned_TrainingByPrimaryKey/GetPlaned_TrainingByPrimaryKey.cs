using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Planed_Training.GetPlaned_TrainingLoadAll;

namespace XOKA.Application.HRA.Quiries.Planed_Training.GetPlaned_TrainingByPrimaryKey
{
    /// @author  Shimels Alem  proc_Planed_TrainingLoadByPrimaryKey stored procedure.

    public class GetPlaned_TrainingByPrimaryKey : IRequest<GetPlaned_TrainingLoadAllListVm>
    {
        public System.Guid Training_Planed_ID { get; set; }
    }
}
