using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procADOrgDelete.procADOrgDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_AD_OrgDelete stored procedure.
	 
	 
      public class procADOrgDeleteHandler : IRequestHandler<procADOrgDeleteCommand, IList<AdOrg_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procADOrgDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdOrg_Code>> Handle( procADOrgDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<AdOrg_Code> result = await _procedureAdabter
                .Execute<AdOrg_Code>("[FINA].proc_AD_OrgDelete", request);
           

            return result;
        }
    }
}
 
