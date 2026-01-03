using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequst.VehicleRequstDelete.VehicleRequstDeleteCommand
{

    ///   @author  Shimels Alem proc_Vehicle_RequstDelete stored procedure.

    public class VehicleRequstDeleteCommand : IRequest<IList<VehicleRequst_Vehicle_RequestID>>
    {
        public Guid Vehicle_RequestID { get; set; }

    }
		
		 
	}
 
 
