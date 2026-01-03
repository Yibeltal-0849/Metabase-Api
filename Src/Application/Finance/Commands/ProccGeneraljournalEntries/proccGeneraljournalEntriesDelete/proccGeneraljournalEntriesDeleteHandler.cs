using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccGeneraljournalEntriesDelete.proccGeneraljournalEntriesDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_General_journal_Entries Delete stored procedure.
	 
	 
      public class proccGeneraljournalEntriesDeleteHandler : IRequestHandler<proccGeneraljournalEntriesDeleteCommand, IList<proccGeneraljournalEntries_org_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccGeneraljournalEntriesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<proccGeneraljournalEntries_org_ID>> Handle( proccGeneraljournalEntriesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<proccGeneraljournalEntries_org_ID> result = await _procedureAdabter
                .Execute<proccGeneraljournalEntries_org_ID>("[FINA].proc_c_General_journal_Entries Delete", request);
           

            return result;
        }
    }
}
 
