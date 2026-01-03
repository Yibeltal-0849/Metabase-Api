using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJOBJournalDelete.JJOBJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_JOB_JournalDelete stored procedure.
	 
	 
      public class JJOBJournalDeleteHandler : IRequestHandler<JJOBJournalDeleteCommand, IList<JJobJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJOBJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JJobJournal_Branch_ID>> Handle( JJOBJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JJobJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JJobJournal_Branch_ID>("[FINA].J_JOB_JournalDelete", request);
           

            return result;
        }
    }
}
 
