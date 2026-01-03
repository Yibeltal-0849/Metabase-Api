using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procAdAccountingMethodDelete.procAdAccountingMethodDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_Ad_Accounting_MethodDelete stored procedure.
	 
	 
      public class procAdAccountingMethodDeleteHandler : IRequestHandler<procAdAccountingMethodDeleteCommand, IList<AdAccountingMethod_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdAccountingMethodDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdAccountingMethod_Id>> Handle( procAdAccountingMethodDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<AdAccountingMethod_Id> result = await _procedureAdabter
                .Execute<AdAccountingMethod_Id>("[FINA].proc_Ad_Accounting_MethodDelete", request);
           

            return result;
        }
    }
}
 
