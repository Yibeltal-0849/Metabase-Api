using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.procFixedAssetsPostingGroups.GetprocFixedAssetsPostingGroupsByPrimaryKey
{
    public class GetprocFixedAssetsPostingGroupsQueryHandler : IRequestHandler<GetprocFixedAssetsPostingGroupsByPrimaryKey, GetprocFixedAssetsPostingGroupsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFixedAssetsPostingGroupsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFixedAssetsPostingGroupsLoadAllListVm> Handle(GetprocFixedAssetsPostingGroupsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FixedAssetsPostingGroups> procFixedAssetsPostingGroupss = await _procedureAdabter
               .Execute<FixedAssetsPostingGroups>("[FINA].[proc_Fixed_Assets_Posting_GroupsLoadByPrimaryKey]", request);
            GetprocFixedAssetsPostingGroupsLoadAllListVm vm = new GetprocFixedAssetsPostingGroupsLoadAllListVm
            {
                procFixedAssetsPostingGroupss = _mapper.Map<IList<FixedAssetsPostingGroups>, IList<GetprocFixedAssetsPostingGroupsLoadAllVm>>(procFixedAssetsPostingGroupss)
            };

            return vm;
        }
    }
}
