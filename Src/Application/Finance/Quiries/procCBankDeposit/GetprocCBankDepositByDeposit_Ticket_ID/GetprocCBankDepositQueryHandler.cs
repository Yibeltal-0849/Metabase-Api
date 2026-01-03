using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procCBankDeposit.GetprocCBankDepositByDeposit_Ticket_ID
{
    public class GetprocCBankDepositQueryHandler : IRequestHandler<GetprocCBankDepositByDeposit_Ticket_ID, GetprocBankReconciliationLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocCBankDepositQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBankReconciliationLoadAllListVm> Handle(GetprocCBankDepositByDeposit_Ticket_ID request, CancellationToken cancellationToken)
        {
           
            IList<CBankDeposit> procCBankDeposits = await _procedureAdabter
               .Execute<CBankDeposit>("[FINA].[proc_C_Bank_DepositLoadByPrimaryKey_Deposit_Ticket_ID]", request);
            GetprocBankReconciliationLoadAllListVm vm = new GetprocBankReconciliationLoadAllListVm
            {
                procCBankDeposits = _mapper.Map<IList<CBankDeposit>, IList<GetprocCBankDepositLoadAllVm>>(procCBankDeposits)
            };

            return vm;
        }
    }
}
