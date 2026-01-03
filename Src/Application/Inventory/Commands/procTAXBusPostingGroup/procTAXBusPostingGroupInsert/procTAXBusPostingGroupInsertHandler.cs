



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.procTAXBusPostingGroup.procTAXBusPostingGroupInsert.procTAXBusPostingGroupInsertCommand
{

    /// @author  Shimels Alem  proc_TAX_Bus_Posting_GroupInsert stored procedure.


    public class procTAXBusPostingGroupInsertHandler : IRequestHandler<procTAXBusPostingGroupInsertCommand, IList<TAX_Bus_Posting_Group_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procTAXBusPostingGroupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<TAX_Bus_Posting_Group_Code>> Handle( procTAXBusPostingGroupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<TAX_Bus_Posting_Group_Code> result = await _procedureAdabter
                .Execute<TAX_Bus_Posting_Group_Code>("[Inventory].proc_TAX_Bus_Posting_GroupInsert", request);
           

            return result;
        }
    }
}
 