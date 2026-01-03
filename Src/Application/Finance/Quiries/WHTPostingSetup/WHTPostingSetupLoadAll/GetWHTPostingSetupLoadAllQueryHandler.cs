using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procWithPostingGroup.WHTPostingSetupLoadAll
{
    class WHTPostingSetupLoadAllQueryHandler : IRequestHandler<WHTPostingSetupLoadAllQuery, WHTPostingSetupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public WHTPostingSetupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<WHTPostingSetupLoadAllListVm> Handle(WHTPostingSetupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<WHT_Posting_Setup> procWithPostingGroups = await _procedureAdabter
               .Execute<WHT_Posting_Setup>("[FINA].[proc_WHT_Posting_SetupLoadAll]");
            WHTPostingSetupLoadAllListVm vm = new WHTPostingSetupLoadAllListVm
            {
                procWithPostingGroups = _mapper.Map<IList<WHT_Posting_Setup>, IList<WHTPostingSetupLoadAllVm>>(procWithPostingGroups)
            };

            return vm;
        }
    }
}
