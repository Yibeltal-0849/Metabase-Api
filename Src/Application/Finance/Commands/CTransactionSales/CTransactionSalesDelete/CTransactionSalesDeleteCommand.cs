 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CTransactionSales.CTransactionSalesDelete.CTransactionSalesDeleteCommand
{

    // @author  Shimels Alem  CTransaction_SalesDelete stored procedure.


    public class CTransactionSalesDeleteCommand : IRequest<IList<CTransactionSales_No>>
    {
        public string No { get; set; }
    }
		
     
		
		 
}
 
 