using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccTAXPostingSetupUpdate.proccTAXPostingSetupUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_TAX_Posting_SetupUpdate stored procedure.
	 
	 
      public class proccTAXPostingSetupUpdateHandler : IRequestHandler<proccTAXPostingSetupUpdateCommand, IList<proccTAXPostingSetup_TAX_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccTAXPostingSetupUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccTAXPostingSetup_TAX_BusPosting_Group>> Handle( proccTAXPostingSetupUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<proccTAXPostingSetup_TAX_BusPosting_Group> result = await _procedureAdabter
                .Execute<proccTAXPostingSetup_TAX_BusPosting_Group>("[FINA].proc_c_TAX_Posting_SetupUpdate", request);
           

            return result;
        }
    }
}
 
