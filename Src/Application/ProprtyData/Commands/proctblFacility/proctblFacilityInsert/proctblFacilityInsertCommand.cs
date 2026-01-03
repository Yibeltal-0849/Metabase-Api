


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFacility.proctblFacilityInsert.proctblFacilityInsertCommand
{

    /// @author  Shimels Alem  proc_tblFacilityInsert stored procedure.


    public class proctblFacilityInsertCommand : IRequest<IList<tblFacility_id>>
    {
		public long? id { get; set; }
		public long? Facility_Type_Id { get; set; }
		public string Name { get; set; }
		public long? Energychain_id { get; set; }
		public long? Owner_id { get; set; }
		public long? Energy_id { get; set; }
		public long? Region { get; set; }
		public long? Zone { get; set; }
		public long? Wereda { get; set; }
		public string Start_Date { get; set; }
		public string End_Date { get; set; }
		public string UTMN { get; set; }
		public string UTME { get; set; }
		public long? Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public long? Update_by { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}
 
 