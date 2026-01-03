using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceFacility.proctblResourceFacilityUpdate.proctblResourceFacilityUpdateCommand
{ 
	 
	/// @author  Shimels Alem  [sp not found] stored procedure.
	 
    
       public class proctblResourceFacilityUpdateCommand : IRequest<IList<tblResourceFacility_id>>
   {
		public long id { get; set; }
		public long? Resource_id { get; set; }
		public long? Facility_id { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
		public bool? Enable { get; set; }
	}
		
		
		 
}

