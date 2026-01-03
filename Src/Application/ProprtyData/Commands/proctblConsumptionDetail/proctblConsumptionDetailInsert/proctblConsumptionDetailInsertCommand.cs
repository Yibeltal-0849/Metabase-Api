


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumptionDetail.proctblConsumptionDetailInsert.proctblConsumptionDetailInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumption_DetailInsert stored procedure.


    public class proctblConsumptionDetailInsertCommand : IRequest<IList<tblConsumptionDetail_id>>
    {
		public long? id { get; set; }
		public long Consumption_id { get; set; }
		public long SubSector_Id { get; set; }
		public long Unit_Id { get; set; }
		public string Sector_Number { get; set; }
		public decimal? Collected_Birr { get; set; }
		public decimal? Used_Amount { get; set; }
	}
		
		
		 
}
 
 