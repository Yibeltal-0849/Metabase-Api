



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cTAXPostingSetup.cTAXPostingSetupInsert.cTAXPostingSetupInsertCommand
{

    /// @author  Shimels Alem  c_TAX_Posting_SetupInsert stored procedure.


    public class cTAXPostingSetupInsertHandler : IRequestHandler<cTAXPostingSetupInsertCommand, IList<CTaxPostingSetup_TAX_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cTAXPostingSetupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTaxPostingSetup_TAX_BusPosting_Group>> Handle( cTAXPostingSetupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CTaxPostingSetup_TAX_BusPosting_Group> result = await _procedureAdabter
                .Execute<CTaxPostingSetup_TAX_BusPosting_Group>("[FINA].c_TAX_Posting_SetupInsert", request);
           

            return result;
        }
    }
}
 