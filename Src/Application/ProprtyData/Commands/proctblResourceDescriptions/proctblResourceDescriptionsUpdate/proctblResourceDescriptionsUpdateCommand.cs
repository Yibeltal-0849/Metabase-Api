using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceDescriptions.proctblResourceDescriptionsUpdate.proctblResourceDescriptionsUpdateCommand
{

	/// @author  Shimels Alem  proc_tblResourceDescriptionsUpdate stored procedure.


	public class proctblResourceDescriptionsUpdateCommand : IRequest<IList<tblResourceDescriptions_id>>
   {
		public long id { get; set; }
		public long? Resource_id { get; set; }
		public long? ResourceVariable_id { get; set; }
		public string Value { get; set; }
	}
		
		
		 
}

