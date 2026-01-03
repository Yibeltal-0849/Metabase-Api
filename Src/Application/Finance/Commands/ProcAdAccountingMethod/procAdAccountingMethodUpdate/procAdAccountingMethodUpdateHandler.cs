using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdAccountingMethodUpdate.procAdAccountingMethodUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Accounting_MethodUpdate stored procedure.
	 
	 
      public class procAdAccountingMethodUpdateHandler : IRequestHandler<procAdAccountingMethodUpdateCommand, IList<AdAccountingMethod_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdAccountingMethodUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdAccountingMethod_Id>> Handle( procAdAccountingMethodUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AdAccountingMethod_Id> result = await _procedureAdabter
                .Execute<AdAccountingMethod_Id>("[FINA].proc_Ad_Accounting_MethodUpdate", request);
           

            return result;
        }
    }
}
 
