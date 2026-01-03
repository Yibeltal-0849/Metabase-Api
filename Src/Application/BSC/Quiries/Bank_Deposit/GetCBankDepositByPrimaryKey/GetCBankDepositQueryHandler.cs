using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Application.BSC.Quiries.Bank_Deposit.GetCBankDepositLoadAll;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Quiries.Bank_Deposit.GetCBankDepositByPrimaryKey
{
    public class GetCBankDepositQueryHandler : IRequestHandler<GetCBankDepositByPrimaryKey, GetCBankDepositLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCBankDepositQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCBankDepositLoadAllListVm> Handle(GetCBankDepositByPrimaryKey request, CancellationToken cancellationToken)
        {
            Guid Id = request.Id;
            IList<Proc_C_Bank_Deposit> bankDeposits = await _procedureAdabter
               .Execute<Proc_C_Bank_Deposit>("[BSC].[proc_C_Bank_DepositLoadByPrimaryKey]", (nameof(Id), Id));
            GetCBankDepositLoadAllListVm vm = new GetCBankDepositLoadAllListVm
            {
                BankDeposits = _mapper.Map<IList<Proc_C_Bank_Deposit>, IList<GetCBankDepositLoadAllVm>>(bankDeposits)
            };

            return vm;
        }
    }
}
