


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFleetContract.procFleetContractInsert.procFleetContractInsertCommand
{

	/// @author  Shimels Alem  proc_Fleet_ContractInsert stored procedure.


	public class procFleetContractInsertCommand : IRequest<IList<FleetContract_Contract_ID>>
    {
		public string Contract_ID { get; set; }
		public System.Guid? Customer_ID { get; set; }
		public string Contract_Title { get; set; }
		public System.Guid? Organization_ID { get; set; }
		public System.Guid? Vendor_ID { get; set; }
		public System.Double? Contract_Amount { get; set; }
		public string Fleet_Contract_Type { get; set; }
		public string Is_Active { get; set; }
	}
		
		
		 
}
 
 