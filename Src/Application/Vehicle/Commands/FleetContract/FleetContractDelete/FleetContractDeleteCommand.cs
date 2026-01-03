using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.FleetContract.FleetContractDelete.FleetContractDeleteCommand
{

    ///   @author  Shimels Alem proc_Fleet_ContractDelete stored procedure.

    public class FleetContractDeleteCommand : IRequest<IList<FleetContract_Contract_ID>>
    {
		public string Contract_ID { get; set; }
    }
		
		 
	}
 
 
