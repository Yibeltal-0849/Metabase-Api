


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procArchive.procArchiveInsert.procArchiveInsertCommand
{

	/// @author  Shimels Alem  proc_ArchiveInsert stored procedure.


	public class procArchiveInsertCommand : IRequest<IList<Archive_LetterID>>
    {
		public string FolderNO { get; set; }
		public string Name { get; set; }
		public string Archive_Type { get; set; }
		public string Shelf_Raw { get; set; }
		public string Shelf_Column { get; set; }
		public System.Guid Letter_ID { get; set; }

	}
		
		
		 
}
 
 