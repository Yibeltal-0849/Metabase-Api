


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumptionTransaction.proctblConsumptionTransactionInsert.proctblConsumptionTransactionInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumption_TransactionInsert stored procedure.


    public class proctblConsumptionTransactionInsertCommand : IRequest<IList<tblConsumptionTransaction_Tranaction_Id>>
    {
        public string Tranaction_Id { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public bool? Complited { get; set; }
    }
		
		
		 
}
 
 