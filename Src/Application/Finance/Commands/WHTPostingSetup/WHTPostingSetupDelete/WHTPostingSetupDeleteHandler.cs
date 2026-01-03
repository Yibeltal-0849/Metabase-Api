using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.WHTPostingSetup.WHTPostingSetupDelete.WHTPostingSetupDeleteCommand
{

    /// @author  Shimels Alem  WHT_Posting_SetupDelete stored procedure.


    public class WHTPostingSetupDeleteHandler : IRequestHandler<WHTPostingSetupDeleteCommand, IList<WHT_Posting_Setup_With_Posting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public WHTPostingSetupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<WHT_Posting_Setup_With_Posting_Group>> Handle( WHTPostingSetupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<WHT_Posting_Setup_With_Posting_Group> result = await _procedureAdabter
                .Execute<WHT_Posting_Setup_With_Posting_Group>("[FINA].WHT_Posting_SetupDelete", request);
           

            return result;
        }
    }
}
  