using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procWithPostingGroup.GetprocWithPostingGroupLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procWithPostingGroup.GetprocWithPostingGroupByPrimaryKey
{
    public class GetprocWithPostingGroupQueryHandler : IRequestHandler<GetprocWithPostingGroupByPrimaryKey, GetprocWithPostingGroupLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocWithPostingGroupQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocWithPostingGroupLoadAllListVm> Handle(GetprocWithPostingGroupByPrimaryKey request, CancellationToken cancellationToken)
        {
            
            IList<With_Posting_Group> procWithPostingGroups = await _procedureAdabter
               .Execute<With_Posting_Group>("[FINA].[proc_With_Posting_GroupLoadByPrimaryKey]", request);
            GetprocWithPostingGroupLoadAllListVm vm = new GetprocWithPostingGroupLoadAllListVm
            {
                procWithPostingGroups = _mapper.Map<IList<With_Posting_Group>, IList<GetprocWithPostingGroupLoadAllVm>>(procWithPostingGroups)
            };

            return vm;
        }
    }
}
