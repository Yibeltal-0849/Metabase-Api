using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblState.proctblStateUpdate.proctblStateUpdateCommand
{

	/// @author  Shimels Alem  proc_tblStateUpdate stored procedure.


	public class proctblStateUpdateCommand : IRequest<IList<tblState_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
	}
		
		
		 
}

