using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPurchaseJournalDelete.JPurchaseJournalDeleteCommand
{ 
	 
	 
      public class JPurchaseJournalDeleteHandler : IRequestHandler<JPurchaseJournalDeleteCommand, IList<JPurchaseJournal_Org_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JPurchaseJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JPurchaseJournal_Org_ID>> Handle( JPurchaseJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JPurchaseJournal_Org_ID> result = await _procedureAdabter
                .Execute<JPurchaseJournal_Org_ID>("[FINA].J_Purchase_JournalDelete", request);
           

            return result;
        }
    }
}
 
