


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.PPurchasequote.PPurchasequoteInsert.PPurchasequoteInsertCommand
{

    /// @author  Shimels Alem  [P_Purchase quoteInsert] stored procedure.


    public class PPurchasequoteInsertCommand : IRequest<IList<PPurchaseQuote_Purchase_Line>>
    {
        public System.Guid Purchase_Line { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
		
		
		 
}
 
 