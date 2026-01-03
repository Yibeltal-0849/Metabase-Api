 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.proccGeneraljournalEntries.GetproccGeneraljournalEntriesLoadAll;
using Application.Finance.Quiries.proccGeneraljournalEntries.GetprocGeneraljournalEntriesLoadByPrimaryKey;

namespace Application.Finance.Quiries.proccGeneraljournalEntries.GetprocGeneraljournalEntriesLoadByPrimaryKey
{ 
	 
	#region proccGeneraljournalEntriesLoadByPrimaryKey  
    
    
    
      public class GetproccGeneraljournalEntriesLoadByPrimaryKeyQueryHandler : IRequestHandler<GetproccGeneraljournalEntriesLoadByPrimaryKey, GetproccGeneraljournalEntriesLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccGeneraljournalEntriesLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccGeneraljournalEntriesLoadAllListVM> Handle(GetproccGeneraljournalEntriesLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList< CGeneralJournalEntries> proccGeneraljournalEntriesLoadByPrimaryKeys = await _procedureAdabter
               .Execute<CGeneralJournalEntries>("[FINA].[proc_c_General_journal_Entries LoadByPrimaryKey]", request);
            GetproccGeneraljournalEntriesLoadAllListVM vm = new GetproccGeneraljournalEntriesLoadAllListVM
            {
                proccGeneraljournalEntriesLoadAlls = _mapper.Map<IList<CGeneralJournalEntries>, IList<GetproccGeneraljournalEntriesLoadAllVM>>(proccGeneraljournalEntriesLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

