using AutoMapper;
using MediatR;
using System.Collections.Generic;
using XOKA.Domain.Entities.Budget;

namespace Application.Document.Commands.procArchiveType.procArchiveTypeUpdate.procArchiveTypeUpdateCommand
{

	/// @author  Shimels Alem  proc_Archive_TypeUpdate stored procedure.

	public class procArchiveTypeUpdateCommand : IRequest<IList<Archive_Type_Name_Type>>
   {
		public string Name_Type { get; set; }
		public string Description { get; set; }
		public string Room { get; set; }
		public System.Guid? Site { get; set; }
		public string Block_Floor { get; set; }
		public string Shelf_NO { get; set; }
	}
		
		
		 
}

