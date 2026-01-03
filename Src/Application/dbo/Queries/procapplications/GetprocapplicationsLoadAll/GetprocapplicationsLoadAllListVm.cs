using System;
using System.Collections.Generic;
using System.Text;

namespace Application.dbo.Quiries.procapplications.GetprocapplicationsLoadAll
{
    /// @author  Shimels Alem  proc_applicationsLoadAll stored procedure.

    public class GetprocapplicationsLoadAllListVm
    {
        public IList<GetprocapplicationsLoadAllVm> procapplicationss { get; set; }
    }
}
