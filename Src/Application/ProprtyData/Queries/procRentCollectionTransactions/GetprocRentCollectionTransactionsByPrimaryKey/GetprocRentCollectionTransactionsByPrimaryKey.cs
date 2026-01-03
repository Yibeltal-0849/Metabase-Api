using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.ProprtyData.Quiries.procRentCollectionTransactions.GetprocRentCollectionTransactionsLoadAll;

namespace Application.ProprtyData.Quiries.procRentCollectionTransactions.GetprocRentCollectionTransactionsByPrimaryKey
{
    /// @author  Shimels Alem proc_Rent_Collection_TransactionsLoadByPrimaryKey stored procedure.

    public class GetprocRentCollectionTransactionsByPrimaryKey : IRequest<GetprocRentCollectionTransactionsLoadAllListVm>
    {
        public System.Guid Rent_Collection_ID { get; set; }
    }
}
