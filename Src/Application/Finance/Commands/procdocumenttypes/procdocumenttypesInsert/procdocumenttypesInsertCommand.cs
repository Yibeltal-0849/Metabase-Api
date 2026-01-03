


using MediatR;
using System;
using XOKA.Domain.Entities.Finance;
using System.Collections.Generic;

namespace Application.Finance.Commands.procdocumenttypes.procdocumenttypesInsert.procdocumenttypesInsertCommand
{

	/// @author  Shimels Alem  proc_document_typesInsert stored procedure.


	public class procdocumenttypesInsertCommand : IRequest<IList<documenttypes_documenttypecode>>
    {
		public System.Guid document_type_code { get; set; }
		public string description { get; set; }
		public bool? is_synched { get; set; }
		public System.DateTime? date_synched { get; set; }
	}
		
		
		 
}
 
 