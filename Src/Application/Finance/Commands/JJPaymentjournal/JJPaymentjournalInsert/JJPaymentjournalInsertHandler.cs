



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.JJPaymentjournal.JJPaymentjournalInsert.JJPaymentjournalInsertCommand
{

    /// @author  Shimels Alem  JJ_Payment_journalInsert stored procedure.


    public class JJPaymentjournalInsertHandler : IRequestHandler<JJPaymentjournalInsertCommand, IList<JPaymentJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJPaymentjournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JPaymentJournal_Brnach_ID>> Handle( JJPaymentjournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JPaymentJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JPaymentJournal_Brnach_ID>("[FINA].JJ_Payment_journalInsert", request);
           

            return result;
        }
    }
}
 