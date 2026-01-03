using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionLoadAll;

namespace Application.BSC.Quiries.procBacDataCollectionTransaction.GetprocBacDataCollectionTransactionLoadByPrimaryKeyApplicationNumber
{
    /// @author  Shimels Alem proc_Bac_Data_Collection_TransactionLoadByPrimaryKey_Application_Number stored procedure.

    public class GetprocBacDataCollectionTransactionLoadByPrimaryKeyApplicationNumber : IRequest<GetprocBacDataCollectionTransactionLoadAllListVm>
    {
        public string Application_Number { get; set; }
    }
}
