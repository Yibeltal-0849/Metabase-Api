using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositLoadAll
{
    class GetprocCBankDepositLoadAllQueryHandler : IRequestHandler<GetprocCBankDepositLoadAllQuery, GetprocBankReconciliationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocCBankDepositLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBankReconciliationLoadAllListVm> Handle(GetprocCBankDepositLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CBankDeposit> procCBankDeposits = await _procedureAdabter
               .Execute<CBankDeposit>("[FINA].[proc_C_Bank_DepositLoadAll]");
            GetprocBankReconciliationLoadAllListVm vm = new GetprocBankReconciliationLoadAllListVm
            {
                procCBankDeposits = _mapper.Map<IList<CBankDeposit>, IList<GetprocCBankDepositLoadAllVm>>(procCBankDeposits)
            };

            return vm;
        }
    }
}
