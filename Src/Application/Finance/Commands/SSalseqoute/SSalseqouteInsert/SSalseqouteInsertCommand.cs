


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.SSalseqoute.SSalseqouteInsert.SSalseqouteInsertCommand
{

    /// @author  Shimels Alem  S_Salse_qouteInsert stored procedure.


    public class SSalseqouteInsertCommand : IRequest<IList<SSalseQoute_Sales_Qoute_Line_ID>>
    {
        public string Sales_Qoute_Line_ID { get; set; }
        public int? Qty_to_Assign { get; set; }
        public int? Qty_Assigned { get; set; }
    }
		
		
		 
}
 
 