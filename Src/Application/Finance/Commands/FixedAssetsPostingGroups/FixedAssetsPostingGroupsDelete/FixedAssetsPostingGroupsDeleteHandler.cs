using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.FixedAssetsPostingGroups.FixedAssetsPostingGroupsDelete.FixedAssetsPostingGroupsDeleteCommand
{

    /// @author  Shimels Alem  [Fixed_Assets_Posting_GroupsDelete] stored procedure.


    public class FixedAssetsPostingGroupsDeleteHandler : IRequestHandler<FixedAssetsPostingGroupsDeleteCommand, IList<FixedAssetsPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetsPostingGroupsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetsPostingGroups_Code>> Handle( FixedAssetsPostingGroupsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetsPostingGroups_Code> result = await _procedureAdabter
                .Execute<FixedAssetsPostingGroups_Code>("[FINA].[Fixed_Assets_Posting_GroupsDelete]", request);
           

            return result;
        }
    }
}
  