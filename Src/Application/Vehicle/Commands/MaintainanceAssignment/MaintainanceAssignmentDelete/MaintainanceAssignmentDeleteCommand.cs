using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.MaintainanceAssignment.MaintainanceAssignmentDelete.MaintainanceAssignmentDeleteCommand
{

    ///  @author  Shimels Alem Maintainance_AssignmentDelete stored procedure.

    public class MaintainanceAssignmentDeleteCommand : IRequest<IList<MaintainanceAssignment_Ment_AssignmentID>>
    {
        public Int64 Ment_AssignmentID { get; set; }
    }
		
		 
	}
 
 
