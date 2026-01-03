 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Commands.procJobPositions.procJobPositionsDelete.procJobPositionsDeleteCommand
{
     
    // @author  Shimels Alem  proc_Job_PositionsDelete stored procedure.
     
    public class procJobPositionsDeleteCommand : IRequest<IList<JobPositions_PosID>>
    {
        public Guid Pos_ID { get; set; }
    }
		
     
		
		 
}
 
 