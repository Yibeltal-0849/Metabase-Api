 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procProperty_Document.procProperty_DocumentDelete.procProperty_DocumentDeleteCommand
{

    // @author  Shimels Alem  proc_Property_RegistrationDelete stored procedure.


    public class procProperty_DocumentDeleteCommand : IRequest<IList<Property_DocumentID>>
    {

        public System.Guid ID { get; set; }

    }




}
 
 