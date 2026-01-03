


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GenBusPostingGroups.GenBusPostingGroupsInsert.GenBusPostingGroupsInsertCommand
{

    /// @author  Shimels Alem  Gen_Bus_Posting_GroupsInsert stored procedure.


    public class GenBusPostingGroupsInsertCommand : IRequest<IList<GenBusPostingGroups_Code>>
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Def_VATBusPostingGroup { get; set; }
    }
		
		
		 
}
 
 