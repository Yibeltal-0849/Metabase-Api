 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblVariable.proctblVariableDelete.proctblVariableDeleteCommand
{

    // @author  Shimels Alem  proc_tblVariableDelete stored procedure.


    public class proctblVariableDeleteCommand : IRequest<IList<tblVariable_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 