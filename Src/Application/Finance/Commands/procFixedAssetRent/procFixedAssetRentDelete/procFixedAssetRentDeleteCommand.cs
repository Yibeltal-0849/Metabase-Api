 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetRent.procFixedAssetRentDelete.procFixedAssetRentDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Asset_RentDelete stored procedure.


    public class procFixedAssetRentDeleteCommand : IRequest<IList<FixedAssetRent_Rent_ID>>
    {

        public long Rent_ID { get; set; }
    }
		
     
		
		 
}
 
 