 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.LGLRegisters.LGLRegistersDelete.LGLRegistersDeleteCommand
{

    // @author  Shimels Alem  L_G_L_RegistersDelete stored procedure.


    public class LGLRegistersDeleteCommand : IRequest<IList<LGLRegisters_Branch_ID>>
    {
        public System.Guid Branch_ID { get; set; }
        public System.DateTime Period { get; set; }
        public System.DateTime Posting_Date { get; set; }
        public System.Int64 To_VAT_Entry_No { get; set; }
    }
		
     
		
		 
}
 
 