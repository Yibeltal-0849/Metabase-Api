 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumptionTransaction.proctblConsumptionTransactionDelete.proctblConsumptionTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_tblConsumption_TransactionDelete stored procedure.


    public class proctblConsumptionTransactionDeleteCommand : IRequest<IList<tblConsumptionTransaction_Tranaction_Id>>
    {
        public string Tranaction_Id { get; set; }
    }
		
     
		
		 
}
 
 