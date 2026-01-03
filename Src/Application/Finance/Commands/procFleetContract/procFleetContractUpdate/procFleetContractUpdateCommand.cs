using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procFleetContract.procFleetContractUpdate.procFleetContractUpdateCommand
{

	/// @author  Shimels Alem  proc_Fleet_ContractUpdate stored procedure.


	public class procFleetContractUpdateCommand : IRequest<IList<FleetContract_Contract_ID>>
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

