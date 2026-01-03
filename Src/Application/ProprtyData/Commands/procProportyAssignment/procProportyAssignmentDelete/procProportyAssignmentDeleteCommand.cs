 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.procProportyAssignment.procProportyAssignmentDelete.procProportyAssignmentDeleteCommand
{

    // @author  Shimels Alem  proc_Rent_CollectionDelete stored procedure.


    public class procProportyAssignmentDeleteCommand : IRequest<IList<Proporty_AssignmentID>>
    {
        public System.Guid Assig_Id { get; set; }
       

    }
		
     
		
		 
}
 
 