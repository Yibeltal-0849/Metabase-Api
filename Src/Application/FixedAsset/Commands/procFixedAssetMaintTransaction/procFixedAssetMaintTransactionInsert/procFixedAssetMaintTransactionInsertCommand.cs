


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.procFixedAssetMaintTransaction.procFixedAssetMaintTransactionInsert.procFixedAssetMaintTransactionInsertCommand
{

	/// @author  Shimels Alem  proc_Fixed_Asset_Maint_TransactionInsert stored procedure.


	public class procFixedAssetMaintTransactionInsertCommand : IRequest<IList<FixedAssetMaintTransaction_FixedAsset_Maintan_Trans_ID>>
    {
		public System.Guid FixedAsset_Maintan_Trans_ID { get; set; }
		public string application_number { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public System.Guid? services_service_code { get; set; }
		public string Service_Name { get; set; }
		public System.Guid? organization_code { get; set; }
		public System.Guid? Requested_By { get; set; }
		public System.Guid? DIV { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public string Log { get; set; }
	}
		
		
		 
}
 
 