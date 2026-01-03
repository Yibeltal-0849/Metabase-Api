 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceAmount.proctblResourceAmountDelete.proctblResourceAmountDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceAmountDelete stored procedure.


    public class proctblResourceAmountDeleteCommand : IRequest<IList<tblResourceAmount_Resource_id>>
    {
        public long Resource_id { get; set; }
        public long ResourceVariable_id { get; set; }
        public System.DateTime Report_Period { get; set; }
    }
		
     
		
		 
}
 
 