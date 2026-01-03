using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ProprtyData.Queries.proctblConsumptionTransaction.GetproctblConsumptionTransactionLoadAll
{
    /// @author  Shimels Alem  proc_tblConsumption_TransactionLoadAll stored procedure.

    public class GetproctblConsumptionTransactionLoadAllListVm
    {
        public IList<GetproctblConsumptionTransactionLoadAllVm> proctblConsumptionTransactions { get; set; }
    }
}
