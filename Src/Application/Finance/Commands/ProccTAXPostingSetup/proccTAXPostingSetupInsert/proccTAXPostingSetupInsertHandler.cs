using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccTAXPostingSetupInsert.proccTAXPostingSetupInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_TAX_Posting_SetupInsert stored procedure.
	 
	 
      public class proccTAXPostingSetupInsertHandler : IRequestHandler<proccTAXPostingSetupInsertCommand, IList<proccTAXPostingSetup_TAX_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccTAXPostingSetupInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccTAXPostingSetup_TAX_BusPosting_Group>> Handle( proccTAXPostingSetupInsertCommand request, CancellationToken cancellationToken)
        {

            IList<proccTAXPostingSetup_TAX_BusPosting_Group> result = await _procedureAdabter
                .Execute<proccTAXPostingSetup_TAX_BusPosting_Group>("[FINA].proc_c_TAX_Posting_SetupInsert", request);
           

            return result;
        }
    }
}
 
