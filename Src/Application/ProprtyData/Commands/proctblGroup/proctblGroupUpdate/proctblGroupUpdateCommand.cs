using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblGroup.proctblGroupUpdate.proctblGroupUpdateCommand
{

	/// @author  Shimels Alem  proc_tblGroupUpdate stored procedure.


	public class proctblGroupUpdateCommand : IRequest<IList<tblGroup_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
	}
		
		
		 
}

