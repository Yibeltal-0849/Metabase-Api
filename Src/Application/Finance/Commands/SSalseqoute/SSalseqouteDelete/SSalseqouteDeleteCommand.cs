 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalseqoute.SSalseqouteDelete.SSalseqouteDeleteCommand
{

    // @author  Shimels Alem  S_Salse_qouteDelete stored procedure.


    public class SSalseqouteDeleteCommand : IRequest<IList<SSalseQoute_Sales_Qoute_Line_ID>>
    {
        public string Sales_Qoute_Line_ID { get; set; }
    }
		
     
		
		 
}
 
 