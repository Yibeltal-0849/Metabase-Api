 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.FixedAsset;

namespace Application.FixedAsset.Commands.MaintainancePartsChange.MaintainancePartsChangeDelete.MaintainancePartsChangeDeleteCommand
{

    // @author  Shimels Alem  Maintainance_PartsChangeDelete stored procedure.


    public class MaintainancePartsChangeDeleteCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
    {
        public System.Int64 PartsCange_ID { get; set; }
    }
		
     
		
		 
	}
 
 