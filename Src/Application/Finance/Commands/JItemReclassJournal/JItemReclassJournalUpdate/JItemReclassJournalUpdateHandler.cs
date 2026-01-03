using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemReclassJournalUpdate.JItemReclassJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_Reclass_JournalUpdate stored procedure.
	 
	 
      public class JItemReclassJournalUpdateHandler : IRequestHandler<JItemReclassJournalUpdateCommand, IList<JItemReclassJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JItemReclassJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JItemReclassJournal_Branch_ID>> Handle( JItemReclassJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JItemReclassJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JItemReclassJournal_Branch_ID>("[FINA].J_Item_Reclass_JournalUpdate", request);
           

            return result;
        }
    }
}
 
