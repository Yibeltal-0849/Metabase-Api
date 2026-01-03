using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JInsuranceJournalUpdate.JInsuranceJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Insurance_JournalUpdate stored procedure.
	 
	 
      public class JInsuranceJournalUpdateHandler : IRequestHandler<JInsuranceJournalUpdateCommand, IList<JInsuranceJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JInsuranceJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JInsuranceJournal_Branch_ID>> Handle( JInsuranceJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JInsuranceJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JInsuranceJournal_Branch_ID>("[FINA].J_Insurance_JournalUpdate", request);
           

            return result;
        }
    }
}
 
