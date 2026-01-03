 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.J_Phys_Inventory_Journal.J_Phys_Inventory_JournalDelete.J_Phys_Inventory_JournalDeleteCommand
{

    // @author  Shimels Alem  c_CA_Beginning_BalanceDelete stored procedure.


    public class J_Phys_Inventory_JournalDeleteCommand : IRequest<IList<J_Phys_Inventory_Journal_Posting_Date>>
    {
        public System.DateTime Posting_Date { get; set; } 
        public string Document_No { get; set; }
        public string Item_No { get; set; }
   
    }
		
     
		
	 
}
 
 