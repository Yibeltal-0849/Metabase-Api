using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.procProportyTypeLockup.procProportyTypeLockupUpdate.procProportyTypeLockupUpdateCommand
{

	/// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


	public class procProportyTypeLockupUpdateCommand : IRequest<IList<Proporty_Type_LookUpID>>
	{
		public int Property_Type_ID { get; set; }
		public string Property_Type { get; set; }
		public int Interval_Month { get; set; }
		public string Static_Json_from { get; set; }
		public string Dinamic_Json_form { get; set; }
		public Nullable<bool> Is_Deleted { get; set; }

	}
		
		
		 
}

