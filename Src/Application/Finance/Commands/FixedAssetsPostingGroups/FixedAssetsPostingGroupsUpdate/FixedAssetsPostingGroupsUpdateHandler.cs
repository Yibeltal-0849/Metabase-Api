

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.FixedAssetsPostingGroups.FixedAssetsPostingGroupsUpdate.FixedAssetsPostingGroupsUpdateCommand
{

    /// @author  Shimels Alem  [Fixed_Assets_Posting_GroupsUpdate] stored procedure.


    public class FixedAssetsPostingGroupsUpdateHandler : IRequestHandler<FixedAssetsPostingGroupsUpdateCommand, IList<FixedAssetsPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetsPostingGroupsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetsPostingGroups_Code>> Handle( FixedAssetsPostingGroupsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetsPostingGroups_Code> result = await _procedureAdabter
                .Execute<FixedAssetsPostingGroups_Code>("[FINA].[Fixed_Assets_Posting_GroupsUpdate]", request);
           

            return result;
        }
    }
}
 