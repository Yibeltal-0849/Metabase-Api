 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemTransferDetail.ItemTransferDetailDelete.ItemTransferDetailDeleteCommand
{

    // @author  Shimels Alem  Item_Transfer_DetailDelete stored procedure.


    public class ItemTransferDetailDeleteCommand : IRequest<IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        public string Transfer_Req_DetailID { get; set; }
    }
		
     
		
		 
	}
 
 