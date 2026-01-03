using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.cJournalEntriesType.cJournalEntriesTypeDelete.cJournalEntriesTypeDeleteCommand
{

    /// @author  Shimels Alem  c_Journal_Entries_TypeDelete stored procedure.


    public class cJournalEntriesTypeDeleteHandler : IRequestHandler<cJournalEntriesTypeDeleteCommand, IList<CJournalEntriesType_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cJournalEntriesTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CJournalEntriesType_Type>> Handle( cJournalEntriesTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CJournalEntriesType_Type> result = await _procedureAdabter
                .Execute<CJournalEntriesType_Type>("[FINA].c_Journal_Entries_TypeDelete", request);
           

            return result;
        }
    }
}
  