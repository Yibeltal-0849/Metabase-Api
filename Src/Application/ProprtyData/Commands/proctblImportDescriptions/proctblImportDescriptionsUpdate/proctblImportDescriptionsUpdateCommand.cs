using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblImportDescriptions.proctblImportDescriptionsUpdate.proctblImportDescriptionsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblImport_DescriptionsUpdate stored procedure.


	public class proctblImportDescriptionsUpdateCommand : IRequest<IList<tblImportDescriptions_id>>
   {
		public long id { get; set; }
		public long? Import_Id { get; set; }
		public long? Variable_id { get; set; }
		public string Value { get; set; }
	}
		
		
		 
}

