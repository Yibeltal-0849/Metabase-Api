using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.HRA;

namespace Application.HRA.Commands.procJobPositions.procJobPositionsUpdate.procJobPositionsUpdateCommand
{ 
	 
	/// @author  Shimels Alem  proc_Job_PositionsUpdate stored procedure.
	 
       public class procJobPositionsUpdateCommand : IRequest<IList<JobPositions_PosID>>
   {
        public Guid Pos_ID { get; set; }
		public string JobDescription { get; set; }
		public System.Guid? Department_code { get; set; }
        public string PositionName { get; set; }
        //public string Grade { get; set; }
        //public string? Leave_type { get; set; }
        public bool? IS_Attendance_Controlled { get; set; }
		public string Parent { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
		 
}

