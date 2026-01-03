 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetEntrust.FixedAssetEntrustDelete.FixedAssetEntrustDeleteCommand
{

    // @author  Shimels Alem  Fixed_Asset_EntrustDelete stored procedure.


    public class FixedAssetEntrustDeleteCommand : IRequest<IList<FixedAssetEntrust_Entrust_ID>>
    {
        public System.Guid Entrust_ID { get; set; }
    }
		
     
		
		 
	}
 
 