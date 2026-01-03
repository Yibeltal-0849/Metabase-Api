 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CJournalType.CJournalTypeDelete.CJournalTypeDeleteCommand
{

    // @author  Shimels Alem  C_Journal_TypeDelete stored procedure.


    public class CJournalTypeDeleteCommand : IRequest<IList<CJournalType_Type>>
    {
        public string Type { get; set; }
    }
		
     
		
		 
}
 
 