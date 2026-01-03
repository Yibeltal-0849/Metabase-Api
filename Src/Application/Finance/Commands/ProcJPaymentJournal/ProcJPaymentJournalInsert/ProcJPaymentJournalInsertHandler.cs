using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procJPaymentJournalInsert.procJPaymentJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  Proc_J_Payment_Journal_Insert  stored procedure.
	 
	 
      public class ProcJPaymentJournalInsertHandler : IRequestHandler<ProcJPaymentJournalInsertCommand, IList<procJPaymentJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ProcJPaymentJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procJPaymentJournal_Brnach_ID>> Handle( ProcJPaymentJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<procJPaymentJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<procJPaymentJournal_Brnach_ID>("[FINA].proc_J_Payment_Journal_Insert ", request);
           

            return result;
        }
    }
}
 
