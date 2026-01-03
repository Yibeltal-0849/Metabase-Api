using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationLoadAll;

namespace XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationByPrimaryKey
{
    /// @author  Shimels Alem  proc_Training_ApplicationLoadByPrimaryKey stored procedure.

    public class GetTraining_ApplicationByPrimaryKey : IRequest<GetTraining_ApplicationLoadAllListVm>
    {
        public string Employee_ID { get; set; }
        public System.Guid Training_Planed_ID { get; set; }
    }
}
