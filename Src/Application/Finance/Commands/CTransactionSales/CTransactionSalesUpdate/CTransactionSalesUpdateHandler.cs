

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.CTransactionSales.CTransactionSalesUpdate.CTransactionSalesUpdateCommand
{

    /// @author  Shimels Alem  CTransaction_SalesUpdate stored procedure.


    public class CTransactionSalesUpdateHandler : IRequestHandler<CTransactionSalesUpdateCommand, IList<CTransactionSales_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTransactionSalesUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTransactionSales_No>> Handle( CTransactionSalesUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CTransactionSales_No> result = await _procedureAdabter
                .Execute<CTransactionSales_No>("[FINA].CTransaction_SalesUpdate", request);
           

            return result;
        }
    }
}
 