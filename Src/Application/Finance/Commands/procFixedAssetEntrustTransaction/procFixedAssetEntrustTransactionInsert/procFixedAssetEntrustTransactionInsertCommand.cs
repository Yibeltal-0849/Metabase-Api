


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetEntrustTransaction.procFixedAssetEntrustTransactionInsert.procFixedAssetEntrustTransactionInsertCommand
{

	/// @author  Shimels Alem  proc_Fixed_Asset_Entrust_TransactionInsert stored procedure.


	public class procFixedAssetEntrustTransactionInsertCommand : IRequest<IList<FixedAssetEntrustTransaction_EntrustTransID>>
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
 
 