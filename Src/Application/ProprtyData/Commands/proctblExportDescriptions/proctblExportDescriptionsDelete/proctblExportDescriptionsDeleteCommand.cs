 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblExportDescriptions.proctblExportDescriptionsDelete.proctblExportDescriptionsDeleteCommand
{

    // @author  Shimels Alem  proc_tblExport_DescriptionsDelete stored procedure.


    public class proctblExportDescriptionsDeleteCommand : IRequest<IList<tblExportDescriptions_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 