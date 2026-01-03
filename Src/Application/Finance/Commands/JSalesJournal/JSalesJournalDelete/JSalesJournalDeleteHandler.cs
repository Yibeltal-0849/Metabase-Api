using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JSalesJournalDelete.JSalesJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Sales_JournalDelete stored procedure.
	 
	 
      public class JSalesJournalDeleteHandler : IRequestHandler<JSalesJournalDeleteCommand, IList<JSalesJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JSalesJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JSalesJournal_Branch_ID>> Handle( JSalesJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JSalesJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JSalesJournal_Branch_ID>("[FINA].J_Sales_JournalDelete", request);
           

            return result;
        }
    }
}
 
