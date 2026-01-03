

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CJournalTypePosting.CJournalTypePostingUpdate.CJournalTypePostingUpdateCommand
{

    /// @author  Shimels Alem  C_Journal_Type_PostingUpdate stored procedure.


    public class CJournalTypePostingUpdateHandler : IRequestHandler<CJournalTypePostingUpdateCommand, IList<CJournalTypePosting_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CJournalTypePostingUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CJournalTypePosting_Type>> Handle( CJournalTypePostingUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CJournalTypePosting_Type> result = await _procedureAdabter
                .Execute<CJournalTypePosting_Type>("[FINA].C_Journal_Type_PostingUpdate", request);
           

            return result;
        }
    }
}
 