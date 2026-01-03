using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyAssignment.procProportyAssignmentUpdate.procProportyAssignmentUpdateCommand
{

	/// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


	public class procProportyAssignmentUpdateCommand : IRequest<IList<Proporty_AssignmentID>>
	{
        public System.Guid Assig_Id { get; set; }
        public Nullable<System.Guid> Trans_ID { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Proporty_ID { get; set; }
        public Nullable<System.Guid> Rent_App_ID { get; set; }
        public Nullable<System.Guid> Manual_Rent_App_ID { get; set; }
        public string Remark_for_Manual_Assigment { get; set; }
        public Nullable<bool> Approved { get; set; }
        public System.Guid UserID { get; set; }

    }
		
		
		 
}

