using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Document.Quiries.procLetterTransaction.GetprocLetterTransactionLoadAll;
using XOKA.Domain.Entities.Document;
using XOKA.Domain.Interfaces;

namespace Application.Document.Quiries.procLetterTransaction.GetprocLetterTransactionByPrimaryKey
{
    public class GetprocLetterTransactionQueryHandler : IRequestHandler<GetprocLetterTransactionByPrimaryKey, GetprocLetterTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLetterTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLetterTransactionLoadAllListVm> Handle(GetprocLetterTransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<Letter_Transaction> procLetterTransactions = await _procedureAdabter
               .Execute<Letter_Transaction>("[Document].[proc_Letter_TransactionLoadByPrimaryKey]", request);
            GetprocLetterTransactionLoadAllListVm vm = new GetprocLetterTransactionLoadAllListVm
            {
                procLetterTransactions = _mapper.Map<IList<Letter_Transaction>, IList<GetprocLetterTransactionLoadAllVm>>(procLetterTransactions)
            };

            return vm;
        }
    }
}
