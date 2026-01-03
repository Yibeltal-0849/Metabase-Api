

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procBankAccountPostingGroup.procBankAccountPostingGroupUpdate.procBankAccountPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  proc_Bank_Account_Posting_GroupUpdate stored procedure.


    public class procBankAccountPostingGroupUpdateHandler : IRequestHandler<procBankAccountPostingGroupUpdateCommand, IList<BankAccountPostingGroup_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBankAccountPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BankAccountPostingGroup_Code>> Handle( procBankAccountPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<BankAccountPostingGroup_Code> result = await _procedureAdabter
                .Execute<BankAccountPostingGroup_Code>("[FINA].proc_Bank_Account_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 