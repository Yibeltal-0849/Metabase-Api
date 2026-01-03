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

namespace XOKA.Application.BSC.Quiries.Bank_Deposit.GetprocCBankDepositLoadByPrimaryKeyDepositTicketID
{
    public class GetCBankDepositQueryHandler : IRequestHandler<GetprocCBankDepositLoadByPrimaryKeyDepositTicketID, GetCBankDepositLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetCBankDepositQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetCBankDepositLoadAllListVm> Handle(GetprocCBankDepositLoadByPrimaryKeyDepositTicketID request, CancellationToken cancellationToken)
        {
            string Deposit_Ticket_ID = request.Deposit_Ticket_ID;
            IList<Proc_C_Bank_Deposit> bankDeposits = await _procedureAdabter
               .Execute<Proc_C_Bank_Deposit>("[BSC].[proc_C_Bank_DepositLoadByPrimaryKey_Deposit_Ticket_ID]", (nameof(Deposit_Ticket_ID), Deposit_Ticket_ID));
            GetCBankDepositLoadAllListVm vm = new GetCBankDepositLoadAllListVm
            {
                BankDeposits = _mapper.Map<IList<Proc_C_Bank_Deposit>, IList<GetCBankDepositLoadAllVm>>(bankDeposits)
            };

            return vm;
        }
    }
}
