 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procMaintainancePartsChange.procMaintainancePartsChangeDelete.procMaintainancePartsChangeDeleteCommand
{

    // @author  Shimels Alem  proc_Maintainance_PartsChangeDelete stored procedure.


    public class procMaintainancePartsChangeDeleteCommand : IRequest<IList<MaintainancePartsChange_PartsCange_ID>>
    {
        public long PartsCange_ID { get; set; }
    }
		
     
		
		 
}
 
 