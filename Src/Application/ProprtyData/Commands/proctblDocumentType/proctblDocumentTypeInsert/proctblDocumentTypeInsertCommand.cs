


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblDocumentType.proctblDocumentTypeInsert.proctblDocumentTypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblDocument_TypeInsert stored procedure.


    public class proctblDocumentTypeInsertCommand : IRequest<IList<tblDocumentType_id>>
    {
        public long? id { get; set; }
        public string Name { get; set; }
    }
		
		
		 
}
 
 