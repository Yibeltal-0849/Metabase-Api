 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procSendTO.procSendTODelete.procSendTODeleteCommand
{

    // @author  Shimels Alem  proc_Send_TODelete stored procedure.


    public class procSendTODeleteCommand : IRequest<IList<SendTO_EmailID>>
    {
        public System.Guid Email_ID { get; set; }
    }
		
     
		
		 
}
 
 