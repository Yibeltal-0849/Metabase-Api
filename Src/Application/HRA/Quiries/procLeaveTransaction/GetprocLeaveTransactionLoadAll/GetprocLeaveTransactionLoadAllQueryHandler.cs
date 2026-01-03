using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionLoadAll
{
    class GetprocLeaveTransactionLoadAllQueryHandler : IRequestHandler<GetprocLeaveTransactionLoadAllQuery, GetprocLeaveTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocLeaveTransactionLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLeaveTransactionLoadAllListVm> Handle(GetprocLeaveTransactionLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<LeaveTransaction> procLeaveTransactions = await _procedureAdabter
               .Execute<LeaveTransaction>("[HRA].[proc_Leave_TransactionLoadAll]");
            GetprocLeaveTransactionLoadAllListVm vm = new GetprocLeaveTransactionLoadAllListVm
            {
                procLeaveTransactions = _mapper.Map<IList<LeaveTransaction>, IList<GetprocLeaveTransactionLoadAllVm>>(procLeaveTransactions)
            };

            return vm;
        }
    }
}
