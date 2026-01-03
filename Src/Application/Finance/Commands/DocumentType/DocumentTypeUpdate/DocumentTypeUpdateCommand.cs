using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.DocumentType.DocumentTypeUpdate.DocumentTypeUpdateCommand
{

	/// @author  Shimels Alem  Document_TypeUpdate stored procedure.


	public class DocumentTypeUpdateCommand : IRequest<IList<DocumentType_Name>>
   {
		public string Name { get; set; }
		public string Description { get; set; }
		public bool? Is_Active { get; set; }
	}
		
		
		 
}

