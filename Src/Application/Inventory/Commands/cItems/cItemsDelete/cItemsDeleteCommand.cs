 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.cItems.cItemsDelete.cItemsDeleteCommand
{

    // @author  Shimels Alem  c_ItemsDelete stored procedure.

    public class cItemsDeleteCommand : IRequest<IList<C_Items_Item_Id>>
    {
        public string Item_Id { get; set; }
    }
		
     
		
		 
	}
 
 