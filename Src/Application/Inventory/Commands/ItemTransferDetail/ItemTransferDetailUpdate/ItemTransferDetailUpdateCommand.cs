using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemTransferDetail.ItemTransferDetailUpdate.ItemTransferDetailUpdateCommand
{

	/// @author  Shimels Alem  Item_Transfer_DetailUpdate stored procedure.


	public class ItemTransferDetailUpdateCommand : IRequest<IList<ItemTransferDetail_Transfer_Req_DetailID>>
	{
		public string Transfer_Req_DetailID { get; set; }
		public string Vocher_NO { get; set; }
		public string Json_Data { get; set; }
		public string Log { get; set; }
	}
		
		
		 
	}

