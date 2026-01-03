using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JItemReclassJournalDelete.JItemReclassJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Item_Reclass_JournalDelete stored procedure.
	 
	 
      public class JItemReclassJournalDeleteHandler : IRequestHandler<JItemReclassJournalDeleteCommand, IList<JItemReclassJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JItemReclassJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JItemReclassJournal_Branch_ID>> Handle( JItemReclassJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JItemReclassJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JItemReclassJournal_Branch_ID>("[FINA].J_Item_Reclass_JournalDelete", request);
           

            return result;
        }
    }
}
 
