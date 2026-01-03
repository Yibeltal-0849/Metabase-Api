 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.Store.StoreDelete.StoreDeleteCommand
{

    // @author  Shimels Alem  StoreDelete stored procedure.


    public class StoreDeleteCommand : IRequest<IList<_Store_Store_code>>
    {
        public string Store_code { get; set; }
    }
			 
	}
 
 