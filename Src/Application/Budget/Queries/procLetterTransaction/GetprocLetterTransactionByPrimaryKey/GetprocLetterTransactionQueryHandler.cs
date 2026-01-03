using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Budget.Quiries.procLetterTransaction.GetprocLetterTransactionLoadAll;
using XOKA.Domain.Entities.Budget;
using XOKA.Domain.Interfaces;

namespace Application.Budget.Quiries.procLetterTransaction.GetprocLetterTransactionByPrimaryKey
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
           
            IList<LetterTransaction> procLetterTransactions = await _procedureAdabter
               .Execute<LetterTransaction>("[Budget].[proc_Letter_TransactionLoadByPrimaryKey]", request);
            GetprocLetterTransactionLoadAllListVm vm = new GetprocLetterTransactionLoadAllListVm
            {
                procLetterTransactions = _mapper.Map<IList<LetterTransaction>, IList<GetprocLetterTransactionLoadAllVm>>(procLetterTransactions)
            };

            return vm;
        }
    }
}
