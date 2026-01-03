



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CJournalType.CJournalTypeInsert.CJournalTypeInsertCommand
{

    /// @author  Shimels Alem  C_Journal_TypeInsert stored procedure.


    public class CJournalTypeInsertHandler : IRequestHandler<CJournalTypeInsertCommand, IList<CJournalType_Type>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CJournalTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CJournalType_Type>> Handle( CJournalTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CJournalType_Type> result = await _procedureAdabter
                .Execute<CJournalType_Type>("[FINA].C_Journal_TypeInsert", request);
           

            return result;
        }
    }
}
 