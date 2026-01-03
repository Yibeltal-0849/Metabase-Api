


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.procBacDataCollectionTransaction.procBacDataCollectionTransactionInsert.procBacDataCollectionTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_Bac_Data_Collection_TransactionInsert stored procedure.


    public class procBacDataCollectionTransactionInsertCommand : IRequest<IList<BacDataCollectionTransaction_BSCTranID>>
    {
        public System.Guid Bsc_Tran_Data_Id { get; set; }
        public System.Guid? ApplicationCode { get; set; }
        public string Application_NO { get; set; }
        public System.Guid? KPIMapping_ID { get; set; }
        public string Year { get; set; }
        public string Perod { get; set; }
        public System.DateTime? Period_Start_Date { get; set; }
        public System.DateTime? Period_End_Date { get; set; }
        public string Innitiative_ID { get; set; }
  
    }
		
		
		 
}
 
 