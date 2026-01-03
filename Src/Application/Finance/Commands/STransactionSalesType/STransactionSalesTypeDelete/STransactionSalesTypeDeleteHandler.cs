using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.STransactionSalesType.STransactionSalesTypeDelete.STransactionSalesTypeDeleteCommand
{

    /// @author  Shimels Alem  [S_Transaction Sales_TypeDelete] stored procedure.


    public class STransactionSalesTypeDeleteHandler : IRequestHandler<STransactionSalesTypeDeleteCommand, IList<STransactionSalesType_Code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public STransactionSalesTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<STransactionSalesType_Code>> Handle( STransactionSalesTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<STransactionSalesType_Code> result = await _procedureAdabter
                .Execute<STransactionSalesType_Code>("[FINA].[S_Transaction Sales_TypeDelete]", request);
           

            return result;
        }
    }
}
  