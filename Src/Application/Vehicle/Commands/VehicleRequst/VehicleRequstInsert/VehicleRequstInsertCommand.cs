using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.VehicleRequst.VehicleRequstInsert.VehicleRequstInsertCommand
{

    ///   @author  Shimels Alem proc_Vehicle_RequstInsert stored procedure.

    public class VehicleRequstInsertCommand : IRequest<IList<VehicleRequst_Vehicle_RequestID>>
    {
        public Guid? Vehicle_RequestID { get; set; }
        public string Requested_By { get; set; }
        public DateTime? Request_Date { get; set; }
        public DateTime? RequsetFor_Date { get; set; }
        public Guid? Application_code { get; set; }
        public string Application_No { get; set; }
    }
		
		 
	}
 
 
