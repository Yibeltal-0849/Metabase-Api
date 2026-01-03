using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Commands.LetterTransaction.LetterTransactionDelete.LetterTransactionDeleteCommand
{

    ///   @author Shimels Alem Letter_TransactionDelete stored procedure.

    public class LetterTransactionDeleteCommand : IRequest<IList<LetterTransaction_Letter_ID>>
    {
        public Guid Letter_ID { get; set; }
    }
		
		 
	}
 
 
