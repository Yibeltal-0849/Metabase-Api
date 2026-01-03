

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.GenBusPostingGroups.GenBusPostingGroupsUpdate.GenBusPostingGroupsUpdateCommand
{

    /// @author  Shimels Alem  Gen_Bus_Posting_GroupsUpdate stored procedure.


    public class GenBusPostingGroupsUpdateHandler : IRequestHandler<GenBusPostingGroupsUpdateCommand, IList<GenBusPostingGroups_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GenBusPostingGroupsUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<GenBusPostingGroups_Code>> Handle( GenBusPostingGroupsUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<GenBusPostingGroups_Code> result = await _procedureAdabter
                .Execute<GenBusPostingGroups_Code>("[FINA].Gen_Bus_Posting_GroupsUpdate", request);
           

            return result;
        }
    }
}
 