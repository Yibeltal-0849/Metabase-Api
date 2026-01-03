 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblAddresses.proctblAddressesDelete.proctblAddressesDeleteCommand
{

    // @author  Shimels Alem  proc_tblAddressesDelete stored procedure.


    public class proctblAddressesDeleteCommand : IRequest<IList<tblAddresses_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 