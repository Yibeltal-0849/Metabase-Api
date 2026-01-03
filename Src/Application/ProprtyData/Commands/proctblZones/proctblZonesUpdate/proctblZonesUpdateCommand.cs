using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblZones.proctblZonesUpdate.proctblZonesUpdateCommand
{

	/// @author  Shimels Alem  proc_tblZonesUpdate stored procedure.


	public class proctblZonesUpdateCommand : IRequest<IList<tblZones_id>>
   {
		public int id { get; set; }
		public string description { get; set; }
		public long? regions_id { get; set; }
	}
		
		
		 
}

