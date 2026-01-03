using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.ActiveVehicle.ActiveVehicleUpdate.ActiveVehicleUpdateCommand
{

    ///  @author  Shimels Alem  Active_VehicleUpdate stored procedure.

    public class ActiveVehicleUpdateCommand : IRequest<IList<ActiveVehicle_ActiveVehicle_ID>>
    {
        public Guid ActiveVehicle_ID { get; set; }
        public Guid? Vehicle_ID { get; set; }
        public Guid? Driver_ID { get; set; }

    }
		
		 
	}
 
 
