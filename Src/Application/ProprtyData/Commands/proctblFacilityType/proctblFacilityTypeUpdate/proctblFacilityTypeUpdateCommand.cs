using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblFacilityType.proctblFacilityTypeUpdate.proctblFacilityTypeUpdateCommand
{

	/// @author  Shimels Alem  proc_tblFacility_TypeUpdate stored procedure.


	public class proctblFacilityTypeUpdateCommand : IRequest<IList<tblFacility_Type_id>>
   {
		public long id { get; set; }
		public string Name { get; set; }
		public string Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}

