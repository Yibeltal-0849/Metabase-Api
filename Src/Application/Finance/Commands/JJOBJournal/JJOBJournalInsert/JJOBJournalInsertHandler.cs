using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJOBJournalInsert.JJOBJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_JOB_JournalInsert stored procedure.
	 
	 
      public class JJOBJournalInsertHandler : IRequestHandler<JJOBJournalInsertCommand, IList<JJobJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJOBJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JJobJournal_Branch_ID>> Handle( JJOBJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JJobJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JJobJournal_Branch_ID>("[FINA].J_JOB_JournalInsert", request);
           

            return result;
        }
    }
}
 
