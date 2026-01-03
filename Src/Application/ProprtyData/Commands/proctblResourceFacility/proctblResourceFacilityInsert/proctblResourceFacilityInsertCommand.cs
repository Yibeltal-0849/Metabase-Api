


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceFacility.proctblResourceFacilityInsert.proctblResourceFacilityInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_FacilityInsert stored procedure.


    public class proctblResourceFacilityInsertCommand : IRequest<IList<tblResourceFacility_id>>
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
 
 