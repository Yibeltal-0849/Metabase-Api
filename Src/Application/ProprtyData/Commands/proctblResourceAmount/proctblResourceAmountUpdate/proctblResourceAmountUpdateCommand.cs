using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceAmount.proctblResourceAmountUpdate.proctblResourceAmountUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResourceAmountUpdate stored procedure.


	public class proctblResourceAmountUpdateCommand : IRequest<IList<tblResourceAmount_Resource_id>>
   {
		public long Resource_id { get; set; }
		public long ResourceVariable_id { get; set; }
		public System.DateTime Report_Period { get; set; }
		public string Month { get; set; }
		public string Year { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }
	}
		
		
		 
}

