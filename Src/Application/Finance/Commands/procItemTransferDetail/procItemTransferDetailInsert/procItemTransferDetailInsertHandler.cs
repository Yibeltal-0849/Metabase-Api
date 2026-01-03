



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procItemTransferDetail.procItemTransferDetailInsert.procItemTransferDetailInsertCommand
{

    /// @author  Shimels Alem  proc_Item_Transfer_DetailInsert stored procedure.


    public class procItemTransferDetailInsertHandler : IRequestHandler<procItemTransferDetailInsertCommand, IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procItemTransferDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemTransferDetail_Transfer_Req_DetailID>> Handle( procItemTransferDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemTransferDetail_Transfer_Req_DetailID> result = await _procedureAdabter
                .Execute<ItemTransferDetail_Transfer_Req_DetailID>("[FINA].proc_Item_Transfer_DetailInsert", request);
           

            return result;
        }
    }
}
 