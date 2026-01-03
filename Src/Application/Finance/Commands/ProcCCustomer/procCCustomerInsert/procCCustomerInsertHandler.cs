using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procCCustomerInsert.procCCustomerInsertCommand
{ 
	 
	/// @author  Henok Solomon  proc_C_CustomerInsert stored procedure.
	 
	 
      public class procCCustomerInsertHandler : IRequestHandler<procCCustomerInsertCommand, IList<CCustomer_Customer_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procCCustomerInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCustomer_Customer_ID>> Handle( procCCustomerInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CCustomer_Customer_ID> result = await _procedureAdabter
                .Execute<CCustomer_Customer_ID>("[FINA].proc_C_CustomerInsert", request);
           

            return result;
        }
    }
}
 
