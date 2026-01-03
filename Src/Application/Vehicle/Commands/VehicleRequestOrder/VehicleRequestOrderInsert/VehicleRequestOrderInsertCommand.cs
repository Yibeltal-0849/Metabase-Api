using AutoMapper;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequestOrder.VehicleRequestOrderInsert.VehicleRequestOrderInsertCommand
{

    ///   @author  Shimels Alem VehicleRequest_OrderInsert stored procedure.

    public class VehicleRequestOrderInsertCommand : IRequest<IList<VehicleRequestOrder_Vehicle_OrderID>>
    {
        public Guid? Vehicle_OrderID { get; set; }
        public Guid? Vehicle_RequestID { get; set; }
        public Guid? Employee_ID { get; set; }
        public DateTime? Order_Date { get; set; }
        public string PickUp_Location { get; set; }
        public bool? Is_Approved { get; set; }
        public string Destination { get; set; }
    }
		
		 
	}
 
 
