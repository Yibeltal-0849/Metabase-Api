 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.cVendorBalance.cVendorBalanceDelete.cVendorBalanceDeleteCommand
{

    // @author  Shimels Alem  c_Vendor_BalanceDelete stored procedure.


    public class cVendorBalanceDeleteCommand : IRequest<IList<CVendor_Vendor_ID>>
    {
        public long Id { get; set; }
    }
		
     
		
		 
}
 
 