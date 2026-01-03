using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleFuelCount.VehicleFuelCountDelete.VehicleFuelCountDeleteCommand
{

    ///   @author  Shimels Alem Vehicle_FuelCountDelete stored procedure.

    public class VehicleFuelCountDeleteCommand : IRequest<IList<VehicleFuelCount_Vehicle_CountID>>
    {
        public Guid Vehicle_CountID { get; set; }
    }
		
		 
	}
 
 
