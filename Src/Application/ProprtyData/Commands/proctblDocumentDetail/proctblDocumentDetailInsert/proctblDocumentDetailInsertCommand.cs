


using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDocumentDetail.proctblDocumentDetailInsert.proctblDocumentDetailInsertCommand
{

	/// @author  Shimels Alem  proc_tblDocument_DetailInsert stored procedure.


	public class proctblDocumentDetailInsertCommand : IRequest<IList<tblDocumentDetail_id>>
    {
		public long? id { get; set; }
		public long Document_id { get; set; }
		public string Author { get; set; }
		public string Title { get; set; }
		public string Publisher { get; set; }
		public System.DateTime? Publicationed_Date { get; set; }
		public string Volume { get; set; }
		public int? Number { get; set; }
		public int? Pages { get; set; }
		public string TypeCategory { get; set; }
		public string ISBN { get; set; }
		public string Abstract { get; set; }
		public string URL { get; set; }
	}
		
		
		 
}
 
 