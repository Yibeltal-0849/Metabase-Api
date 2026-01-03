using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JRecurringGeneralJournalUpdate.JRecurringGeneralJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Recurring_General_JournalUpdate stored procedure.
	 
	 
      public class JRecurringGeneralJournalUpdateHandler : IRequestHandler<JRecurringGeneralJournalUpdateCommand, IList<JRecurringGeneralJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JRecurringGeneralJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JRecurringGeneralJournal_Branch_ID>> Handle( JRecurringGeneralJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JRecurringGeneralJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JRecurringGeneralJournal_Branch_ID>("[FINA].J_Recurring_General_JournalUpdate", request);
           

            return result;
        }
    }
}
 
