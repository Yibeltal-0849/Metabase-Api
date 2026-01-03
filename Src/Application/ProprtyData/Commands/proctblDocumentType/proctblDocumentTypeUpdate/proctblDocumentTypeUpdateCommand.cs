using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblDocumentType.proctblDocumentTypeUpdate.proctblDocumentTypeUpdateCommand
{

	/// @author  Shimels Alem  proc_tblDocument_TypeUpdate stored procedure.


	public class proctblDocumentTypeUpdateCommand : IRequest<IList<tblDocumentType_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
	}
		
		
		 
}

