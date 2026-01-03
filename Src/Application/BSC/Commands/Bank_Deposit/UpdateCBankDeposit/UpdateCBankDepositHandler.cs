using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Bank_Deposit.UpdateCBankDeposit
{
    public class UpdateCBankDepositHandler : IRequestHandler<UpdateCBankDepositCommand, IList<Proc_C_Bank_Deposit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public UpdateCBankDepositHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Bank_Deposit_Id>> Handle(UpdateCBankDepositCommand request, CancellationToken cancellationToken)
        {
            string BankName = request.Bank_Name;
            DateTime? DepositTicketDate = request.Deposit_Ticket_Date;
            string DepositTicketID = request.Deposit_Ticket_ID;
            string Amount = request.Amount;
            System.Guid?Id = request.Id;
            string Vocher_No = request.Vocher_No;
            System.Guid UserID = request.UserID;
            bool Is_EPayment = request.Is_EPayment;

            IList<Proc_C_Bank_Deposit_Id> result = await _procedureAdabter
                .Execute<Proc_C_Bank_Deposit_Id>("[BSC].[proc_C_Bank_DepositUpdate]", (nameof(BankName), BankName), (nameof(DepositTicketDate), DepositTicketDate),
                (nameof(DepositTicketID), DepositTicketID), (nameof(Amount), Amount), (nameof(Id), Id),
            (nameof(Vocher_No), Vocher_No),
                (nameof(UserID), UserID),
            (nameof(Is_EPayment), Is_EPayment));
            return result;
        }
    }
}
