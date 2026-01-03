 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblStackHolder.proctblStackHolderDelete.proctblStackHolderDeleteCommand
{

    // @author  Shimels Alem  proc_tblStackHolderDelete stored procedure.


    public class proctblStackHolderDeleteCommand : IRequest<IList<tblStackHolder_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 