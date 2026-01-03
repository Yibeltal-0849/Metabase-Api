using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procInventoryPostingSetupDelete.procInventoryPostingSetupDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Inventory_Posting_SetupDelete stored procedure.
	 
	 
      public class procInventoryPostingSetupDeleteHandler : IRequestHandler<procInventoryPostingSetupDeleteCommand, IList<procInventoryPostingSetup_store_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procInventoryPostingSetupDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procInventoryPostingSetup_store_Code>> Handle( procInventoryPostingSetupDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<procInventoryPostingSetup_store_Code> result = await _procedureAdabter
                .Execute<procInventoryPostingSetup_store_Code>("[FINA].proc_Inventory_Posting_SetupDelete", request);
           

            return result;
        }
    }
}
 
