using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCostMethod.procCostMethodCommand
{ 
	 
	/// @author  Henok Solomon  proc_CostMethod stored procedure.
	 
	 
      public class procCostMethodHandler : IRequestHandler<procCostMethodCommand, IList<procCostMethod_store_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCostMethodHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<procCostMethod_store_Code>> Handle( procCostMethodCommand request, CancellationToken cancellationToken)
        {

            IList<procCostMethod_store_Code> result = await _procedureAdabter
                .Execute<procCostMethod_store_Code>("[FINA].proc_CostMethod", request);
           

            return result;
        }
    }
}
 
