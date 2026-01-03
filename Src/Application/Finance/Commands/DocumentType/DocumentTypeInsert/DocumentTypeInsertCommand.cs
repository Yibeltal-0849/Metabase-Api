


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.DocumentType.DocumentTypeInsert.DocumentTypeInsertCommand
{

    /// @author  Shimels Alem  Document_TypeInsert stored procedure.


    public class DocumentTypeInsertCommand : IRequest<IList<DocumentType_Name>>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Is_Active { get; set; }
    }
		
		
}
 
 