using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleDispatch.VehicleDispatchDelete.VehicleDispatchDeleteCommand
{

    ///   @author  Shimels Alem Vehicle_DispatchDelete stored procedure.

    public class VehicleDispatchDeleteCommand : IRequest<IList<VehicleDispatch_Vehicle_DispatchID>>
    {
        public Guid Vehicle_DispatchID { get; set; }

    }
		
		 
	}
 
 
