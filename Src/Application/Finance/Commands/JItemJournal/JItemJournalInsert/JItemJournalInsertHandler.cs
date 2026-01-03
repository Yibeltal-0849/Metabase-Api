using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemJournalInsert.JItemJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_JournalInsert stored procedure.
	 
	 
      public class JItemJournalInsertHandler : IRequestHandler<JItemJournalInsertCommand, IList<JItemJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JItemJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JItemJournal_Branch_ID>> Handle( JItemJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JItemJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JItemJournal_Branch_ID>("[FINA].J_Item_JournalInsert", request);
           

            return result;
        }
    }
}
 
