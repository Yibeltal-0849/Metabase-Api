using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JRecurringGeneralJournalInsert.JRecurringGeneralJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Recurring_General_JournalInsert stored procedure.
	 
	 
      public class JRecurringGeneralJournalInsertHandler : IRequestHandler<JRecurringGeneralJournalInsertCommand, IList<JRecurringGeneralJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JRecurringGeneralJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JRecurringGeneralJournal_Branch_ID>> Handle( JRecurringGeneralJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JRecurringGeneralJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JRecurringGeneralJournal_Branch_ID>("[FINA].J_Recurring_General_JournalInsert", request);
           

            return result;
        }
    }
}
 
