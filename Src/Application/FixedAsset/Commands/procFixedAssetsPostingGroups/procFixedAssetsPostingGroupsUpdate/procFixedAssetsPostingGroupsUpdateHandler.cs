

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.procFixedAssetsPostingGroups.procFixedAssetsPostingGroupsUpdate.procFixedAssetsPostingGroupsUpdateCommand
{

    /// @author  Shimels Alem  proc_Fixed_Assets_Posting_GroupsUpdate stored procedure.


    public class procFixedAssetsPostingGroupsUpdateHandler : IRequestHandler<procFixedAssetsPostingGroupsUpdateCommand, IList<FixedAssetsPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetsPostingGroupsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetsPostingGroups_Code>> Handle( procFixedAssetsPostingGroupsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetsPostingGroups_Code> result = await _procedureAdabter
                .Execute<FixedAssetsPostingGroups_Code>("[FixedAsset].proc_Fixed_Assets_Posting_GroupsUpdate", request);
           

            return result;
        }
    }
}
 