 


using MediatR;
using System;
using System.Collections.Generic;
using XOKA.Domain.Entities.Document;

namespace Application.Document.Commands.LetterTransaction.LetterTransactionDelete.LetterTransactionDeleteCommand
{

    // @author  Shimels Alem  proc_Letter_TransactionDelete stored procedure.


    public class LetterTransactionDeleteCommand : IRequest<IList<Letter_Transaction_Letter_ID>>
    {
        public Guid Letter_ID { get; set; }
    }
		
     
		
		 
	}
 
 