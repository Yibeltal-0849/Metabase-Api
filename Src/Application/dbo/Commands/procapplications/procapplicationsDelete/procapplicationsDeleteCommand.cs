 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procapplications.procapplicationsDelete.procapplicationsDeleteCommand
{

    // @author  Shimels Alem  proc_applicationsDelete stored procedure.

    public class procapplicationsDeleteCommand : IRequest<IList<applications_applicationcode>>
    {
        public System.Guid application_code { get; set; }
    }
		
}
 
 