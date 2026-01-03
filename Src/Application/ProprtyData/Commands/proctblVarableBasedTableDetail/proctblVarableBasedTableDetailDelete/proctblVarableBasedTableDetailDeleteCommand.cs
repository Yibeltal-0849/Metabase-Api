 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVarableBasedTableDetail.proctblVarableBasedTableDetailDelete.proctblVarableBasedTableDetailDeleteCommand
{

    // @author  Shimels Alem  proc_tblVarableBasedTable_DetailDelete stored procedure.


    public class proctblVarableBasedTableDetailDeleteCommand : IRequest<IList<tblVarableBasedTableDetail_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 