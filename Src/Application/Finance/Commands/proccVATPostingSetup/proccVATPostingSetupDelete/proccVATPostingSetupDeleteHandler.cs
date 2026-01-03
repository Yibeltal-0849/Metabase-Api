using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccVATPostingSetupDelete.proccVATPostingSetupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_VAT_Posting_SetupDelete stored procedure.
	 
	 
      public class proccVATPostingSetupDeleteHandler : IRequestHandler<proccVATPostingSetupDeleteCommand, IList<proccVATPostingSetup_vAT_BusPosting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccVATPostingSetupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccVATPostingSetup_vAT_BusPosting_Group>> Handle( proccVATPostingSetupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<proccVATPostingSetup_vAT_BusPosting_Group> result = await _procedureAdabter
                .Execute<proccVATPostingSetup_vAT_BusPosting_Group>("[FINA].proc_c_VAT_Posting_SetupDelete", request);
           

            return result;
        }
    }
}
 
