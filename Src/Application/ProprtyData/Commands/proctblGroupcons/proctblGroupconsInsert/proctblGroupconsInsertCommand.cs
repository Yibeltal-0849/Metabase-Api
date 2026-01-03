


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblGroupcons.proctblGroupconsInsert.proctblGroupconsInsertCommand
{

    /// @author  Shimels Alem  proc_tblGroup_consInsert stored procedure.


    public class proctblGroupconsInsertCommand : IRequest<IList<tblGroupcons_id>>
    {
        public long? id { get; set; }
        public long? SubSector_id { get; set; }
        public string Name { get; set; }
    }
		
		
		 
}
 
 