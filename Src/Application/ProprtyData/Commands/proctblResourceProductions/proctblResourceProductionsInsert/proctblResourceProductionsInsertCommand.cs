


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceProductions.proctblResourceProductionsInsert.proctblResourceProductionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceProductionsInsert stored procedure.


    public class proctblResourceProductionsInsertCommand : IRequest<IList<tblResourceProductions_id>>
    {
		public long id { get; set; }
		public string Name { get; set; }
		public string Production_Period { get; set; }
		public string Value { get; set; }
		public string Unit { get; set; }
		public string Resource_id { get; set; }
		public string ResourceVariable_id { get; set; }
	}
		
		
		 
}
 
 