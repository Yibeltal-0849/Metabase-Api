using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGeneralPostingSetupsDelete.procGeneralPostingSetupsDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_General Posting SetupsDelete stored procedure.
	 
	#region proc_General Posting SetupsDelete  
     
  /// proc_General Posting SetupsDelete stored procedure.
     
        public class procGeneralPostingSetupsDeleteCommand : IRequest<IList<procGeneralPostingSetups_gen_Bus_Posting_Group>>
    {
    
		public string gen_Bus_Posting_Group { get; set; }
		public string gen_Pord_Posting_Group { get; set; }
    }
		
        #endregion
		
		 
	}
 
 
