using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Application.HRA.Quiries.C_Employee.GetC_EmployeeLoadAll
{
    /// @author  Shimels Alem  [proc_C_EmployeeLoadAll] stored procedure.

    public class GetC_EmployeeLoadAllListVm
    {
        public IList<GetC_EmployeeLoadAllVm> C_Employees { get; set; }
    }
}
