using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.FleetContract.FleetContractUpdate.FleetContractUpdateCommand
{

    ///   @author  Shimels Alem proc_Fleet_ContractUpdate stored procedure.

    public class FleetContractUpdateCommand : IRequest<IList<FleetContract_Contract_ID>>
    {
        public string Contract_ID { get; set; }
        public string Customer_ID { get; set; }
        public string Contract_Title { get; set; }
        public System.Guid? Organization_ID { get; set; }
        public string Vendor_ID { get; set; }
        public double? Contract_Amount { get; set; }
        public string Fleet_Contract_Type { get; set; }
        public string Is_Active { get; set; }
    }
		
		 
	}
 
 
