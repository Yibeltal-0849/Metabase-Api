 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.DocumentType.DocumentTypeDelete.DocumentTypeDeleteCommand
{

    // @author  Shimels Alem  Document_TypeDelete stored procedure.


    public class DocumentTypeDeleteCommand : IRequest<IList<DocumentType_Name>>
    {
        public string Name { get; set; }
    }
		
     
		
		 
}
 
 