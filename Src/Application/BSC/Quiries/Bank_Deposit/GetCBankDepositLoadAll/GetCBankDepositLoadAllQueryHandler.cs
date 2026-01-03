using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Bank_Deposit.GetCBankDepositLoadAll
{
    class GetCBankDepositLoadAllQueryHandler : IRequestHandler<GetCBankDepositLoadAllQuery, GetCBankDepositLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetCBankDepositLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCBankDepositLoadAllListVm> Handle(GetCBankDepositLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<Proc_C_Bank_Deposit> bankDeposits = await _procedureAdabter
               .Execute<Proc_C_Bank_Deposit>("[BSC].[proc_C_Bank_DepositLoadAll]");
            GetCBankDepositLoadAllListVm vm = new GetCBankDepositLoadAllListVm
            {
                BankDeposits = _mapper.Map<IList<Proc_C_Bank_Deposit>, IList<GetCBankDepositLoadAllVm>>(bankDeposits)
            };

            return vm;
        }
    }
}
