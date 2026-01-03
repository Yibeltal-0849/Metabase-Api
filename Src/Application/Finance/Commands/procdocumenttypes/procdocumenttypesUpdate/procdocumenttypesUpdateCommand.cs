using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using System.Collections.Generic;

namespace Application.Finance.Commands.procdocumenttypes.procdocumenttypesUpdate.procdocumenttypesUpdateCommand
{

	/// @author  Shimels Alem  proc_document_typesUpdate stored procedure.


	public class procdocumenttypesUpdateCommand : IRequest<IList<documenttypes_documenttypecode>>
   {
		public System.Guid document_type_code { get; set; }
		public string description { get; set; }
		public bool? is_synched { get; set; }
		public System.DateTime? date_synched { get; set; }
	}
		
		
		 
}

