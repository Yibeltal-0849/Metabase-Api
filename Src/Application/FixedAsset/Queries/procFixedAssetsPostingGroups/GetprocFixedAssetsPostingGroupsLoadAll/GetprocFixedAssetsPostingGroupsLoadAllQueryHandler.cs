using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsLoadAll
{
    class GetprocFixedAssetsPostingGroupsLoadAllQueryHandler : IRequestHandler<GetprocFixedAssetsPostingGroupsLoadAllQuery, GetprocFixedAssetsPostingGroupsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFixedAssetsPostingGroupsLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetsPostingGroupsLoadAllListVm> Handle(GetprocFixedAssetsPostingGroupsLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FixedAssetsPostingGroups> procFixedAssetsPostingGroupss = await _procedureAdabter
               .Execute<FixedAssetsPostingGroups>("[FixedAsset].[proc_Fixed_Assets_Posting_GroupsLoadAll]");
            GetprocFixedAssetsPostingGroupsLoadAllListVm vm = new GetprocFixedAssetsPostingGroupsLoadAllListVm
            {
                procFixedAssetsPostingGroupss = _mapper.Map<IList<FixedAssetsPostingGroups>, IList<GetprocFixedAssetsPostingGroupsLoadAllVm>>(procFixedAssetsPostingGroupss)
            };

            return vm;
        }
    }
}
