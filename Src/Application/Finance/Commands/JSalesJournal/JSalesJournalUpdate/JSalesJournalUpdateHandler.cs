using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JSalesJournalUpdate.JSalesJournalUpdateCommand
{ 
 
      public class JSalesJournalUpdateHandler : IRequestHandler<JSalesJournalUpdateCommand, IList<JSalesJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JSalesJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JSalesJournal_Branch_ID>> Handle( JSalesJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JSalesJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JSalesJournal_Branch_ID>("[FINA].J_Sales_JournalUpdate", request);
           

            return result; 
        }
    }
}
 
