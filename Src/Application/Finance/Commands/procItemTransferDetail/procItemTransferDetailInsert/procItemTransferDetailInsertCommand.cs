


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procItemTransferDetail.procItemTransferDetailInsert.procItemTransferDetailInsertCommand
{

	/// @author  Shimels Alem  proc_Item_Transfer_DetailInsert stored procedure.


	public class procItemTransferDetailInsertCommand : IRequest<IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
		public string Transfer_Req_DetailID { get; set; }
		public string Vocher_NO { get; set; }
		public string Json_Data { get; set; }
		public string Log { get; set; }
	}
		
		
		 
}
 
 