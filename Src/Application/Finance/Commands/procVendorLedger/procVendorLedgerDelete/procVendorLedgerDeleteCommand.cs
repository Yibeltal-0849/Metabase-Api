 


using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using XOKA.Domain.Entities.Vehicle;

namespace Application.Finance.Commands.procVendorLedger.procVendorLedgerDelete.procVendorLedgerDeleteCommand
{

    // @author  Shimels Alem  proc_Vendor_LedgerDelete stored procedure.


    public class procVendorLedgerDeleteCommand : IRequest<IList<VendorLedger_Entry_No>>
    {
        public System.Int64 Entry_No { get; set; }
    }
		
     
		
		 
}
 
 