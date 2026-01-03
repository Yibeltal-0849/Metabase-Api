 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.MaintainanceAssignment.MaintainanceAssignmentDelete.MaintainanceAssignmentDeleteCommand
{

    // @author  Shimels Alem  Maintainance_AssignmentDelete stored procedure.


    public class MaintainanceAssignmentDeleteCommand : IRequest<IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        public long Ment_AssignmentID { get; set; }
    }
		
     
		
		 
	}
 
 