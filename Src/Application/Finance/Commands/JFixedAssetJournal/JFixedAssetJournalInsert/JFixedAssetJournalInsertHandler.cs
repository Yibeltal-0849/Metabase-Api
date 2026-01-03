using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JFixedAssetJournalInsert.JFixedAssetJournalInsertCommand
{ 
	 
	/// @author  Henok Solomon  J_Fixed_Asset_JournalInsert stored procedure.
	 
	 
      public class JFixedAssetJournalInsertHandler : IRequestHandler<JFixedAssetJournalInsertCommand, IList<JFixedAssetJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public JFixedAssetJournalInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<JFixedAssetJournal_Branch_ID>> Handle( JFixedAssetJournalInsertCommand request, CancellationToken cancellationToken)
        {

            IList<JFixedAssetJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JFixedAssetJournal_Branch_ID>("[FINA].J_Fixed_Asset_JournalInsert", request);
           

            return result;
        }
    }
}
 
