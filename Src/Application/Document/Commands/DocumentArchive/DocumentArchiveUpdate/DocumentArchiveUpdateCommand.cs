using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Commands.DocumentArchive.DocumentArchiveUpdate.DocumentArchiveUpdateCommand
{

	/// @author  Shimels Alem  Document_ArchiveUpdate stored procedure.


	public class DocumentArchiveUpdateCommand : IRequest<IList<DocumentArchive_Document_Number>>
	{
		public string Document_Number { get; set; }
		public string Title_Deed_No { get; set; }
		public DateTime? Regstration_Date { get; set; }
		public string Application_No { get; set; }
		public string Room { get; set; }
		public string Site { get; set; }
		public string Block_Floor { get; set; }
		public string Shelf_NO { get; set; }
		public string Shelf_Raw { get; set; }
		public string Shelf_Column { get; set; }
		public Guid? Created_By { get; set; }
		public Guid? Updated_By { get; set; }
		public Guid? Deleted_By { get; set; }
		public bool? Is_Deleted { get; set; }
		public DateTime? Created_Date { get; set; }
		public DateTime? Updated_Date { get; set; }
		public DateTime? Deleted_Date { get; set; }
	}
		
		
		 
	}

