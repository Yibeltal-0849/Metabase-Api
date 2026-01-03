 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.WHTPostingSetup.WHTPostingSetupDelete.WHTPostingSetupDeleteCommand
{

    // @author  Shimels Alem  WHT_Posting_SetupDelete stored procedure.


    public class WHTPostingSetupDeleteCommand : IRequest<IList<WHT_Posting_Setup_With_Posting_Group>>
    {
        public string With_Posting_Group { get; set; }
        public string Bus_Posting_Group { get; set; }
        public string Prod_Posting_Group { get; set; }
    }
		
     
		
		 
}
 
 