using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procGeneralPostingSetupsDelete.procGeneralPostingSetupsDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_General Posting SetupsDelete stored procedure.
	 
	 
      public class procGeneralPostingSetupsDeleteHandler : IRequestHandler<procGeneralPostingSetupsDeleteCommand, IList<procGeneralPostingSetups_gen_Bus_Posting_Group>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procGeneralPostingSetupsDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procGeneralPostingSetups_gen_Bus_Posting_Group>> Handle( procGeneralPostingSetupsDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<procGeneralPostingSetups_gen_Bus_Posting_Group> result = await _procedureAdabter
                .Execute<procGeneralPostingSetups_gen_Bus_Posting_Group>("[FINA].proc_General Posting SetupsDelete", request);
           

            return result;
        }
    }
}
 
