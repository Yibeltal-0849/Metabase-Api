using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemReclassJournalInsert.JItemReclassJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_Reclass_JournalInsert stored procedure.
	 
	 
      public class JItemReclassJournalInsertHandler : IRequestHandler<JItemReclassJournalInsertCommand, IList<JItemReclassJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JItemReclassJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JItemReclassJournal_Branch_ID>> Handle( JItemReclassJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JItemReclassJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JItemReclassJournal_Branch_ID>("[FINA].J_Item_Reclass_JournalInsert", request);
           

            return result;
        }
    }
}
 
