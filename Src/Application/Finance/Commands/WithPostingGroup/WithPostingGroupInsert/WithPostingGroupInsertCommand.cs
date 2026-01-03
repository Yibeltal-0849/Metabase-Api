


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.WithPostingGroup.WithPostingGroupInsert.WithPostingGroupInsertCommand
{

    /// @author  Shimels Alem  With_Posting_GroupInsert stored procedure.


    public class WithPostingGroupInsertCommand : IRequest<IList<With_Posting_Group_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public Double Rate { get; set; }
    }
		
		
		 
}
 
 