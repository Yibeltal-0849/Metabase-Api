 


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;
using System;

namespace Application.Vehicle.Commands.procFleetSchdule.procFleetSchduleDelete.procFleetSchduleDeleteCommand
{

    // @author  Shimels Alem  proc_Fleet_SchduleDelete stored procedure.


    public class procFleetSchduleDeleteCommand : IRequest<IList<FleetSchdule_Fleet_SchduleID>>
    {

        public System.Guid Fleet_SchduleID { get; set; }
    }
		
     
		
		 
}
 
 