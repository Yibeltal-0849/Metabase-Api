 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procMaintainanceAssignment.procMaintainanceAssignmentDelete.procMaintainanceAssignmentDeleteCommand
{

    // @author  Shimels Alem  proc_Maintainance_AssignmentDelete stored procedure.


    public class procMaintainanceAssignmentDeleteCommand : IRequest<IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        public long? Ment_AssignmentID { get; set; }
    }
		
     
		
		 
}
 
 