 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemActivity.ItemActivityDelete.ItemActivityDeleteCommand
{

    // @author  Shimels Alem  Item_ActivityDelete stored procedure.


    public class ItemActivityDeleteCommand : IRequest<IList<ItemActivity_Vocher_NO>>
    {
        public string Vocher_NO { get; set; }
    }
		
     
		
		 
	}
 
 