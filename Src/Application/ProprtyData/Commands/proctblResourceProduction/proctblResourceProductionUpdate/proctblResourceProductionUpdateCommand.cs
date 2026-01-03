using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceProduction.proctblResourceProductionUpdate.proctblResourceProductionUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResourceProductionUpdate stored procedure.


	public class proctblResourceProductionUpdateCommand : IRequest<IList<tblResourceProduction_Facility_id>>
   {
		public long Facility_id { get; set; }
		public long Variable_id { get; set; }
		public System.DateTime Production_Period { get; set; }
		public string Month { get; set; }
		public string Year { get; set; }
		public long Unit { get; set; }
		public long Value { get; set; }
	}
		
		
		 
}

