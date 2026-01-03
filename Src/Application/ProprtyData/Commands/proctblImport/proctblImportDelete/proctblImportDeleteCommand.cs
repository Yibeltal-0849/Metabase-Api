 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblImport.proctblImportDelete.proctblImportDeleteCommand
{

    // @author  Shimels Alem  proc_tblImportDelete stored procedure.


    public class proctblImportDeleteCommand : IRequest<IList<tblImport_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 