


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceProduction.proctblResourceProductionInsert.proctblResourceProductionInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceProductionInsert stored procedure.


    public class proctblResourceProductionInsertCommand : IRequest<IList<tblResourceProduction_Facility_id>>
    {
		public long Facility_id { get; set; }
		public long Variable_id { get; set; }
		public System.DateTime Production_Period { get; set; }
		public string Month { get; set; }
		public string Year { get; set; }
		public long Unit { get; set; }
		public long Value { get; set; }
	}
		
		
		 
}
 
 