using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccTAXPostingSetupDelete.proccTAXPostingSetupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_TAX_Posting_SetupDelete stored procedure.
	 
	 
      public class proccTAXPostingSetupDeleteHandler : IRequestHandler<proccTAXPostingSetupDeleteCommand, IList<proccTAXPostingSetup_TAX_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccTAXPostingSetupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccTAXPostingSetup_TAX_BusPosting_Group>> Handle( proccTAXPostingSetupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<proccTAXPostingSetup_TAX_BusPosting_Group> result = await _procedureAdabter
                .Execute<proccTAXPostingSetup_TAX_BusPosting_Group>("[FINA].proc_c_TAX_Posting_SetupDelete", request);
           

            return result;
        }
    }
}
 
