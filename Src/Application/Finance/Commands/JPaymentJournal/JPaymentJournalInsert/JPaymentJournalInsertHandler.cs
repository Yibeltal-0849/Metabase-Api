using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPaymentJournalInsert.JPaymentJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Payment_JournalInsert stored procedure.
	 
	 
      public class JPaymentJournalInsertHandler : IRequestHandler<JPaymentJournalInsertCommand, IList<JPaymentJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JPaymentJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JPaymentJournal_Brnach_ID>> Handle( JPaymentJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JPaymentJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JPaymentJournal_Brnach_ID>("[FINA].J_Payment_JournalInsert", request);
           

            return result;
        }
    }
}
 
