


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceAmount.proctblResourceAmountInsert.proctblResourceAmountInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceAmountInsert stored procedure.


    public class proctblResourceAmountInsertCommand : IRequest<IList<tblResourceAmount_Resource_id>>
    {
		public long Resource_id { get; set; }
		public long ResourceVariable_id { get; set; }
		public System.DateTime Report_Period { get; set; }
		public string Month { get; set; }
		public string Year { get; set; }
		public decimal Value { get; set; }
		public long Unit { get; set; }
	}
		
		
		 
}
 
 