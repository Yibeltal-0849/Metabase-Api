using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFixedAssetEntrustTransaction.procFixedAssetEntrustTransactionUpdate.procFixedAssetEntrustTransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_Fixed_Asset_Entrust_TransactionUpdate stored procedure.


	public class procFixedAssetEntrustTransactionUpdateCommand : IRequest<IList<FixedAssetEntrustTransaction_EntrustTransID>>
   {
		public System.Guid Entrust_Trans_ID { get; set; }
		public string application_number { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public System.Guid? services_service_code { get; set; }
		public string Service_Name { get; set; }
		public System.Guid? organization_code { get; set; }
		public System.Guid? Requested_By { get; set; }
		public System.Guid? DIV { get; set; }
		public string Address { get; set; }
	}
		
		
		 
}

