using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleLeaseTo.VehicleLeaseToInsert.VehicleLeaseToInsertCommand
{

    ///   @author  Shimels Alem Vehicle_LeaseToInsert stored procedure.

    public class VehicleLeaseToInsertCommand : IRequest<IList<VehicleLeaseTo_Vehicle_LeaseToID>>
    {
        public Guid? Vehicle_LeaseToID { get; set; }
        public Guid? Customer_ID { get; set; }
        public double? Millage { get; set; }
        public Guid? Vehicle_ID { get; set; }
        public Guid? Fleet_ContractID { get; set; }
        public string Remark { get; set; }
    }
		
		 
	}
 
 
