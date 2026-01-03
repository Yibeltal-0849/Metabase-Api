using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;

namespace XOKA.Application.BSC.Commands.Bank_Deposit.DeleteCBankDeposit
{
    public class DeleteCBankDepositHandler : IRequestHandler<DeleteCBankDepositCommand, IList<Proc_C_Bank_Deposit_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public DeleteCBankDepositHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proc_C_Bank_Deposit_Id>> Handle(DeleteCBankDepositCommand request, CancellationToken cancellationToken)
        {
            System.Guid?Id = request.Id;
            IList<Proc_C_Bank_Deposit_Id> result = await _procedureAdabter
                .Execute<Proc_C_Bank_Deposit_Id>("[BSC].[proc_C_Bank_DepositDelete]", (nameof(Id), Id));

            return result;
        }
    }
}
