 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.procItemTransferDetail.procItemTransferDetailDelete.procItemTransferDetailDeleteCommand
{

    // @author  Shimels Alem  proc_Item_Transfer_DetailDelete stored procedure.


    public class procItemTransferDetailDeleteCommand : IRequest<IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        public string Transfer_Req_DetailID { get; set; }
    }
		
     
		
		 
}
 
 