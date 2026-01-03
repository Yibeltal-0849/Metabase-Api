 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.StockBIN.StockBINDelete.StockBINDeleteCommand
{

    // @author  Shimels Alem  Stock_BINDelete stored procedure.


    public class StockBINDeleteCommand : IRequest<IList<Stock_BIN_Store_ID>>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
    }
		
     
		
		 
	}
 
 