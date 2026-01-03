using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procJInventoryJournalInsert.procJInventoryJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  Proc_J_Inventory_Journal_Insert  stored procedure.
	 
	 
      public class ProcJInventoryJournalInsertHandler : IRequestHandler<ProcJInventoryJournalInsertCommand, IList<procInventoryPostingSetup_store_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ProcJInventoryJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procInventoryPostingSetup_store_Code>> Handle( ProcJInventoryJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<procInventoryPostingSetup_store_Code> result = await _procedureAdabter
                .Execute<procInventoryPostingSetup_store_Code>("[FINA].proc_J_Inventory_Journal_Insert ", request);
           

            return result;
        }
    }
}
 
