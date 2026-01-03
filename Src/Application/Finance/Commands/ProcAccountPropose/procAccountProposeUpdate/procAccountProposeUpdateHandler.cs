using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAccountProposeUpdate.procAccountProposeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Account_ProposeUpdate stored procedure.
	 
	 
      public class procAccountProposeUpdateHandler : IRequestHandler<procAccountProposeUpdateCommand, IList<AccountPropose_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAccountProposeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AccountPropose_Name>> Handle( procAccountProposeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AccountPropose_Name> result = await _procedureAdabter
                .Execute<AccountPropose_Name>("[FINA].proc_Account_ProposeUpdate", request);
           

            return result;
        }
    }
}
 
