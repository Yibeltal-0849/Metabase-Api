


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemReturnDetail.ItemReturnDetailInsert.ItemReturnDetailInsertCommand
{

    /// @author  Shimels Alem  Item_Return_DetailInsert stored procedure.


    public class ItemReturnDetailInsertCommand : IRequest<IList<ItemReturnDetail_Request_DetailID>>
    {
        public long? Request_DetailID { get; set; }
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
 
 