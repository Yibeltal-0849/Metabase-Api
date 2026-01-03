using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Training_Application.GetTraining_ApplicationLoadAll;

namespace XOKA.Application.HRA.Quiries.Training_Application.Getproc_Training_ApplicationLoadByPrimaryKey_Training_Planed_ID
{
    /// @author  Shimels Alem  proc_Training_ApplicationLoadByPrimaryKey_Training_Planed_ID stored procedure.

    public class Getproc_Training_ApplicationLoadByPrimaryKey_Training_Planed_ID : IRequest<GetTraining_ApplicationLoadAllListVm>
    {
        public System.Guid Training_Planed_ID { get; set; }
    }
}
