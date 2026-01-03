

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.PBlanketpurchaseorder.PBlanketpurchaseorderUpdate.PBlanketpurchaseorderUpdateCommand
{

    /// @author  Shimels Alem  [P_Blanket purchase orderUpdate] stored procedure.


    public class PBlanketpurchaseorderUpdateHandler : IRequestHandler<PBlanketpurchaseorderUpdateCommand, IList<PBlanketPurchaseOrder_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PBlanketpurchaseorderUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PBlanketPurchaseOrder_Purchase_Line>> Handle( PBlanketpurchaseorderUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<PBlanketPurchaseOrder_Purchase_Line> result = await _procedureAdabter
                .Execute<PBlanketPurchaseOrder_Purchase_Line>("[FINA].[P_Blanket purchase orderUpdate]", request);
           

            return result;
        }
    }
}
 