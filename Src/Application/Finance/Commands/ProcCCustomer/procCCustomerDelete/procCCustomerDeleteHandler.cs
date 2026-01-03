using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCCustomerDelete.procCCustomerDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_C_CustomerDelete stored procedure.
	 
	 
      public class procCCustomerDeleteHandler : IRequestHandler<procCCustomerDeleteCommand, IList<CCustomer_Customer_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCCustomerDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCustomer_Customer_ID>> Handle( procCCustomerDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CCustomer_Customer_ID> result = await _procedureAdabter
                .Execute<CCustomer_Customer_ID>("[FINA].proc_C_CustomerDelete", request);
           

            return result;
        }
    }
}
 
