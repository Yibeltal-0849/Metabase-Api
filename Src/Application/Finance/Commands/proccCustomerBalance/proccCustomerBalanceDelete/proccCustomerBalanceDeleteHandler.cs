using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.proccCustomerBalanceDelete.proccCustomerBalanceDeleteCommand
{ 
	 
	/// @author  Henok Solomon  proc_c_Customer_BalanceDelete stored procedure.
	 
	 
      public class proccCustomerBalanceDeleteHandler : IRequestHandler<proccCustomerBalanceDeleteCommand, IList<CCustomerBalance_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proccCustomerBalanceDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCustomerBalance_Id>> Handle( proccCustomerBalanceDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CCustomerBalance_Id> result = await _procedureAdabter
                .Execute<CCustomerBalance_Id>("[FINA].proc_c_Customer_BalanceDelete", request);
           

            return result;
        }
    }
}
 
