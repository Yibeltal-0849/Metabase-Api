using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JBOMJournal.JBOMJournalDelete.JBOMJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_JOB_JournalDelete stored procedure.
	 
	 
      public class JBOMJournalDeleteHandler : IRequestHandler<JBOMJournalDeleteCommand, IList<JBomJournal_PostingDate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JBOMJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JBomJournal_PostingDate>> Handle( JBOMJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JBomJournal_PostingDate> result = await _procedureAdabter
                .Execute<JBomJournal_PostingDate>("[FINA].J_BOM_JournalDelete", request);
           

            return result;
        }
    }
}
 
