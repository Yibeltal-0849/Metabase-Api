 


using MediatR;
using System;
using XOKA.Domain.Entities.Finance;
using System.Collections.Generic;

namespace Application.Finance.Commands.procdocumenttypes.procdocumenttypesDelete.procdocumenttypesDeleteCommand
{

    // @author  Shimels Alem  proc_document_typesDelete stored procedure.


    public class procdocumenttypesDeleteCommand : IRequest<IList<documenttypes_documenttypecode>>
    {
        public System.Guid document_type_code { get; set; }
    }
		
     
		
		 
}
 
 