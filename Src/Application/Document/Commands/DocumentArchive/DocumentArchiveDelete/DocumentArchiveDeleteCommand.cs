 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.DocumentArchive.DocumentArchiveDelete.DocumentArchiveDeleteCommand
{

    // @author  Shimels Alem  Document_ArchiveDelete stored procedure.


    public class DocumentArchiveDeleteCommand : IRequest<IList<DocumentArchive_Document_Number>>
    {
        public string Document_Number { get; set; }
    }
		
     
		
		 
	}
 
 