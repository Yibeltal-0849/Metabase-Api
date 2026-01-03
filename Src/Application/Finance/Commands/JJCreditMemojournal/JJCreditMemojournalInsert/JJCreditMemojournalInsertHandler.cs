



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.JJCreditMemojournal.JJCreditMemojournalInsert.JJCreditMemojournalInsertCommand
{

    /// @author  Shimels Alem  JJ_Credit_Memo_journalInsert stored procedure.


    public class JJCreditMemojournalInsertHandler : IRequestHandler<JJCreditMemojournalInsertCommand, IList<JJCreditMemojournal_LineType>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJCreditMemojournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JJCreditMemojournal_LineType>> Handle( JJCreditMemojournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JJCreditMemojournal_LineType> result = await _procedureAdabter
                .Execute<JJCreditMemojournal_LineType>("[FINA].JJ_Credit_Memo_journalInsert", request);
           

            return result;
        }
    }
}
 