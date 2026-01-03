 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CVendor.CVendorDelete.CVendorDeleteCommand
{

    // @author  Shimels Alem  C_VendorDelete stored procedure.


    public class CVendorDeleteCommand : IRequest<IList<CVendor_Vendor_ID>>
    {
        public string Vendor_ID { get; set; }
    }
		
     
		
		 
}
 
 