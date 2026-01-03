 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procPropertyRegistration.procPropertyRegistrationDelete.procPropertyRegistrationDeleteCommand
{

    // @author  Shimels Alem  proc_Property_RegistrationDelete stored procedure.


    public class procPropertyRegistrationDeleteCommand : IRequest<IList<PropertyRegistration_PropertyID>>
    {

        public string Property_ID { get; set; }
    }
		
     
		
		 
}
 
 