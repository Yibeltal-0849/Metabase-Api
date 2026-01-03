using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblConsumer.proctblConsumerUpdate.proctblConsumerUpdateCommand
{

	/// @author  Shimels Alem  proc_tblConsumerUpdate stored procedure.


	public class proctblConsumerUpdateCommand : IRequest<IList<tblConsumer_id>>
   {
		public long id { get; set; }
		public long? Chain_id { get; set; }
		public long? Energy_Id { get; set; }
		public long? Woreda_id { get; set; }
		public long? End_Use_id { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}

