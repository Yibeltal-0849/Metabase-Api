


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblGroup.proctblGroupInsert.proctblGroupInsertCommand
{

    /// @author  Shimels Alem  proc_tblGroupInsert stored procedure.


    public class proctblGroupInsertCommand : IRequest<IList<tblGroup_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
    }
		
		
		 
}
 
 