using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Planed_Training.GetPlaned_TrainingLoadAll;

namespace XOKA.Application.HRA.Quiries.Planed_Training.Getproc_Planed_TrainingLoadByPrimaryKey_Application_Code
{
    /// @author  Shimels Alem  proc_Planed_TrainingLoadByPrimaryKey_Application_Code stored procedure.

    public class Getproc_Planed_TrainingLoadByPrimaryKey_Application_Code : IRequest<GetPlaned_TrainingLoadAllListVm>
    {
        public System.Guid Application_Code { get; set; }
    }
}
