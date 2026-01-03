 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procFixedAssetMent.procFixedAssetMentDelete.procFixedAssetMentDeleteCommand
{

    // @author  Shimels Alem  proc_Fixed_Asset_MentDelete stored procedure.


    public class procFixedAssetMentDeleteCommand : IRequest<IList<FixedAssetMent_Maintainance_ID>>
    {
        public string Maintainance_ID { get; set; }
    }
		
     
		
		 
}
 
 