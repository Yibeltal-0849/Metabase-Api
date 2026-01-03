using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procBankAccountPostingGroup.GetprocBankAccountPostingGroupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procBankAccountPostingGroup.GetprocBankAccountPostingGroupByPrimaryKey
{
    public class GetprocBankAccountPostingGroupQueryHandler : IRequestHandler<GetprocBankAccountPostingGroupByPrimaryKey, GetprocBankAccountPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBankAccountPostingGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocBankAccountPostingGroupLoadAllListVm> Handle(GetprocBankAccountPostingGroupByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<BankAccountPostingGroup> procBankAccountPostingGroups = await _procedureAdabter
               .Execute<BankAccountPostingGroup>("[FINA].[proc_Bank_Account_Posting_GroupLoadByPrimaryKey]", request);
            GetprocBankAccountPostingGroupLoadAllListVm vm = new GetprocBankAccountPostingGroupLoadAllListVm
            {
                procBankAccountPostingGroups = _mapper.Map<IList<BankAccountPostingGroup>, IList<GetprocBankAccountPostingGroupLoadAllVm>>(procBankAccountPostingGroups)
            };

            return vm;
        }
    }
}
