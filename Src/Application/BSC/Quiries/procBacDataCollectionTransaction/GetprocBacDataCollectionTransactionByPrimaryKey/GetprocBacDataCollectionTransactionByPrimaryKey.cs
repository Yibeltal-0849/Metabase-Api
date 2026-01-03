using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionLoadAll;

namespace Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionByPrimaryKey
{
    /// @author  Shimels Alem proc_Bac_Data_Collection_TransactionLoadByPrimaryKey stored procedure.

    public class GetprocBacDataCollectionTransactionByPrimaryKey : IRequest<GetprocBacDataCollectionTransactionLoadAllListVm>
    {
        public System.Guid Bsc_Tran_Data_Id { get; set; }
    }
}
