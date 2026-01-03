using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceProductions.proctblResourceProductionsUpdate.proctblResourceProductionsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResourceProductionsUpdate stored procedure.


	public class proctblResourceProductionsUpdateCommand : IRequest<IList<tblResourceProductions_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Production_Period { get; set; }
		public string Value { get; set; }
		public string Unit { get; set; }
		public string Resource_id { get; set; }
		public string ResourceVariable_id { get; set; }
	}
		
		
		 
}

