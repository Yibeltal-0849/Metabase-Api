using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFixedAssetManagementTransaction.procFixedAssetManagementTransactionUpdate.procFixedAssetManagementTransactionUpdateCommand
{

	/// @author  Shimels Alem  proc_Fixed_Asset_Management_TransactionUpdate stored procedure.


	public class procFixedAssetManagementTransactionUpdateCommand : IRequest<IList<FixedAssetManagementTransaction_FixedAsset_Trans_ID>>
   {
		public System.Guid FixedAsset_Trans_ID { get; set; }
		public string application_number { get; set; }
		public System.DateTime? Request_Date { get; set; }
		public System.Guid? services_service_code { get; set; }
		public string Service_Name { get; set; }
		public System.Guid? organization_code { get; set; }
		public System.Guid? Managed_By { get; set; }
		public System.Guid? DIV { get; set; }
		public System.Guid? Created_By { get; set; }
		public System.Guid? Updated_By { get; set; }
		public string Log { get; set; }
	}
		
		
		 
}

