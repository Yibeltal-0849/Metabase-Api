 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Budget;

namespace Application.Budget.Commands.DocumentArchive.DocumentArchiveDelete.DocumentArchiveDeleteCommand
{

    // @author  Shimels Alem  Document_ArchiveDelete stored procedure.


    public class DocumentArchiveDeleteCommand : IRequest<IList<Document_Archive_Document_Number>>
    {
        public string Document_Number { get; set; }
    }
		
     
		
		 
	}
 
 