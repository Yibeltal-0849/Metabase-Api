using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAccountProposeDelete.procAccountProposeDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Account_ProposeDelete stored procedure.
	 
	 
      public class procAccountProposeDeleteHandler : IRequestHandler<procAccountProposeDeleteCommand, IList<AccountPropose_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAccountProposeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AccountPropose_Name>> Handle( procAccountProposeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<AccountPropose_Name> result = await _procedureAdabter
                .Execute<AccountPropose_Name>("[FINA].proc_Account_ProposeDelete", request);
           

            return result;
        }
    }
}
 
