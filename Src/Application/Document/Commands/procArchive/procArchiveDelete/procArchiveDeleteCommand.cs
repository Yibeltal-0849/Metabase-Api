 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procArchive.procArchiveDelete.procArchiveDeleteCommand
{

    // @author  Shimels Alem  proc_ArchiveDelete stored procedure.


    public class procArchiveDeleteCommand : IRequest<IList<Archive_LetterID>>
    {
        public System.Guid Letter_ID { get; set; }
    }
		
     
		
		 
}
 
 