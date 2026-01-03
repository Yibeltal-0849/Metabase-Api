using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyAndPostion.procProportyAndPostionUpdate.procProportyAndPostionUpdateCommand
{

	/// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


	public class procProportyAndPostionUpdateCommand : IRequest<IList<Proporty_And_PostionID>>
	{
		public System.Guid Id { get; set; }
		public Nullable<System.Guid> Position_ID { get; set; }
		public string Property_ID { get; set; }
		public Nullable<int> Priority { get; set; }
		public bool IsActive { get; set; }

	}
		
		
		 
}

