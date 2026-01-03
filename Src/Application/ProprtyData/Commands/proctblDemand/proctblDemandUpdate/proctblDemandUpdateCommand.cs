using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDemand.proctblDemandUpdate.proctblDemandUpdateCommand
{

	/// @author  Shimels Alem  proc_tblDemandUpdate stored procedure.


	public class proctblDemandUpdateCommand : IRequest<IList<tblDemand_id>>
   {
		public long id { get; set; }
		public long? End_Use_id { get; set; }
		public long? Varable_id { get; set; }
		public string Year { get; set; }
		public long? Unit { get; set; }
		public decimal? Value { get; set; }
		public string Source { get; set; }
		public bool? Enable { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}

