 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDocumentType.proctblDocumentTypeDelete.proctblDocumentTypeDeleteCommand
{

    // @author  Shimels Alem  proc_tblDocument_TypeDelete stored procedure.


    public class proctblDocumentTypeDeleteCommand : IRequest<IList<tblDocumentType_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 