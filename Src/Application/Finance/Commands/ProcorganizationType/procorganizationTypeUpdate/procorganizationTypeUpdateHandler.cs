using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procorganizationTypeUpdate.procorganizationTypeUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_organization_TypeUpdate stored procedure.
	 
	 
      public class procorganizationTypeUpdateHandler : IRequestHandler<procorganizationTypeUpdateCommand, IList<procorganizationType_organization_Type_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procorganizationTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procorganizationType_organization_Type_Code>> Handle( procorganizationTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<procorganizationType_organization_Type_Code> result = await _procedureAdabter
                .Execute<procorganizationType_organization_Type_Code>("[FINA].proc_organization_TypeUpdate", request);
           

            return result;
        }
    }
}
 
