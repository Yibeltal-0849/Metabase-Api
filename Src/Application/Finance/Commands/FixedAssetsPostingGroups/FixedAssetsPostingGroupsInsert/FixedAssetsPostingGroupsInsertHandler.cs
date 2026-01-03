



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.FixedAssetsPostingGroups.FixedAssetsPostingGroupsInsert.FixedAssetsPostingGroupsInsertCommand
{

    /// @author  Shimels Alem  [Fixed_Assets_Posting_GroupsInsert] stored procedure.


    public class FixedAssetsPostingGroupsInsertHandler : IRequestHandler<FixedAssetsPostingGroupsInsertCommand, IList<FixedAssetsPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public FixedAssetsPostingGroupsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<FixedAssetsPostingGroups_Code>> Handle( FixedAssetsPostingGroupsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<FixedAssetsPostingGroups_Code> result = await _procedureAdabter
                .Execute<FixedAssetsPostingGroups_Code>("[FINA].[Fixed_Assets_Posting_GroupsInsert]", request);
           

            return result;
        }
    }
}
 