using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JGeneraljournalDelete.JGeneraljournalDeleteCommand
{ 
	 
	 
	 
      public class JGeneraljournalDeleteHandler : IRequestHandler<JGeneraljournalDeleteCommand, IList<JGeneralJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JGeneraljournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JGeneralJournal_Brnach_ID>> Handle( JGeneraljournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JGeneralJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JGeneralJournal_Brnach_ID>("[FINA].J_General_journalDelete", request);
           

            return result;
        }
    }
}
 
