using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.SafetySecurity.SafetySecurityDelete.SafetySecurityDeleteCommand
{

    ///   @author  Shimels Alem Safety_SecurityDelete stored procedure.

    public class SafetySecurityDeleteCommand : IRequest<IList<SafetySecurity_Safety_SecurityID>>
    {
        public Guid Safety_SecurityID { get; set; }
    }
		
		 
	}
 
 
