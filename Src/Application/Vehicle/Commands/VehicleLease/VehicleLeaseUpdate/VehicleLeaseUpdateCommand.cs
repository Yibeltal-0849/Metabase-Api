using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleLease.VehicleLeaseUpdate.VehicleLeaseUpdateCommand
{

    ///   @author  Shimels Alem proc_Vehicle_LeaseUpdate stored procedure.

    public class VehicleLeaseUpdateCommand : IRequest<IList<VehicleLease_Vehicle_LeaseID>>
    {
        public Guid Vehicle_LeaseID { get; set; }
        public string Vendor_ID { get; set; }
        public double? Millage { get; set; }
        public Guid? Vehicle_ID { get; set; }
        public Guid? Fleet_ContractID { get; set; }
        public string Remark { get; set; }
        public string Application_Number { get; set; }
        public Guid? Application_Code { get; set; }

    }
		
		 
}
 
 
