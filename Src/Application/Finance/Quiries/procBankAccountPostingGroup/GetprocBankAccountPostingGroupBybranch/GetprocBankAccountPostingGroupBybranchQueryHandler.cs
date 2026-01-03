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
    public class GetprocBankAccountPostingGroupBybranchQueryHandler : IRequestHandler<GetprocBankAccountPostingGroupBybranch, GAvalable_bankListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocBankAccountPostingGroupBybranchQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GAvalable_bankListVm> Handle(GetprocBankAccountPostingGroupBybranch request, CancellationToken cancellationToken)
        {
           
            IList<Availablebanks> Availablebanks = await _procedureAdabter
               .Execute<Availablebanks>("[FINA].[get_Avalable_bank]", request);
            GAvalable_bankListVm vm = new GAvalable_bankListVm
            {
                Availablebanks = _mapper.Map<IList<Availablebanks>, IList<GAvalable_bankVm>>(Availablebanks)
            };

            return vm;
        }
    }
}
