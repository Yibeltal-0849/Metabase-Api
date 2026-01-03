 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemReturnDetail.ItemReturnDetailDelete.ItemReturnDetailDeleteCommand
{

    // @author  Shimels Alem  Item_Return_DetailDelete stored procedure.


    public class ItemReturnDetailDeleteCommand : IRequest<IList<ItemReturnDetail_Request_DetailID>>
    {
        public long Request_DetailID { get; set; }
    }
		
     
		
		 
	}
 
 