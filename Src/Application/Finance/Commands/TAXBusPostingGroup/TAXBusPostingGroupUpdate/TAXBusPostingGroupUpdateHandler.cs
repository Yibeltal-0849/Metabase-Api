

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.TAXBusPostingGroup.TAXBusPostingGroupUpdate.TAXBusPostingGroupUpdateCommand
{

    /// @author  Shimels Alem  TAX_Bus_Posting_GroupUpdate stored procedure.


    public class TAXBusPostingGroupUpdateHandler : IRequestHandler<TAXBusPostingGroupUpdateCommand, IList<TAX_Bus_Posting_Group_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public TAXBusPostingGroupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TAX_Bus_Posting_Group_Code>> Handle( TAXBusPostingGroupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<TAX_Bus_Posting_Group_Code> result = await _procedureAdabter
                .Execute<TAX_Bus_Posting_Group_Code>("[FINA].TAX_Bus_Posting_GroupUpdate", request);
           

            return result;
        }
    }
}
 