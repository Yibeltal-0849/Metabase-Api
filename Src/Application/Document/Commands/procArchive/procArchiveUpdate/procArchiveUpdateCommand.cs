using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.procArchive.procArchiveUpdate.procArchiveUpdateCommand
{

	/// @author  Shimels Alem  proc_ArchiveUpdate stored procedure.


	public class procArchiveUpdateCommand : IRequest<IList<Archive_LetterID>>
	{
		public string FolderNO { get; set; }
		public string Name { get; set; }
		public string Archive_Type { get; set; }
		public string Shelf_Raw { get; set; }
		public string Shelf_Column { get; set; }
		public System.Guid Letter_ID { get; set; }
	}
		
		
		 
}

