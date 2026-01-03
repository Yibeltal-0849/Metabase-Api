


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblConsumed.proctblConsumedInsert.proctblConsumedInsertCommand
{

    /// @author  Shimels Alem  proc_tblConsumedInsert stored procedure.


    public class proctblConsumedInsertCommand : IRequest<IList<tblConsumed_id>>
    {
		public long? id { get; set; }
		public long? Consumer_id { get; set; }
		public long? Energy_Id { get; set; }
		public long? Varable_id { get; set; }
		public string Year { get; set; }
		public long? Unit { get; set; }
		public decimal? Value { get; set; }
		public string Source { get; set; }
	}
		
		
		 
}
 
 