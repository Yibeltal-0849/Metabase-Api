

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cGeneraljournalEntries.cGeneraljournalEntriesUpdate.cGeneraljournalEntriesUpdateCommand
{

    /// @author  Shimels Alem  c_General_journal_Entries Update stored procedure.


    public class cGeneraljournalEntriesUpdateHandler : IRequestHandler<cGeneraljournalEntriesUpdateCommand, IList<CGeneralJournalEntries_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cGeneraljournalEntriesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CGeneralJournalEntries_Brnach_ID>> Handle( cGeneraljournalEntriesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CGeneralJournalEntries_Brnach_ID> result = await _procedureAdabter
                .Execute<CGeneralJournalEntries_Brnach_ID>("[FINA].c_General_journal_Entries Update", request);
           

            return result;
        }
    }
}
 