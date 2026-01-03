



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cCustomerBalance.cCustomerBalanceInsert.cCustomerBalanceInsertCommand
{

    /// @author  Shimels Alem  c_Customer_BalanceInsert stored procedure.


    public class cCustomerBalanceInsertHandler : IRequestHandler<cCustomerBalanceInsertCommand, IList<CCustomerBalance_Id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cCustomerBalanceInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CCustomerBalance_Id>> Handle( cCustomerBalanceInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CCustomerBalance_Id> result = await _procedureAdabter
                .Execute<CCustomerBalance_Id>("[FINA].c_Customer_BalanceInsert", request);
           

            return result;
        }
    }
}
 