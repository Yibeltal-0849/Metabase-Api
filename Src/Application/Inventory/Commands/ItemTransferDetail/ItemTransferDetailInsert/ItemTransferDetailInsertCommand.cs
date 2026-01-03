


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Inventory.Commands.ItemTransferDetail.ItemTransferDetailInsert.ItemTransferDetailInsertCommand
{

    /// @author  Shimels Alem  Item_Transfer_DetailInsert stored procedure.


    public class ItemTransferDetailInsertCommand : IRequest<IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        public string Transfer_Req_DetailID { get; set; }
        public string Vocher_NO { get; set; }
        public string Json_Data { get; set; }
        public string Log { get; set; }
    }
		
		
		 
	}
 
 