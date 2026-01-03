 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PBlanketpurchaseorder.PBlanketpurchaseorderDelete.PBlanketpurchaseorderDeleteCommand
{

    // @author  Shimels Alem  [P_Blanket purchase orderDelete] stored procedure.


    public class PBlanketpurchaseorderDeleteCommand : IRequest<IList<PBlanketPurchaseOrder_Purchase_Line>>
    {
        public System.Guid Purchase_Line { get; set; }
    }
		
     
		
		 
}
 
 