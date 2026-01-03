using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.PBlanketpurchaseorder.PBlanketpurchaseorderDelete.PBlanketpurchaseorderDeleteCommand
{

    /// @author  Shimels Alem  [P_Blanket purchase orderDelete] stored procedure.


    public class PBlanketpurchaseorderDeleteHandler : IRequestHandler<PBlanketpurchaseorderDeleteCommand, IList<PBlanketPurchaseOrder_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PBlanketpurchaseorderDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PBlanketPurchaseOrder_Purchase_Line>> Handle( PBlanketpurchaseorderDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PBlanketPurchaseOrder_Purchase_Line> result = await _procedureAdabter
                .Execute<PBlanketPurchaseOrder_Purchase_Line>("[FINA].[P_Blanket purchase orderDelete]", request);
           

            return result;
        }
    }
}
  