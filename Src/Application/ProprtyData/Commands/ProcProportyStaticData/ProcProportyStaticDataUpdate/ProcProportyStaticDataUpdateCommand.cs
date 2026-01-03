using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.ProcProportyStaticData.ProcProportyStaticDataUpdate.ProcProportyStaticDataUpdateCommand
{

	/// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


	public class ProcProportyStaticDataUpdateCommand : IRequest<IList<Proporty_Static_DataID>>
	{
		public System.Guid ID { get; set; }
		public string Property_ID { get; set; }
		public string Static_form_Data { get; set; }
		public Nullable<System.DateTime> Collection_Date { get; set; }
		public Nullable<bool> Is_Active { get; set; }

	}
		
		
		 
}

