



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CJournalTypePosting.CJournalTypePostingInsert.CJournalTypePostingInsertCommand
{

    /// @author  Shimels Alem  C_Journal_Type_PostingInsert stored procedure.


    public class CJournalTypePostingInsertHandler : IRequestHandler<CJournalTypePostingInsertCommand, IList<CJournalTypePosting_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CJournalTypePostingInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CJournalTypePosting_Type>> Handle( CJournalTypePostingInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CJournalTypePosting_Type> result = await _procedureAdabter
                .Execute<CJournalTypePosting_Type>("[FINA].C_Journal_Type_PostingInsert", request);
           

            return result;
        }
    }
}
 