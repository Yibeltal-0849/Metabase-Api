



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.WHTPostingSetup.WHTPostingSetupInsert.WHTPostingSetupInsertCommand
{

    /// @author  Shimels Alem  WHT_Posting_SetupInsert stored procedure.


    public class WHTPostingSetupInsertHandler : IRequestHandler<WHTPostingSetupInsertCommand, IList<WHT_Posting_Setup_With_Posting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public WHTPostingSetupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WHT_Posting_Setup_With_Posting_Group>> Handle( WHTPostingSetupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<WHT_Posting_Setup_With_Posting_Group> result = await _procedureAdabter
                .Execute<WHT_Posting_Setup_With_Posting_Group>("[FINA].WHT_Posting_SetupInsert", request);
           

            return result;
        }
    }
}
 