

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.JCashReceiptJournal.JCashReceiptJournalUpdate.JCashReceiptJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationUpdate stored procedure.
	 
	 
      public class JCashReceiptJournalUpdateHandler : IRequestHandler<JCashReceiptJournalUpdateCommand, IList<JCashReceiptJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JCashReceiptJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JCashReceiptJournal_Branch_ID>> Handle( JCashReceiptJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JCashReceiptJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JCashReceiptJournal_Branch_ID>("[FINA].J_Cash_Receipt_JournalUpdate", request);
           

            return result;
        }
    }
}
 