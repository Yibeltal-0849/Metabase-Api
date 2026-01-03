


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cTAXPostingSetup.cTAXPostingSetupInsert.cTAXPostingSetupInsertCommand
{

    /// @author  Shimels Alem  c_TAX_Posting_SetupInsert stored procedure.


    public class cTAXPostingSetupInsertCommand : IRequest<IList<CTaxPostingSetup_TAX_BusPosting_Group>>
    {
        public string TAX_BusPosting_Group { get; set; }
        public string TAX_Prod_Psting_Group { get; set; }
        public string TAX_Per { get; set; }
        public string Sales_TAX_GL_Account { get; set; }
        public string Purchase_TAX_Account { get; set; }
        public string Reverse_Chrg_TAX_Account { get; set; }
        public bool? ISActive { get; set; }
    }
		
		
		 
}
 
 