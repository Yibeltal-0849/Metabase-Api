



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.JCashReceiptJournal.JCashReceiptJournalInsert.JCashReceiptJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationInsert stored procedure.
	 
	 
      public class JCashReceiptJournalInsertHandler : IRequestHandler<JCashReceiptJournalInsertCommand, IList<JCashReceiptJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JCashReceiptJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JCashReceiptJournal_Branch_ID>> Handle( JCashReceiptJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JCashReceiptJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JCashReceiptJournal_Branch_ID>("[FINA].J_Cash_Receipt_JournalInsert", request);
           

            return result;
        }
    }
}
 