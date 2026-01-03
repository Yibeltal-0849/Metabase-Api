using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Purchase.Quiries.PerchaseContract.GetPerchaseContractLoadAll
{
    /// @author  Shimels Alem  proc_Perchase_ContractLoadAll stored procedure.

    public class GetPerchaseContractLoadAllListVm
    {
        public IList<GetPerchaseContractLoadAllVm> PerchaseContracts { get; set; }
    }
}
