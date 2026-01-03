using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleFuelCount.VehicleFuelCountUpdate.VehicleFuelCountUpdateCommand
{

    ///   @author  Shimels Alem Vehicle_FuelCountUpdate stored procedure.

    public class VehicleFuelCountUpdateCommand : IRequest<IList<VehicleFuelCount_Vehicle_CountID>>
    {
        public Guid Vehicle_CountID { get; set; }
        public Guid? Vehicle_DispatchID { get; set; }
        public double? Fill_Amount { get; set; }
        public double? Last_Amount { get; set; }
        public Guid? document_detail_id { get; set; }
    }
		
		 
	}
 
 
