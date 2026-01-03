



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.JJReceiptjournal.JJReceiptjournalInsert.JJReceiptjournalInsertCommand
{

    /// @author  Shimels Alem  JJ_Receipt_journalInsert stored procedure.


    public class JJReceiptjournalInsertHandler : IRequestHandler<JJReceiptjournalInsertCommand, IList<JJReceiptjournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JJReceiptjournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JJReceiptjournal_Brnach_ID>> Handle( JJReceiptjournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JJReceiptjournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JJReceiptjournal_Brnach_ID>("[FINA].JJ_Receipt_journalInsert", request);
           

            return result;
        }
    }
}
 