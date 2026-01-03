 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cTAXPostingSetup.cTAXPostingSetupDelete.cTAXPostingSetupDeleteCommand
{

    // @author  Shimels Alem  c_TAX_Posting_SetupDelete stored procedure.


    public class cTAXPostingSetupDeleteCommand : IRequest<IList<CTaxPostingSetup_TAX_BusPosting_Group>>
    {
        public string TAX_BusPosting_Group { get; set; }
        public string TAX_Prod_Psting_Group { get; set; }
    }
		
     
		
		 
}
 
 