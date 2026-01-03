



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.PTransactionPurchaseType.PTransactionPurchaseTypeInsert.PTransactionPurchaseTypeInsertCommand
{

    /// @author  Shimels Alem  [P_Transaction Purchase TypeInsert] stored procedure.


    public class PTransactionPurchaseTypeInsertHandler : IRequestHandler<PTransactionPurchaseTypeInsertCommand, IList<PTransactionPurchaseType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PTransactionPurchaseTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PTransactionPurchaseType_Code>> Handle( PTransactionPurchaseTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PTransactionPurchaseType_Code> result = await _procedureAdabter
                .Execute<PTransactionPurchaseType_Code>("[FINA].[P_Transaction Purchase TypeInsert]", request);
           

            return result;
        }
    }
}
 