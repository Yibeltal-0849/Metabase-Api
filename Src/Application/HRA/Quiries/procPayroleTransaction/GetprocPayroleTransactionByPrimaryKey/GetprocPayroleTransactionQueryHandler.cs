using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionByPrimaryKey
{
    public class GetprocPayroleTransactionQueryHandler : IRequestHandler<GetprocPayroleTransactionByPrimaryKey, GetprocPayroleTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPayroleTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayroleTransactionLoadAllListVm> Handle(GetprocPayroleTransactionByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<PayroleTransaction> procPayroleTransactions = await _procedureAdabter
               .Execute<PayroleTransaction>("[HRA].[proc_Payrole_TransactionLoadByPrimaryKey]", request);
            GetprocPayroleTransactionLoadAllListVm vm = new GetprocPayroleTransactionLoadAllListVm
            {
                procPayroleTransactions = _mapper.Map<IList<PayroleTransaction>, IList<GetprocPayroleTransactionLoadAllVm>>(procPayroleTransactions)
            };

            return vm;
        }
    }
}
