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

namespace Application.HRA.Quiries.procPayroleTransaction.GetprocPayroleTransactionLoadByPrimaryKeyApplicationNumber
{
    public class GetprocPayroleTransactionQueryHandler : IRequestHandler<GetprocPayroleTransactionLoadByPrimaryKeyApplicationNumber, GetprocPayroleTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocPayroleTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocPayroleTransactionLoadAllListVm> Handle(GetprocPayroleTransactionLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
           
            IList<PayroleTransaction> procPayroleTransactions = await _procedureAdabter
               .Execute<PayroleTransaction>("[HRA].[proc_Payrole_TransactionLoadByPrimaryKey_Appilcation_Number ]", request);
            GetprocPayroleTransactionLoadAllListVm vm = new GetprocPayroleTransactionLoadAllListVm
            {
                procPayroleTransactions = _mapper.Map<IList<PayroleTransaction>, IList<GetprocPayroleTransactionLoadAllVm>>(procPayroleTransactions)
            };

            return vm;
        }
    }
}
