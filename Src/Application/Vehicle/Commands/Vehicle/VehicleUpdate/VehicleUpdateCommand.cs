using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.Vehicle.VehicleUpdate.VehicleUpdateCommand
{

    ///   @author  Shimels Alem VehicleUpdate stored procedure.

    public class VehicleUpdateCommand : IRequest<IList<Vehicle_Vehicle_ID>>
    {
        public Guid Vehicle_ID { get; set; }
        public Int64? Organization_ID { get; set; }
        public string Plate_No { get; set; }
        public int Horse_Power { get; set; }
        public string CO2 { get; set; }
        public string Maker { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public Int64? Mile_Stamp { get; set; }
        public string Version { get; set; }
        public string Chassis_Number { get; set; }
        public double Purchase_Value { get; set; }
        public string Fixed_AssetID { get; set; }
        public string Is_Active { get; set; }
        public Guid? document_detail_id { get; set; }

    }
		
		 
	}
 
 
