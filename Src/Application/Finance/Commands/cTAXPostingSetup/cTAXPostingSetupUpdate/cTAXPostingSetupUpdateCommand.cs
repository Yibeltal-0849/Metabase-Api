using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cTAXPostingSetup.cTAXPostingSetupUpdate.cTAXPostingSetupUpdateCommand
{

	/// @author  Shimels Alem  c_TAX_Posting_SetupUpdate stored procedure.


	public class cTAXPostingSetupUpdateCommand : IRequest<IList<CTaxPostingSetup_TAX_BusPosting_Group>>
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

