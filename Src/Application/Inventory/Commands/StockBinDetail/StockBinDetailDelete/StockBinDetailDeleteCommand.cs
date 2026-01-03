 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.StockBinDetail.StockBinDetailDelete.StockBinDetailDeleteCommand
{

    // @author  Shimels Alem  Stock_Bin_DetailDelete stored procedure.


    public class StockBinDetailDeleteCommand : IRequest<IList<StockBinDetail_Store_ID>>
    {
        public string Store_ID { get; set; }
        public string ItemID { get; set; }
        public System.DateTime Date { get; set; }
    }
		
     
		
		 
	}
 
 