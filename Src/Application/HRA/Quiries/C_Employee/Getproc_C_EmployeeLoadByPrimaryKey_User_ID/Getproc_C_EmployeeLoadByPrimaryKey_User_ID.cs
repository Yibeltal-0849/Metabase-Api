using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.C_Employee.GetC_EmployeeLoadAll;

namespace XOKA.Application.HRA.Quiries.C_Employee.Getproc_C_EmployeeLoadByPrimaryKey_User_ID
{
    /// @author  Shimels Alem  proc_C_EmployeeLoadByPrimaryKey_User_ID stored procedure.

    public class Getproc_C_EmployeeLoadByPrimaryKey_User_ID : IRequest<GetC_EmployeeLoadAllListVm>
    {
        public System.Guid User_ID { get; set; }
    }
}
