

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccGeneraljournalEntries.GetproccGeneraljournalEntriesLoadAll
{ 
	 
	#region proccGeneraljournalEntriesLoadAll  
      public class GetproccGeneraljournalEntriesLoadAllQueryHandler : IRequestHandler<GetproccGeneraljournalEntriesLoadAllQuery, GetproccGeneraljournalEntriesLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccGeneraljournalEntriesLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccGeneraljournalEntriesLoadAllListVM> Handle(GetproccGeneraljournalEntriesLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<CGeneralJournalEntries> proccGeneraljournalEntriesLoadAlls = await _procedureAdabter
               .Execute<CGeneralJournalEntries>("[FINA].[proc_c_General_journal_Entries LoadAll]");
            GetproccGeneraljournalEntriesLoadAllListVM vm = new GetproccGeneraljournalEntriesLoadAllListVM
            {
                proccGeneraljournalEntriesLoadAlls = _mapper.Map<IList<CGeneralJournalEntries>, IList<GetproccGeneraljournalEntriesLoadAllVM>>(proccGeneraljournalEntriesLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

