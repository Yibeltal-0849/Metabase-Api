using System;
using System.Collections.Generic;
using System.Text;

namespace XOKA.Application.HRA.Quiries.BankDetail
{
    /// @author  Shimels Alem  [proc_C_EmployeeLoadAll] stored procedure.

    public class GetBankDetailLoadAllListVm
    {
        public IList<GetBankDetailLoadAllVm> BankDetails { get; set; }
    }
}
