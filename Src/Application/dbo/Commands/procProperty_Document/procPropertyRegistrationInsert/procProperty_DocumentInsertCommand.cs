


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procProperty_Document.procProperty_DocumentInsert.procProperty_DocumentInsertCommand
{

	/// @author  Shimels Alem  proc_Property_RegistrationInsert stored procedure.


	public class procProperty_DocumentInsertCommand : IRequest<IList<Property_DocumentID>>
    {
        public System.Guid ID { get; set; }
        public string PROPERTY_ID { get; set; }
        public System.Guid? Updated_by { get; set; }
        public System.Guid? Deleted_by { get; set; }
        public string? Description { get; set; }
        public string? Documents { get; set; }

    }
		
		
		 
}
 
 