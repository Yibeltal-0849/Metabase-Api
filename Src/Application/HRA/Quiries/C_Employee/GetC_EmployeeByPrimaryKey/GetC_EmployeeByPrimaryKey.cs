using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using XOKA.Application.HRA.Quiries.C_Employee.GetC_EmployeeLoadAll;

namespace XOKA.Application.HRA.Quiries.C_Employee.GetC_EmployeeByPrimaryKey
{
    /// @author  Shimels Alem  proc_C_EmployeeLoadByPrimaryKey stored procedure.

    public class GetC_EmployeeByPrimaryKey : IRequest<GetC_EmployeeLoadAllListVm>
    {
        public Guid User_ID { get; set; }
    }
}
