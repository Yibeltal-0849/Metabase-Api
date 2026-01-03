using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cTAXPostingSetup.cTAXPostingSetupDelete.cTAXPostingSetupDeleteCommand
{

    /// @author  Shimels Alem  c_TAX_Posting_SetupDelete stored procedure.


    public class cTAXPostingSetupDeleteHandler : IRequestHandler<cTAXPostingSetupDeleteCommand, IList<CTaxPostingSetup_TAX_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTAXPostingSetupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTaxPostingSetup_TAX_BusPosting_Group>> Handle( cTAXPostingSetupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CTaxPostingSetup_TAX_BusPosting_Group> result = await _procedureAdabter
                .Execute<CTaxPostingSetup_TAX_BusPosting_Group>("[FINA].c_TAX_Posting_SetupDelete", request);
           

            return result;
        }
    }
}
  