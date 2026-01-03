using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JJCreditMemojournal.JJCreditMemojournalDelete.JJCreditMemojournalDeleteCommand
{

    /// @author  Shimels Alem  JJ_Credit_Memo_journalInsert stored procedure.


    public class JJCreditMemojournalDeleteHandler : IRequestHandler<JJCreditMemojournalDeleteCommand, IList<JJCreditMemojournal_LineType>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJCreditMemojournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JJCreditMemojournal_LineType>> Handle( JJCreditMemojournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JJCreditMemojournal_LineType> result = await _procedureAdabter
                .Execute<JJCreditMemojournal_LineType>("[FINA].JJ_Credit_Memo_journalInsert", request);
           

            return result;
        }
    }
}
  