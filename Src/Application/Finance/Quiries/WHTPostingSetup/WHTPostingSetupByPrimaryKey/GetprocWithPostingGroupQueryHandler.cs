using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procWithPostingGroup.WHTPostingSetupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procWithPostingGroup.WHTPostingSetupByPrimaryKey
{
    public class WHTPostingSetupQueryHandler : IRequestHandler<WHTPostingSetupByPrimaryKey, WHTPostingSetupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public WHTPostingSetupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<WHTPostingSetupLoadAllListVm> Handle(WHTPostingSetupByPrimaryKey request, CancellationToken cancellationToken)
        {
            
            IList<WHT_Posting_Setup> procWithPostingGroups = await _procedureAdabter
               .Execute<WHT_Posting_Setup>("[FINA].[proc_WHT_Posting_SetupLoadByPrimaryKey]", request);
            WHTPostingSetupLoadAllListVm vm = new WHTPostingSetupLoadAllListVm
            {
                procWithPostingGroups = _mapper.Map<IList<WHT_Posting_Setup>, IList<WHTPostingSetupLoadAllVm>>(procWithPostingGroups)
            };

            return vm;
        }
    }
}
