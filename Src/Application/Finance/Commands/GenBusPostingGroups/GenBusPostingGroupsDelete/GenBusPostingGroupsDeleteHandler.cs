using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.GenBusPostingGroups.GenBusPostingGroupsDelete.GenBusPostingGroupsDeleteCommand
{

    /// @author  Shimels Alem  Gen_Bus_Posting_GroupsDelete stored procedure.


    public class GenBusPostingGroupsDeleteHandler : IRequestHandler<GenBusPostingGroupsDeleteCommand, IList<GenBusPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GenBusPostingGroupsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GenBusPostingGroups_Code>> Handle( GenBusPostingGroupsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<GenBusPostingGroups_Code> result = await _procedureAdabter
                .Execute<GenBusPostingGroups_Code>("[FINA].[Gen_Bus_Posting_GroupsDelete]", request);
           

            return result;
        }
    }
}
  