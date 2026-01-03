using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procItemTransferDetail.procItemTransferDetailUpdate.procItemTransferDetailUpdateCommand
{

	/// @author  Shimels Alem  proc_Item_Transfer_DetailUpdate stored procedure.


	public class procItemTransferDetailUpdateCommand : IRequest<IList<ItemTransferDetail_Transfer_Req_DetailID>>
   {
		public string Transfer_Req_DetailID { get; set; }
		public string Vocher_NO { get; set; }
		public string Json_Data { get; set; }
		public string Log { get; set; }
	}
		
		
		 
}

