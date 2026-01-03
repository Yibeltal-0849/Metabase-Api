using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequestOrder.VehicleRequestOrderDelete.VehicleRequestOrderDeleteCommand
{

    ///   @author  Shimels Alem VehicleRequest_OrderDelete stored procedure.

    public class VehicleRequestOrderDeleteCommand : IRequest<IList<VehicleRequestOrder_Vehicle_OrderID>>
    {
        public Guid Vehicle_OrderID { get; set; }
    }
		
		 
	}
 
 
