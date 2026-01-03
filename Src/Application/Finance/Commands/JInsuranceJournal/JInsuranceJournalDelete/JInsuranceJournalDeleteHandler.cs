using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JInsuranceJournalDelete.JInsuranceJournalDeleteCommand
{ 
	 
	/// @author  Henok Solomon  J_Insurance_JournalDelete stored procedure.
	 
	 
      public class JInsuranceJournalDeleteHandler : IRequestHandler<JInsuranceJournalDeleteCommand, IList<JInsuranceJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter; 
       public JInsuranceJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JInsuranceJournal_Branch_ID>> Handle( JInsuranceJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JInsuranceJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JInsuranceJournal_Branch_ID>("[FINA].J_Insurance_JournalDelete", request);
           

            return result;
        }
    }
}
 
