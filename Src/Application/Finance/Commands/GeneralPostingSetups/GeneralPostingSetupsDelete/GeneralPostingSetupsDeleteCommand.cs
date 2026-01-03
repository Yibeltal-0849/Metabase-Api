 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.GeneralPostingSetups.GeneralPostingSetupsDelete.GeneralPostingSetupsDeleteCommand
{

    // @author  Shimels Alem  General_Posting_SetupsDelete stored procedure.


    public class GeneralPostingSetupsDeleteCommand : IRequest<IList<GeneralPostingSetups2_Gen_Bus_Posting_Group>>
    {
        public string Gen_Bus_Posting_Group { get; set; }
        public string Gen_Pord_Posting_Group { get; set; }
    }
		
     
		
		 
}
 
 