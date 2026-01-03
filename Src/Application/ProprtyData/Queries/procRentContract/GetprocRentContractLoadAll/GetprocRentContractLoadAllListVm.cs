using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ProprtyData.Queries.procRentContract.GetprocRentContractLoadAll
{
    /// @author  Shimels Alem  proc_Rent_ContractLoadAll stored procedure.

    public class GetprocRentContractLoadAllListVm
    {
        public IList<GetprocRentContractLoadAllVm> procRentContracts { get; set; }
    }
}
