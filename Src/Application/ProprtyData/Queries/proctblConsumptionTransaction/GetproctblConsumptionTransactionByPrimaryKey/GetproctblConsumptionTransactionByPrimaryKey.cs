using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Queries.proctblConsumptionTransaction.GetproctblConsumptionTransactionLoadAll;

namespace Application.ProprtyData.Queries.proctblConsumptionTransaction.GetproctblConsumptionTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_tblConsumption_TransactionLoadByPrimaryKey stored procedure.

    public class GetproctblConsumptionTransactionByPrimaryKey : IRequest<GetproctblConsumptionTransactionLoadAllListVm>
    {
        public string Tranaction_Id { get; set; }
    }
}
