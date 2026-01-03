



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.FixedAsset.Commands.procFixedAssetsPostingGroups.procFixedAssetsPostingGroupsInsert.procFixedAssetsPostingGroupsInsertCommand
{

    /// @author  Shimels Alem  proc_Fixed Assets Posting GroupsInsert stored procedure.


    public class procFixedAssetsPostingGroupsInsertHandler : IRequestHandler<procFixedAssetsPostingGroupsInsertCommand, IList<FixedAssetsPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procFixedAssetsPostingGroupsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetsPostingGroups_Code>> Handle( procFixedAssetsPostingGroupsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetsPostingGroups_Code> result = await _procedureAdabter
                .Execute<FixedAssetsPostingGroups_Code>("[FixedAsset].proc_Fixed_Assets_Posting_GroupsInsert", request);
           

            return result;
        }
    }
}
 