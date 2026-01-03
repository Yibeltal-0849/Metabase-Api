using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationLoadAll;

namespace XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationByEmployee_ID
{
    /// @author  Shimels Alem  proc_Training_ApplicationLoadByPrimaryKey stored procedure.

    public class GetTraining_ApplicationByEmployee_ID : IRequest<GetTraining_ApplicationLoadAllListVm>
    {
        public string Employee_ID { get; set; }
       
    }
}
