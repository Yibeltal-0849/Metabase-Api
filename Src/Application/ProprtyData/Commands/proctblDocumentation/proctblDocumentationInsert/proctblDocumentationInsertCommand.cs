


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDocumentation.proctblDocumentationInsert.proctblDocumentationInsertCommand
{

    /// @author  Shimels Alem  proc_tblDocumentationInsert stored procedure.


    public class proctblDocumentationInsertCommand : IRequest<IList<tblDocumentation_id>>
    {
		public long? id { get; set; }
		public long? Region { get; set; }
		public string Contact_Person { get; set; }
		public string Contact_Phone { get; set; }
		public long? Type { get; set; }
		public System.Guid? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[]? Last_Modified { get; set; }
		public bool? Enable { get; set; }
		public string Data_Owner { get; set; }
		public bool? Regional_Approve { get; set; }
		public bool? Federal_Approve { get; set; }
	}
		
		
		 
	}
 
 