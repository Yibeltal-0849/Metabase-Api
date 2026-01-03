


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceBuyers.proctblResourceBuyersInsert.proctblResourceBuyersInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceBuyersInsert stored procedure.


    public class proctblResourceBuyersInsertCommand : IRequest<IList<tblResourceBuyers_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string FRB_Ownership { get; set; }
    }
		
		
		 
}
 
 