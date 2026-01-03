using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JPaymentJournalDelete.JPaymentJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Payment_JournalDelete stored procedure.
	 
	 
      public class JPaymentJournalDeleteHandler : IRequestHandler<JPaymentJournalDeleteCommand, IList<JPaymentJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JPaymentJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JPaymentJournal_Brnach_ID>> Handle( JPaymentJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JPaymentJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JPaymentJournal_Brnach_ID>("[FINA].J_Payment_JournalDelete", request);
           

            return result;
        }
    }
}
 
