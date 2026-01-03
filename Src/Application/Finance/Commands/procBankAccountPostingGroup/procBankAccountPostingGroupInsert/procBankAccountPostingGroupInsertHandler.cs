



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procBankAccountPostingGroup.procBankAccountPostingGroupInsert.procBankAccountPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_Bank_Account_Posting_GroupInsert stored procedure.


    public class procBankAccountPostingGroupInsertHandler : IRequestHandler<procBankAccountPostingGroupInsertCommand, IList<BankAccountPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBankAccountPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BankAccountPostingGroup_Code>> Handle( procBankAccountPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<BankAccountPostingGroup_Code> result = await _procedureAdabter
                .Execute<BankAccountPostingGroup_Code>("[FINA].proc_Bank_Account_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 