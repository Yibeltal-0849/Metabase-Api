using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.JFixedAssetJournalDelete.JFixedAssetJournalDeleteCommand
{ 
	 
	 
	 
      public class JFixedAssetJournalDeleteHandler : IRequestHandler<JFixedAssetJournalDeleteCommand, IList<JFixedAssetJournal_Branch_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public JFixedAssetJournalDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

    public async Task<IList<JFixedAssetJournal_Branch_ID>> Handle( JFixedAssetJournalDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<JFixedAssetJournal_Branch_ID> result = await _procedureAdabter
                .Execute<JFixedAssetJournal_Branch_ID>("[FINA].J_Fixed_Asset_JournalDelete", request);
           

            return result;
        }
    }
}
 
