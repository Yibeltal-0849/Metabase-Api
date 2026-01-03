using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.Employee_Doucment.GetEmployeeDoucmentLoadAll;

namespace XOKA.Application.HRA.Quiries.Employee_Doucment.GetEmployeeDoucmentByPrimaryKey_employee_Id
{
    /// @author  Shimels Alem  proc_C_EmployeeLoadByPrimaryKey_User_ID stored procedure.

    public class GetEmployeeDoucmentByPrimaryKey_employee_Id : IRequest<GetEmployeeDoucmentLoadAllListVm>
    {
        public Guid Employee_Id { get; set; }
    }
}
