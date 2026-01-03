


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.ProprtyData;

namespace Application.ProprtyData.Commands.proctblOrganizationType.proctblOrganizationTypeInsert.proctblOrganizationTypeInsertCommand
{

    /// @author  Shimels Alem  proc_tblOrganization_TypeInsert stored procedure.


    public class proctblOrganizationTypeInsertCommand : IRequest<IList<tblOrganizationType_id>>
    {
        public long id { get; set; }
        public string Name { get; set; }
    }
		
		
		 
}
 
 