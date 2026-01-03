

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.JBOMJournal.JBOMJournalUpdate.JBOMJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_BOM_JournalUpdate stored procedure.
	 
	 
      public class JBOMJournalUpdateHandler : IRequestHandler<JBOMJournalUpdateCommand, IList<JBomJournal_PostingDate>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JBOMJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JBomJournal_PostingDate>> Handle( JBOMJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JBomJournal_PostingDate> result = await _procedureAdabter
                .Execute<JBomJournal_PostingDate>("[FINA].J_BOM_JournalUpdate", request);
           

            return result;
        }
    }
}
 
