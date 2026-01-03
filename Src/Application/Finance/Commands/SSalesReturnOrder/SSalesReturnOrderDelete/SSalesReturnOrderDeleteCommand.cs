 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalesReturnOrder.SSalesReturnOrderDelete.SSalesReturnOrderDeleteCommand
{

    // @author  Shimels Alem  S_Sales_Return_OrderDelete stored procedure.


    public class SSalesReturnOrderDeleteCommand : IRequest<IList<SSalesReturnOrder_Sales_Return_Order_Line>>
    {
        public string Sales_Return_Order_Line { get; set; }
    }
		
     
		
		 
}
 
 