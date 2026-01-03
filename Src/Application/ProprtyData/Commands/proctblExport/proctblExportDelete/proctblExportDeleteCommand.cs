 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblExport.proctblExportDelete.proctblExportDeleteCommand
{

    // @author  Shimels Alem  proc_tblExportDelete stored procedure.


    public class proctblExportDeleteCommand : IRequest<IList<tblExport_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 