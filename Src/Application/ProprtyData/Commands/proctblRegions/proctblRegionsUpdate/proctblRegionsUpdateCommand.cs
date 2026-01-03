using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblRegions.proctblRegionsUpdate.proctblRegionsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblRegionsUpdate stored procedure.


	public class proctblRegionsUpdateCommand : IRequest<IList<tblRegions_id>>
   {
		public long id { get; set; }
		public string description { get; set; }
	}
		
		
		 
}

