 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceProduct.proctblResourceProductDelete.proctblResourceProductDeleteCommand
{

    // @author  Shimels Alem  proc_tblResource_ProductDelete stored procedure.


    public class proctblResourceProductDeleteCommand : IRequest<IList<tblResourceProduct_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 