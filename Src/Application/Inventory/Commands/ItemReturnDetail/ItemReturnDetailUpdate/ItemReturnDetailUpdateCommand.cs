using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemReturnDetail.ItemReturnDetailUpdate.ItemReturnDetailUpdateCommand
{

	/// @author  Shimels Alem  Item_Return_DetailUpdate stored procedure.


	public class ItemReturnDetailUpdateCommand : IRequest<IList<ItemReturnDetail_Request_DetailID>>
    {
        public long Request_DetailID { get; set; }
        public string Requsition_ID { get; set; }
        public string Item_ID { get; set; }
        public double? Quantity { get; set; }
        public string Unit { get; set; }
        public string Remark { get; set; }
        public bool? Is_PO { get; set; }
        public bool? From_Store { get; set; }
        public string Log { get; set; }
    }
		
		
		 
	}

