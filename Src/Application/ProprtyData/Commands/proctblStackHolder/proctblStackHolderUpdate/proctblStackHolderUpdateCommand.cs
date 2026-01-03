using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblStackHolder.proctblStackHolderUpdate.proctblStackHolderUpdateCommand
{

	/// @author  Shimels Alem  proc_tblStackHolderUpdate stored procedure.


	public class proctblStackHolderUpdateCommand : IRequest<IList<tblStackHolder_id>>
   {
		public long id { get; set; }
		public long Address_id { get; set; }
		public string Name { get; set; }
		public string WebSite { get; set; }
		public bool? IsLocal { get; set; }
		public string Capital { get; set; }
		public string Mistion { get; set; }
		public string Vistion { get; set; }
		public string Objective { get; set; }
		public long Involvement_id { get; set; }
	}
		
		
		 
}

