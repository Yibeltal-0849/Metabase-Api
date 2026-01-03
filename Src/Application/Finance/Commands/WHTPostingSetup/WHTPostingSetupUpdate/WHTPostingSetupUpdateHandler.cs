

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.WHTPostingSetup.WHTPostingSetupUpdate.WHTPostingSetupUpdateCommand
{

    /// @author  Shimels Alem  WHT_Posting_SetupUpdate stored procedure.


    public class WHTPostingSetupUpdateHandler : IRequestHandler<WHTPostingSetupUpdateCommand, IList<WHT_Posting_Setup_With_Posting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public WHTPostingSetupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WHT_Posting_Setup_With_Posting_Group>> Handle( WHTPostingSetupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<WHT_Posting_Setup_With_Posting_Group> result = await _procedureAdabter
                .Execute<WHT_Posting_Setup_With_Posting_Group>("[FINA].WHT_Posting_SetupUpdate", request);
           

            return result;
        }
    }
}
 