using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.FixedAsset;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Commands.MaintainanceAssignment.MaintainanceAssignmentUpdate.MaintainanceAssignmentUpdateCommand
{

    ///   @author  Shimels Alem Maintainance_AssignmentUpdate stored procedure.

    public class MaintainanceAssignmentUpdateCommand : IRequest<IList<MaintainanceAssignment_Ment_AssignmentID>>
    {

        public Int64 Ment_AssignmentID { get; set; }
        public string Maintainance_ID { get; set; }
        public string Assigned_To { get; set; }
        public DateTime? Start_Date { get; set; }
        public DateTime? End_Date { get; set; }
        public string Status { get; set; }
    }
		
		 
	}
 
 
