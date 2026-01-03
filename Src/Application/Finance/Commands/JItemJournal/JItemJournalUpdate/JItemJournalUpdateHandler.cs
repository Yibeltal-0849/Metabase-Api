

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.JItemJournalUpdate.JItemJournalUpdateCommand
{

    /// @author  Henok Solomon  J_Item_JournalUpdate stored procedure.


    public class JItemJournalUpdateHandler : IRequestHandler<JItemJournalUpdateCommand, IList<JItemJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JItemJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JItemJournal_Branch_ID>> Handle( JItemJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JItemJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JItemJournal_Branch_ID>("[FINA].J_Item_JournalUpdate", request);
           

            return result;
        }
    }
}
 