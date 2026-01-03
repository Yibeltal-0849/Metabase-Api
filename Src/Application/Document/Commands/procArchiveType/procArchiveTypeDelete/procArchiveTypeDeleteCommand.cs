 


using MediatR;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Budget;

namespace Application.Document.Commands.procArchiveType.procArchiveTypeDelete.procArchiveTypeDeleteCommand
{

    // @author  Shimels Alem  proc_Archive_TypeDelete stored procedure.

    public class procArchiveTypeDeleteCommand : IRequest<IList<Archive_Type_Name_Type>>
    {
        public string Name_Type { get; set; }
    }
		
     
		
		 
}
 
 