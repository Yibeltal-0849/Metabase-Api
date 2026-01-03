using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.ActiveVehicle.ActiveVehicleDelete.ActiveVehicleDeleteCommand
{

    /// @author  Shimels Alem Active_VehicleDelete stored procedure.

    public class ActiveVehicleDeleteCommand : IRequest<IList<ActiveVehicle_ActiveVehicle_ID>>
    {
        public Guid ActiveVehicle_ID { get; set; }
    }
		
		 
	}
 
 
