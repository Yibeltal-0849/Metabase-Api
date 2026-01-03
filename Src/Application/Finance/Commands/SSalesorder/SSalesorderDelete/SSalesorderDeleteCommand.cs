 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalesorder.SSalesorderDelete.SSalesorderDeleteCommand
{

    // @author  Shimels Alem  S_Sales_orderDelete stored procedure.


    public class SSalesorderDeleteCommand : IRequest<IList<SSalesOrder_Sales_Order_Line>>
    {
        public string Sales_Order_Line { get; set; }
    }
		
     
		
		 
}
 
 