


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.StockBIN.StockBINInsert.StockBINInsertCommand
{

	/// @author  Shimels Alem  Stock_BINInsert stored procedure.


	public class StockBINInsertCommand : IRequest<IList<Stock_BIN_Store_ID>>
	{
		public string Store_ID { get; set; }
		public string ItemID { get; set; }
	}
		
		
		 
	}
 
 