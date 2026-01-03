 


using MediatR;
using System;
using XOKA.Domain.Entities.Document;

namespace Application.Finance.Commands.procDocumentArchive.procDocumentArchiveDelete.procDocumentArchiveDeleteCommand
{

    // @author  Shimels Alem  proc_Document_ArchiveDelete stored procedure.


    public class procDocumentArchiveDeleteCommand : IRequest
    {
        public string Document_Number { get; set; }
    }
		
     
		
		 
}
 
 