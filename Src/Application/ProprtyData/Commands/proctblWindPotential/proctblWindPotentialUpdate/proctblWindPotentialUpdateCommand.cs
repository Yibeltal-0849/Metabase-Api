using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblWindPotential.proctblWindPotentialUpdate.proctblWindPotentialUpdateCommand
{

	/// @author  Shimels Alem  proc_tblWindPotentialUpdate stored procedure.


	public class proctblWindPotentialUpdateCommand : IRequest<IList<tblWindPotential_id>>
   {
		public long id { get; set; }
		public long? Resource_Id { get; set; }
		public long? Unit { get; set; }
		public string AAWS { get; set; }
		public string AAWD { get; set; }
		public string Measurement_Height { get; set; }
	}
		
		
		 
}

