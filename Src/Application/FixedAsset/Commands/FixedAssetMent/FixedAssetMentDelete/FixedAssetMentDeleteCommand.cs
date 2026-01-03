 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.FixedAssetMent.FixedAssetMentDelete.FixedAssetMentDeleteCommand
{

    // @author  Shimels Alem  Fixed_Asset_MentDelete stored procedure.


    public class FixedAssetMentDeleteCommand : IRequest<IList<FixedAssetMent_Maintainance_ID>>
    {
        public string Maintainance_ID { get; set; }
    }
		
     
		
		 
	}
 
 