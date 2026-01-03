using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleDispatch.VehicleDispatchInsert.VehicleDispatchInsertCommand
{

    ///   @author  Shimels Alem Vehicle_DispatchInsert stored procedure.

    public class VehicleDispatchInsertCommand : IRequest<IList<VehicleDispatch_Vehicle_DispatchID>>
    {
        public Guid? Vehicle_DispatchID { get; set; }
        public Guid? Vehicle_RequestID { get; set; }
        public Guid? Vehicle_OrderID { get; set; }
        public DateTime Dispatch_Date { get; set; }
        public string Status { get; set; }
        public Guid ActiveVehicle_ID { get; set; }
        public string Driver_Name { get; set; }
    }
		
		 
	}
 
 
