


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CTax.CTaxInsert.CTaxInsertCommand
{

    /// @author  Shimels Alem  C_TaxInsert stored procedure.


    public class CTaxInsertCommand : IRequest<IList<CTax_Code>>
    {
        public string Org_ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? Enable { get; set; }
    }
		
		
		 
}
 
 