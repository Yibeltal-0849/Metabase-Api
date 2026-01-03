

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cTAXPostingSetup.cTAXPostingSetupUpdate.cTAXPostingSetupUpdateCommand
{

    /// @author  Shimels Alem  c_TAX_Posting_SetupUpdate stored procedure.


    public class cTAXPostingSetupUpdateHandler : IRequestHandler<cTAXPostingSetupUpdateCommand, IList<CTaxPostingSetup_TAX_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTAXPostingSetupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTaxPostingSetup_TAX_BusPosting_Group>> Handle( cTAXPostingSetupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CTaxPostingSetup_TAX_BusPosting_Group> result = await _procedureAdabter
                .Execute<CTaxPostingSetup_TAX_BusPosting_Group>("[FINA].c_TAX_Posting_SetupUpdate", request);
           

            return result;
        }
    }
}
 