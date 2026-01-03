using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procADOrgUpdate.procADOrgUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_AD_OrgUpdate stored procedure.
	 
	 
      public class procADOrgUpdateHandler : IRequestHandler<procADOrgUpdateCommand, IList<AdOrg_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procADOrgUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdOrg_Code>> Handle( procADOrgUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AdOrg_Code> result = await _procedureAdabter
                .Execute<AdOrg_Code>("[FINA].proc_AD_OrgUpdate", request);
           

            return result;
        }
    }
}
 
