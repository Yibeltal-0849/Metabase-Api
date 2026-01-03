


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Commands.TAXBusPostingGroup.TAXBusPostingGroupInsert.TAXBusPostingGroupInsertCommand
{

    /// @author  Shimels Alem  TAX_Bus_Posting_GroupInsert stored procedure.


    public class TAXBusPostingGroupInsertCommand : IRequest<IList<TAX_Bus_Posting_Group_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }
    }
		
		
		 
}
 
 