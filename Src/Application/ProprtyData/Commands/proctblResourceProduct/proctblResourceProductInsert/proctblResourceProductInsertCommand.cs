


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblResourceProduct.proctblResourceProductInsert.proctblResourceProductInsertCommand
{

    /// @author  Shimels Alem  proc_tblResource_ProductInsert stored procedure.


    public class proctblResourceProductInsertCommand : IRequest<IList<tblResourceProduct_id>>
    {
        public long? id { get; set; }
        public long? Resource_Id { get; set; }
        public long? UseOrUsed_For { get; set; }
        public string Remark { get; set; }
    }
		
		
		 
}
 
 