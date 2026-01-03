 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDocumentDetail.proctblDocumentDetailDelete.proctblDocumentDetailDeleteCommand
{

    // @author  Shimels Alem  proc_tblDocument_DetailDelete stored procedure.


    public class proctblDocumentDetailDeleteCommand : IRequest<IList<tblDocumentDetail_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 