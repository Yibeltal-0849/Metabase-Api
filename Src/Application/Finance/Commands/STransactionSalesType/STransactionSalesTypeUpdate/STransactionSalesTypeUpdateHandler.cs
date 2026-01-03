

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.STransactionSalesType.STransactionSalesTypeUpdate.STransactionSalesTypeUpdateCommand
{

    /// @author  Shimels Alem  [S_Transaction Sales_TypeUpdate] stored procedure.


    public class STransactionSalesTypeUpdateHandler : IRequestHandler<STransactionSalesTypeUpdateCommand, IList<STransactionSalesType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public STransactionSalesTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<STransactionSalesType_Code>> Handle( STransactionSalesTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<STransactionSalesType_Code> result = await _procedureAdabter
                .Execute<STransactionSalesType_Code>("[FINA].[S_Transaction Sales_TypeUpdate]", request);
           

            return result;
        }
    }
}
 