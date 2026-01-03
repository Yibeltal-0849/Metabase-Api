



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.CTransactionSales.CTransactionSalesInsert.CTransactionSalesInsertCommand
{

    /// @author  Shimels Alem  CTransaction_SalesInsert stored procedure.


    public class CTransactionSalesInsertHandler : IRequestHandler<CTransactionSalesInsertCommand, IList<CTransactionSales_No>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public CTransactionSalesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CTransactionSales_No>> Handle( CTransactionSalesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CTransactionSales_No> result = await _procedureAdabter
                .Execute<CTransactionSales_No>("[FINA].CTransaction_SalesInsert", request);
           

            return result;
        }
    }
}
 