


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVariable.proctblVariableInsert.proctblVariableInsertCommand
{

    /// @author  Shimels Alem  proc_tblVariableInsert stored procedure.


    public class proctblVariableInsertCommand : IRequest<IList<tblVariable_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
        public string Definition { get; set; }
        public bool? IsNumber { get; set; }
        public string Unit { get; set; }
    }
		
		
		 
}
 
 