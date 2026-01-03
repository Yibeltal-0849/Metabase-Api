 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceSuppliers.proctblResourceSuppliersDelete.proctblResourceSuppliersDeleteCommand
{

    // @author  Shimels Alem  proc_tblResourceSuppliersDelete stored procedure.


    public class proctblResourceSuppliersDeleteCommand : IRequest<IList<tblResourceSuppliers_id>>
    {
        public long id { get; set; }
    }
		
     
		
		 
}
 
 