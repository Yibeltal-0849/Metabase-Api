using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPurchaseJournalInsert.JPurchaseJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Purchase_JournalInsert stored procedure.
	 
	 
      public class JPurchaseJournalInsertHandler : IRequestHandler<JPurchaseJournalInsertCommand, IList<JPurchaseJournal_Org_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JPurchaseJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JPurchaseJournal_Org_ID>> Handle( JPurchaseJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JPurchaseJournal_Org_ID> result = await _procedureAdabter
                .Execute<JPurchaseJournal_Org_ID>("[FINA].J_Purchase_JournalInsert", request);
           

            return result;
        }
    }
}
 
