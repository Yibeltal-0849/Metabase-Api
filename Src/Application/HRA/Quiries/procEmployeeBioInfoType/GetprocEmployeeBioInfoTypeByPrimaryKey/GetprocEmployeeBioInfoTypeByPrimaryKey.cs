using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.HRA.Quiries.procEmployeeBioInfoType.GetprocEmployeeBioInfoTypeLoadAll;

namespace Application.HRA.Quiries.procEmployeeBioInfoType.GetprocEmployeeBioInfoTypeByPrimaryKey
{
    /// @author  Shimels Alem proc_Employee_Bio_Info_TypeLoadByPrimaryKey stored procedure.

    public class GetprocEmployeeBioInfoTypeByPrimaryKey : IRequest<GetprocEmployeeBioInfoTypeLoadAllListVm>
    {
        public string Bio_Type_ID { get; set; }
    }
}
