


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblState.proctblStateInsert.proctblStateInsertCommand
{

    /// @author  Shimels Alem  proc_tblStateInsert stored procedure.


    public class proctblStateInsertCommand : IRequest<IList<tblState_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
    }
		
		
		 
}
 
 