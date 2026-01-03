using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JFixedAssetJournalUpdate.JFixedAssetJournalUpdateCommand
{ 
	 
	/// @author  Henok Solomon  J_Fixed_Asset_JournalUpdate stored procedure.
	 
	 
      public class JFixedAssetJournalUpdateHandler : IRequestHandler<JFixedAssetJournalUpdateCommand, IList<JFixedAssetJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JFixedAssetJournalUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JFixedAssetJournal_Branch_ID>> Handle( JFixedAssetJournalUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<JFixedAssetJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JFixedAssetJournal_Branch_ID>("[FINA].J_Fixed_Asset_JournalUpdate", request);
           

            return result;
        }
    }
}
 
