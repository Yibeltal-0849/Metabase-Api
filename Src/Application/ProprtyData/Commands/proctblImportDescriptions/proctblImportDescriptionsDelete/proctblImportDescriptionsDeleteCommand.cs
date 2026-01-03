 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblImportDescriptions.proctblImportDescriptionsDelete.proctblImportDescriptionsDeleteCommand
{

    // @author  Shimels Alem  proc_tblImport_DescriptionsDelete stored procedure.


    public class proctblImportDescriptionsDeleteCommand : IRequest<IList<tblImportDescriptions_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 