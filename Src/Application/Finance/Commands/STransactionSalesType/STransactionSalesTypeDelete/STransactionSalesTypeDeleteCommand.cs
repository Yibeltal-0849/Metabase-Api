 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.STransactionSalesType.STransactionSalesTypeDelete.STransactionSalesTypeDeleteCommand
{
    
    // @author  Shimels Alem  [S_Transaction Sales_TypeDelete] stored procedure.


    public class STransactionSalesTypeDeleteCommand : IRequest<IList<STransactionSalesType_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 