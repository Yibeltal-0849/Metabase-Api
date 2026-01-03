


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GenProductPostingGroup.GenProductPostingGroupInsert.GenProductPostingGroupInsertCommand
{

    /// @author  Shimels Alem  Gen_Product_Posting_GroupInsert stored procedure.


    public class GenProductPostingGroupInsertCommand : IRequest<IList<GenProductPostingGroup_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Def_VAT_Prod_Posting_Group { get; set; }
    }
		
		
		 
}
 
 