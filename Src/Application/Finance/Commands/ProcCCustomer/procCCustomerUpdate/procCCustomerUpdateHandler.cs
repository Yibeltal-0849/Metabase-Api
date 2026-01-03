using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCCustomerUpdate.procCCustomerUpdateCommand
{ 
	 
	/// @author  Henok Solomon  proc_C_CustomerUpdate stored procedure.
	 
	 
      public class procCCustomerUpdateHandler : IRequestHandler<procCCustomerUpdateCommand, IList<CCustomer_Customer_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCCustomerUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCustomer_Customer_ID>> Handle( procCCustomerUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CCustomer_Customer_ID> result = await _procedureAdabter
                .Execute<CCustomer_Customer_ID>("[FINA].proc_C_CustomerUpdate", request);
           

            return result;
        }
    }
}
 
