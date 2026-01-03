



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.STransactionSalesType.STransactionSalesTypeInsert.STransactionSalesTypeInsertCommand
{

    /// @author  Shimels Alem  S_Transaction Sales_TypeInsert stored procedure.


    public class STransactionSalesTypeInsertHandler : IRequestHandler<STransactionSalesTypeInsertCommand, IList<STransactionSalesType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public STransactionSalesTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<STransactionSalesType_Code>> Handle( STransactionSalesTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<STransactionSalesType_Code> result = await _procedureAdabter
                .Execute<STransactionSalesType_Code>("[FINA].[S_Transaction Sales_TypeInsert]", request);
           

            return result;
        }
    }
}
 