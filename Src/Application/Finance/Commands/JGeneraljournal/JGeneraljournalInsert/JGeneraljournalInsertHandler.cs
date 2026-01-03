



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.JGeneraljournalInsert.JGeneraljournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Bank_Acc_ReconciliationInsert stored procedure.
	 
	 
      public class JGeneraljournalInsertHandler : IRequestHandler<JGeneraljournalInsertCommand, IList<JGeneralJournal_Brnach_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JGeneraljournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JGeneralJournal_Brnach_ID>> Handle( JGeneraljournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JGeneralJournal_Brnach_ID> result = await _procedureAdabter
                .Execute<JGeneralJournal_Brnach_ID>("[FINA].J_General_journalInsert", request);
           

            return result;
        }
    }
}
 