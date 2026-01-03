

using AutoMapper;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Finance.Quiries.proccGeneraljournal.GetproccGeneraljournalLoadAll;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Quiries.proccGeneraljournal.GetproccGeneraljournalLoadAll
{ 
	 
	#region proccGeneraljournalLoadAll  
      public class GetproccGeneraljournalLoadAllQueryHandler : IRequestHandler<GetproccGeneraljournalLoadAllQuery, GetproccGeneraljournalLoadAllListVM>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproccGeneraljournalLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproccGeneraljournalLoadAllListVM> Handle(GetproccGeneraljournalLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<JGeneralJournal> proccGeneraljournalLoadAlls = await _procedureAdabter
               .Execute<JGeneralJournal>("[FINA].proc_c_General_journalLoadAll");
            GetproccGeneraljournalLoadAllListVM vm = new GetproccGeneraljournalLoadAllListVM
            {
                proccGeneraljournalLoadAlls = _mapper.Map<IList<JGeneralJournal>, IList<GetproccGeneraljournalLoadAllVM>>(proccGeneraljournalLoadAlls)
            };

            return vm;
        }
    }

        #endregion
		
	  
	
		
	
    
}

