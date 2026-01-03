 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SBlanketSalesorder.SBlanketSalesorderDelete.SBlanketSalesorderDeleteCommand
{

    // @author  Shimels Alem  [S_Blanket_Sales_orderDelete] stored procedure.


    public class SBlanketSalesorderDeleteCommand : IRequest<IList<SBlanketSalesOrder_Sales_Blanket_Order_Line>>
    {
        public string Sales_Blanket_Order_Line { get; set; }
    }
		
     
		
		 
}
 
 