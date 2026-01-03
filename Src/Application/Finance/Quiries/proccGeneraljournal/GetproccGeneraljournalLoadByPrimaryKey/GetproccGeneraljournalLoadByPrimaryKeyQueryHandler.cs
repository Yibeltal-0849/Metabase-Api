 

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using XOKA.Domain.Entities.Finance;
using Application.Finance.Quiries.proccGeneraljournal.GetproccGeneraljournalLoadAll;

namespace Application.Finance.Quiries.proccGeneraljournal.GetproccGeneraljournalLoadByPrimaryKey
{ 
	 
	#region proccGeneraljournalLoadByPrimaryKey  
    
    
    
      public class GetproccGeneraljournalLoadByPrimaryKeyQueryHandler : IRequestHandler<GetproccGeneraljournalLoadByPrimaryKey, GetproccGeneraljournalLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccGeneraljournalLoadByPrimaryKeyQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccGeneraljournalLoadAllListVM> Handle(GetproccGeneraljournalLoadByPrimaryKey request, CancellationToken cancellationToken)
        {
            IList< JGeneralJournal> proccGeneraljournalLoadByPrimaryKeys = await _procedureAdabter
               .Execute<JGeneralJournal>("[FINA].proc_c_General_journalLoadByPrimaryKey", request);
            GetproccGeneraljournalLoadAllListVM vm = new GetproccGeneraljournalLoadAllListVM
            {
                proccGeneraljournalLoadAlls = _mapper.Map<IList< JGeneralJournal >, IList<GetproccGeneraljournalLoadAllVM>>(proccGeneraljournalLoadByPrimaryKeys)
            };

            return vm;
        }
         #endregion
    }
    
    
    
		
	  
	
		
	
    
}

