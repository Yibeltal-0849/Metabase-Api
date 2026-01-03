using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JGeneraljournalUpdate.JGeneraljournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_General_journalUpdate stored procedure.
	 
	 
      public class JGeneraljournalUpdateHandler : IRequestHandler<JGeneraljournalUpdateCommand, IList<JGeneralJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JGeneraljournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JGeneralJournal_Brnach_ID>> Handle( JGeneraljournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JGeneralJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JGeneralJournal_Brnach_ID>("[FINA].J_General_journalUpdate", request);
           

            return result;
        }
    }
}
 
