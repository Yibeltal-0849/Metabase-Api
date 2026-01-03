using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumed.proctblConsumedUpdate.proctblConsumedUpdateCommand
{

	/// @author  Shimels Alem  proc_tblConsumedUpdate stored procedure.


	public class proctblConsumedUpdateCommand : IRequest<IList<tblConsumed_id>>
   {
		public long id { get; set; }
		public long? Consumer_id { get; set; }
		public long? Energy_Id { get; set; }
		public long? Varable_id { get; set; }
		public string Year { get; set; }
		public long? Unit { get; set; }
		public decimal? Value { get; set; }
		public string Source { get; set; }
	}
		
		
		 
}

