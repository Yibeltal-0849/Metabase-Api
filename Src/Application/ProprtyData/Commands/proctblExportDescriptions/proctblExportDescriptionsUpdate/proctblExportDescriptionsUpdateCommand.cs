using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblExportDescriptions.proctblExportDescriptionsUpdate.proctblExportDescriptionsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblExport_DescriptionsUpdate stored procedure.


	public class proctblExportDescriptionsUpdateCommand : IRequest<IList<tblExportDescriptions_id>>
   {
		public long id { get; set; }
		public long? Export_Id { get; set; }
		public long? Variable_id { get; set; }
		public string Value { get; set; }
	}
		
		
		 
}

