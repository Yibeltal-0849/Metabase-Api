using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblExport.proctblExportUpdate.proctblExportUpdateCommand
{

	/// @author  Shimels Alem  proc_tblExportUpdate stored procedure.


	public class proctblExportUpdateCommand : IRequest<IList<tblExport_id>>
   {
		public long id { get; set; }
		public long Company_id { get; set; }
		public long? Energy_Chain_id { get; set; }
		public long? Energy_id { get; set; }
		public long Buyer_id { get; set; }
		public System.DateTime Export_Period { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }
	}
		
		
		 
}

