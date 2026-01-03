 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDocumentation.proctblDocumentationDelete.proctblDocumentationDeleteCommand
{

    // @author  Shimels Alem  proc_tblDocumentationDelete stored procedure.


    public class proctblDocumentationDeleteCommand : IRequest<IList<tblDocumentation_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 