 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;

namespace Application.BSC.Commands.procBSCValues.procBSCValuesDelete.procBSCValuesDeleteCommand
{

    // @author  Shimels Alem  proc_BSC_ValuesDelete stored procedure.


    public class procBSCValuesDeleteCommand : IRequest<IList<BSCValues_BSCValueID>>
    {
        public System.Guid BSC_Value_ID { get; set; }
    }
		
     
		
		 
}
 
 