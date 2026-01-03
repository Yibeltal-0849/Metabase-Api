


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblStackHolder.proctblStackHolderInsert.proctblStackHolderInsertCommand
{

    /// @author  Shimels Alem  proc_tblStackHolderInsert stored procedure.


    public class proctblStackHolderInsertCommand : IRequest<IList<tblStackHolder_id>>
    {
		public long id { get; set; }
		public long Address_id { get; set; }
		public string Name { get; set; }
		public string WebSite { get; set; }
		public bool? IsLocal { get; set; }
		public string Capital { get; set; }
		public string Mistion { get; set; }
		public string Vistion { get; set; }
		public string Objective { get; set; }
		public long Involvement_id { get; set; }
	}
		
		
		 
}
 
 