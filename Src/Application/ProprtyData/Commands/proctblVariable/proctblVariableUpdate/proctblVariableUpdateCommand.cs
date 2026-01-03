using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblVariable.proctblVariableUpdate.proctblVariableUpdateCommand
{

	/// @author  Shimels Alem  proc_tblVariableUpdate stored procedure.


	public class proctblVariableUpdateCommand : IRequest<IList<tblVariable_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Definition { get; set; }
		public bool? IsNumber { get; set; }
		public string Unit { get; set; }
	}
		
		
		 
}

