using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procGenBusPostingGroups.GetprocGenBusPostingGroupsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procGenBusPostingGroups.GetprocGenBusPostingGroupsByPrimaryKey
{
    public class GetprocGenBusPostingGroupsQueryHandler : IRequestHandler<GetprocGenBusPostingGroupsByPrimaryKey, GetprocGenBusPostingGroupsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocGenBusPostingGroupsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocGenBusPostingGroupsLoadAllListVm> Handle(GetprocGenBusPostingGroupsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<GenBusPostingGroups> procGenBusPostingGroupss = await _procedureAdabter
               .Execute<GenBusPostingGroups>("[FINA].[proc_Gen_Bus_Posting_GroupsLoadByPrimaryKey]", request);
            GetprocGenBusPostingGroupsLoadAllListVm vm = new GetprocGenBusPostingGroupsLoadAllListVm
            {
                procGenBusPostingGroupss = _mapper.Map<IList<GenBusPostingGroups>, IList<GetprocGenBusPostingGroupsLoadAllVm>>(procGenBusPostingGroupss)
            };

            return vm;
        }
    }
}
