

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.procTAXBusPostingGroup.procTAXBusPostingGroupUpdate.procTAXBusPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  proc_TAX_Bus_Posting_GroupUpdate stored procedure.


    public class procTAXBusPostingGroupUpdateHandler : IRequestHandler<procTAXBusPostingGroupUpdateCommand, IList<TAX_Bus_Posting_Group_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTAXBusPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TAX_Bus_Posting_Group_Code>> Handle( procTAXBusPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<TAX_Bus_Posting_Group_Code> result = await _procedureAdabter
                .Execute<TAX_Bus_Posting_Group_Code>("[Inventory].proc_TAX_Bus_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 