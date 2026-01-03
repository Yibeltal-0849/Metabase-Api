using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cGeneraljournalEntries.cGeneraljournalEntriesDelete.cGeneraljournalEntriesDeleteCommand
{

    /// @author  Shimels Alem  c_General_journal_Entries Delete stored procedure.


    public class cGeneraljournalEntriesDeleteHandler : IRequestHandler<cGeneraljournalEntriesDeleteCommand, IList<CGeneralJournalEntries_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cGeneraljournalEntriesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CGeneralJournalEntries_Brnach_ID>> Handle( cGeneraljournalEntriesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CGeneralJournalEntries_Brnach_ID> result = await _procedureAdabter
                .Execute<CGeneralJournalEntries_Brnach_ID>("[FINA].c_General_journal_Entries Delete", request);
           

            return result;
        }
    }
}
  