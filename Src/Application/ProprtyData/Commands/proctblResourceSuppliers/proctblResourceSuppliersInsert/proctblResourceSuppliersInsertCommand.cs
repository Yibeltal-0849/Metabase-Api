


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceSuppliers.proctblResourceSuppliersInsert.proctblResourceSuppliersInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceSuppliersInsert stored procedure.


    public class proctblResourceSuppliersInsertCommand : IRequest<IList<tblResourceSuppliers_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Ownership { get; set; }
    }
		
		
		 
}
 
 