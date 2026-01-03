using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemJournalDelete.JItemJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_JournalDelete stored procedure.
	 
	 
      public class JItemJournalDeleteHandler : IRequestHandler<JItemJournalDeleteCommand, IList<JItemJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JItemJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JItemJournal_Branch_ID>> Handle( JItemJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JItemJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JItemJournal_Branch_ID>("[FINA].J_Item_JournalDelete", request);
           

            return result;
        }
    }
}
 
