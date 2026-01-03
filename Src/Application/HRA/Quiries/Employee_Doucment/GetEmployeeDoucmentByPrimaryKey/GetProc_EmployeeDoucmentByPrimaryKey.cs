using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Employee_Doucment.GetEmployeeDoucmentLoadAll;

namespace XOKA.Application.HRA.Quiries.Employee_Doucment.GetProc_EmployeeDoucmentByPrimaryKey
{
    /// @author  Shimels Alem  proc_C_EmployeeLoadByPrimaryKey_User_ID stored procedure.

    public class GetProc_EmployeeDoucmentByPrimaryKey : IRequest<GetEmployeeDoucmentLoadAllListVm>
    {
        public System.Guid ID { get; set; }
    }
}
