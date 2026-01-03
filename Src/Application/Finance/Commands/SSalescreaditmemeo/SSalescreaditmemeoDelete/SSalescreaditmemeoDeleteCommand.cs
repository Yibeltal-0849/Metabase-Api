 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalescreaditmemeo.SSalescreaditmemeoDelete.SSalescreaditmemeoDeleteCommand
{

    // @author  Shimels Alem  S_Sales_creadit_memeoDelete stored procedure.


    public class SSalescreaditmemeoDeleteCommand : IRequest<IList<SSalesCreaditMemeo_Sales_Credit_Line_Id>>
    {
        public string Sales_Credit_Line_Id { get; set; }
    }
		
     
		
		 
}
 
 