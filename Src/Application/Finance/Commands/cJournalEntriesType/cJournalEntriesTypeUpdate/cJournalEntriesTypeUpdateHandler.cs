

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cJournalEntriesType.cJournalEntriesTypeUpdate.cJournalEntriesTypeUpdateCommand
{

    /// @author  Shimels Alem  c_Journal_Entries_TypeUpdate stored procedure.


    public class cJournalEntriesTypeUpdateHandler : IRequestHandler<cJournalEntriesTypeUpdateCommand, IList<CJournalEntriesType_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cJournalEntriesTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CJournalEntriesType_Type>> Handle( cJournalEntriesTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CJournalEntriesType_Type> result = await _procedureAdabter
                .Execute<CJournalEntriesType_Type>("[FINA].c_Journal_Entries_TypeUpdate", request);
           

            return result;
        }
    }
}
 