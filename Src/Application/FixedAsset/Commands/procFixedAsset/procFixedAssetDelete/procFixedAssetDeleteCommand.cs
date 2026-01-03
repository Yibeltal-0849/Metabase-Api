 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.procFixedAsset.procFixedAssetDelete.procFixedAssetDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_AssetDelete stored procedure.


    public class procFixedAssetDeleteCommand : IRequest<IList<FixedAsset_FIXED_Asset_No>>
    {
        public string FIXED_Asset_No { get; set; }
    }
		
     
		
		 
}
 
 