using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.FixedAsset.Commands.procFixedAssetsPostingGroups.procFixedAssetsPostingGroupsDelete.procFixedAssetsPostingGroupsDeleteCommand
{

    /// @author  Shimels Alem  proc_Fixed_Assets_Posting_GroupsDelete stored procedure.


    public class procFixedAssetsPostingGroupsDeleteHandler : IRequestHandler<procFixedAssetsPostingGroupsDeleteCommand, IList<FixedAssetsPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetsPostingGroupsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetsPostingGroups_Code>> Handle( procFixedAssetsPostingGroupsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetsPostingGroups_Code> result = await _procedureAdabter
                .Execute<FixedAssetsPostingGroups_Code>("[FixedAsset].proc_Fixed_Assets_Posting_GroupsDelete", request);
           

            return result;
        }
    }
}
  