using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblGroupcons.proctblGroupconsUpdate.proctblGroupconsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblGroup_consUpdate stored procedure.


	public class proctblGroupconsUpdateCommand : IRequest<IList<tblGroupcons_id>>
   {
		public long id { get; set; }
		public long? SubSector_id { get; set; }
		public string Name { get; set; }
	}
		
		
		 
}

