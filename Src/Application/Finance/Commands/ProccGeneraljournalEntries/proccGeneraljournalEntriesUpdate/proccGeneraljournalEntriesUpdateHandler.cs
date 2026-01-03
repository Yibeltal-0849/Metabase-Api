using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalEntriesUpdate.proccGeneraljournalEntriesUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journal_Entries Update stored procedure.
	 
	 
      public class proccGeneraljournalEntriesUpdateHandler : IRequestHandler<proccGeneraljournalEntriesUpdateCommand, IList<proccGeneraljournalEntries_org_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccGeneraljournalEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccGeneraljournalEntries_org_ID>> Handle( proccGeneraljournalEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<proccGeneraljournalEntries_org_ID> result = await _procedureAdabter
                .Execute<proccGeneraljournalEntries_org_ID>("[FINA].proc_c_General_journal_Entries Update", request);
           

            return result;
        }
    }
}
 
