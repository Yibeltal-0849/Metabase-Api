using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPurchaseJournalUpdate.JPurchaseJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Purchase_JournalUpdate stored procedure.
	 
	 
      public class JPurchaseJournalUpdateHandler : IRequestHandler<JPurchaseJournalUpdateCommand, IList<JPurchaseJournal_Org_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JPurchaseJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JPurchaseJournal_Org_ID>> Handle( JPurchaseJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JPurchaseJournal_Org_ID> result = await _procedureAdabter
                .Execute<JPurchaseJournal_Org_ID>("[FINA].J_Purchase_JournalUpdate", request);
           

            return result;
        }
    }
}
 
