using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJOBJournalUpdate.JJOBJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_JOB_JournalUpdate stored procedure.
	 
	 
      public class JJOBJournalUpdateHandler : IRequestHandler<JJOBJournalUpdateCommand, IList<JJobJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJOBJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JJobJournal_Branch_ID>> Handle( JJOBJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JJobJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JJobJournal_Branch_ID>("[FINA].J_JOB_JournalUpdate", request);
           

            return result;
        }
    }
}
 
