using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFaclitiyDescription.proctblFaclitiyDescriptionUpdate.proctblFaclitiyDescriptionUpdateCommand
{

	/// @author  Shimels Alem  proc_tblFaclitiy_DescriptionUpdate stored procedure.


	public class proctblFaclitiyDescriptionUpdateCommand : IRequest<IList<tblFaclitiyDescription_id>>
   {
		public long id { get; set; }
		public long? Facility_id { get; set; }
		public long? Variable_id { get; set; }
		public string Value { get; set; }
	}
		
		
		 
}

