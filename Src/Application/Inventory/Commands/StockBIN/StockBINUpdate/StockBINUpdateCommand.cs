using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.StockBIN.StockBINUpdate.StockBINUpdateCommand
{

	/// @author  Shimels Alem  Stock_BINUpdate stored procedure.


	public class StockBINUpdateCommand : IRequest<IList<Stock_BIN_Store_ID>>
	{
		public string Store_ID { get; set; }
		public string ItemID { get; set; }
	}
		
		
		 
	}

