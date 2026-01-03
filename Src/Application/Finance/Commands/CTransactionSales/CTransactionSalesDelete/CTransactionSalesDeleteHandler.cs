using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.CTransactionSales.CTransactionSalesDelete.CTransactionSalesDeleteCommand
{

    /// @author  Shimels Alem  CTransaction_SalesDelete stored procedure.


    public class CTransactionSalesDeleteHandler : IRequestHandler<CTransactionSalesDeleteCommand, IList<CTransactionSales_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTransactionSalesDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTransactionSales_No>> Handle( CTransactionSalesDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<CTransactionSales_No> result = await _procedureAdabter
                .Execute<CTransactionSales_No>("[FINA].CTransaction_SalesDelete", request);
           

            return result;
        }
    }
}
  