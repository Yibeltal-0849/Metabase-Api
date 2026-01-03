



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.PBlanketpurchaseorder.PBlanketpurchaseorderInsert.PBlanketpurchaseorderInsertCommand
{

    /// @author  Shimels Alem  [P_Blanket purchase orderInsert] stored procedure.


    public class PBlanketpurchaseorderInsertHandler : IRequestHandler<PBlanketpurchaseorderInsertCommand, IList<PBlanketPurchaseOrder_Purchase_Line>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public PBlanketpurchaseorderInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PBlanketPurchaseOrder_Purchase_Line>> Handle( PBlanketpurchaseorderInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PBlanketPurchaseOrder_Purchase_Line> result = await _procedureAdabter
                .Execute<PBlanketPurchaseOrder_Purchase_Line>("[FINA].[P_Blanket purchase orderInsert]", request);
           

            return result;
        }
    }
}
 