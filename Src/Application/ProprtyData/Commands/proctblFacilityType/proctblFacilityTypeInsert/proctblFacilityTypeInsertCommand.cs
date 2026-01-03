


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblFacilityType.proctblFacilityTypeInsert.proctblFacilityTypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblFacility_TypeInsert stored procedure.


    public class proctblFacilityTypeInsertCommand : IRequest<IList<tblFacility_Type_id>>
    {
		public long? id { get; set; }
		public string Name { get; set; }
		public string Enable { get; set; }
		public System.DateTime? Created_Date { get; set; }
		public long? Created_By { get; set; }
		public System.DateTime? Update_Date { get; set; }
		public byte[] Last_Modified { get; set; }
	}
		
		
		 
}
 
 