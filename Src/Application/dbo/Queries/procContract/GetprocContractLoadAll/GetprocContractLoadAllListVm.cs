using System;
using System.Collections.Generic;
using System.Text;

namespace Application.dbo.Quiries.procContract.GetprocContractLoadAll
{
    /// @author  Shimels Alem  proc_ContractLoadAll stored procedure.

    public class GetprocContractLoadAllListVm
    {
        public IList<GetprocContractLoadAllVm> procContracts { get; set; }
    }
}
