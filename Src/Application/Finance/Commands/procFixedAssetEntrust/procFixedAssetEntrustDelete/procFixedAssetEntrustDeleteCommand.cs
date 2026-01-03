 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetEntrust.procFixedAssetEntrustDelete.procFixedAssetEntrustDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Asset_EntrustDelete stored procedure.


    public class procFixedAssetEntrustDeleteCommand : IRequest<IList<FixedAssetEntrust_Entrust_ID>>
    {
        public System.Guid Entrust_ID { get; set; }
        public string FIXED_Asset_No { get; set; }
    }
		
     
		
		 
}
 
 