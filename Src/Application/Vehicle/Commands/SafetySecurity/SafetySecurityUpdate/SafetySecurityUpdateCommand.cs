using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.SafetySecurity.SafetySecurityUpdate.SafetySecurityUpdateCommand
{

    ///   @author  Shimels Alem Safety_SecurityUpdate stored procedure.

    public class SafetySecurityUpdateCommand : IRequest<IList<SafetySecurity_Safety_SecurityID>>
    {
        public Guid Safety_SecurityID { get; set; }
        public Guid? Vehicle_DispatchID { get; set; }
        public string Location { get; set; }
        public string Reported_By { get; set; }
        public string Location_X { get; set; }
        public string Location_Y { get; set; }
    }
		
		 
	}
 
 
