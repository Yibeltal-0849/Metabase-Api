using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionLoadAll;
using XOKA.Domain.Entities.HRA;
using XOKA.Domain.Interfaces;

namespace Application.HRA.Quiries.procLeaveTransaction.GetprocLeaveTransactionLoadByPrimaryKeyApplicationNumber
{
    public class GetprocLeaveTransactionQueryHandler : IRequestHandler<GetprocLeaveTransactionLoadByPrimaryKeyApplicationNumber, GetprocLeaveTransactionLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocLeaveTransactionQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocLeaveTransactionLoadAllListVm> Handle(GetprocLeaveTransactionLoadByPrimaryKeyApplicationNumber request, CancellationToken cancellationToken)
        {
           
            IList<LeaveTransaction> procLeaveTransactions = await _procedureAdabter
               .Execute<LeaveTransaction>("[HRA].[proc_Leave_TransactionLoadByPrimaryKey_Application_Number]", request);
            GetprocLeaveTransactionLoadAllListVm vm = new GetprocLeaveTransactionLoadAllListVm
            {
                procLeaveTransactions = _mapper.Map<IList<LeaveTransaction>, IList<GetprocLeaveTransactionLoadAllVm>>(procLeaveTransactions)
            };

            return vm;
        }
    }
}
