


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.CJournalTypePosting.CJournalTypePostingInsert.CJournalTypePostingInsertCommand
{

    /// @author  Shimels Alem  C_Journal_Type_PostingInsert stored procedure.


    public class CJournalTypePostingInsertCommand : IRequest<IList<CJournalTypePosting_Type>>
    {
        public string Type { get; set; }
        public int? Steps { get; set; }
        public string Start_Debit_Accounts { get; set; }
        public string Start_Credit_Accounts { get; set; }
    }
		
		
		 
}
 
 