 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Finance;

namespace Application.Finance.Commands.JJCreditMemojournal.JJCreditMemojournalDelete.JJCreditMemojournalDeleteCommand
{

    // @author  Shimels Alem  JJ_Credit_Memo_journalInsert stored procedure.


    public class JJCreditMemojournalDeleteCommand : IRequest<IList<JJCreditMemojournal_LineType>>
    {

        public string LineType { get; set; }
    }
		
     
		
		 
}
 
 