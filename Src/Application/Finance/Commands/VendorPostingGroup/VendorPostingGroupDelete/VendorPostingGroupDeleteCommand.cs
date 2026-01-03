 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Entities.Inventory;

namespace Application.Finance.Commands.VendorPostingGroup.VendorPostingGroupDelete.VendorPostingGroupDeleteCommand
{

    // @author  Shimels Alem  Vendor_Posting_GroupDelete stored procedure.


    public class VendorPostingGroupDeleteCommand : IRequest<IList<VendorPostingGroup_Code>>
    {
        public string Code { get; set; }
    }
		
     
		
		 
}
 
 