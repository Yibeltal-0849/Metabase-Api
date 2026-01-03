


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalescreaditmemeo.SSalescreaditmemeoInsert.SSalescreaditmemeoInsertCommand
{

    /// @author  Shimels Alem  S_Sales_creadit_memeoInsert stored procedure.


    public class SSalescreaditmemeoInsertCommand : IRequest<IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>>
    {
        public string Sales_Credit_Line_Id { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
		
		
		 
}
 
 