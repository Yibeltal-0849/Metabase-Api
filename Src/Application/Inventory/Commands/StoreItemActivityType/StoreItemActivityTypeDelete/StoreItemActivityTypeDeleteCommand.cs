 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.StoreItemActivityType.StoreItemActivityTypeDelete.StoreItemActivityTypeDeleteCommand
{

    // @author  Shimels Alem  Store_Item_Activity_TypeDelete stored procedure.


    public class StoreItemActivityTypeDeleteCommand : IRequest<IList<Store_Item_Activity_Type_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
	}
 
 