 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalseorder.SSalseorderDelete.SSalseorderDeleteCommand
{

    // @author  Shimels Alem  S_Salse_orderDelete stored procedure.


    public class SSalseorderDeleteCommand : IRequest<IList<SSalseOrder_Sales_Order_Line_ID>>
    {
        public string Sales_Order_Line_ID { get; set; }
    }
		
     
		
		 
}
 
 