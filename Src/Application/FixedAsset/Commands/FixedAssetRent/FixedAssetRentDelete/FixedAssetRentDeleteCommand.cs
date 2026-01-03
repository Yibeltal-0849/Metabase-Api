 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetRent.FixedAssetRentDelete.FixedAssetRentDeleteCommand
{

    // @author  Shimels Alem  Fixed_Asset_RentDelete stored procedure.


    public class FixedAssetRentDeleteCommand : IRequest<IList<FixedAssetRent_Rent_ID>>
    {
        public long Rent_ID { get; set; }
    }
		
     
		
		 
	}
 
 