using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procWithPostingGroup.GetprocWithPostingGroupLoadAll
{
    class GetprocWithPostingGroupLoadAllQueryHandler : IRequestHandler<GetprocWithPostingGroupLoadAllQuery, GetprocWithPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocWithPostingGroupLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWithPostingGroupLoadAllListVm> Handle(GetprocWithPostingGroupLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<With_Posting_Group> procWithPostingGroups = await _procedureAdabter
               .Execute<With_Posting_Group>("[FINA].[proc_With_Posting_GroupLoadAll]");
            GetprocWithPostingGroupLoadAllListVm vm = new GetprocWithPostingGroupLoadAllListVm
            {
                procWithPostingGroups = _mapper.Map<IList<With_Posting_Group>, IList<GetprocWithPostingGroupLoadAllVm>>(procWithPostingGroups)
            };

            return vm;
        }
    }
}
