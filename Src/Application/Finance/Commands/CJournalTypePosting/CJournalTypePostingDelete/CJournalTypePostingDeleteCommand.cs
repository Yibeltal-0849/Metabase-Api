 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CJournalTypePosting.CJournalTypePostingDelete.CJournalTypePostingDeleteCommand
{

    // @author  Shimels Alem  C_Journal_Type_PostingDelete stored procedure.


    public class CJournalTypePostingDeleteCommand : IRequest<IList<CJournalTypePosting_Type>>
    {
        public string Type { get; set; }
    }
		
     
		
		 
}
 
 