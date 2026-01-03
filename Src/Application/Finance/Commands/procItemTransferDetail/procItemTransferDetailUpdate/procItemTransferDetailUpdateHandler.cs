

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procItemTransferDetail.procItemTransferDetailUpdate.procItemTransferDetailUpdateCommand
{

    /// @author  Shimels Alem  proc_Item_Transfer_DetailUpdate stored procedure.


    public class procItemTransferDetailUpdateHandler : IRequestHandler<procItemTransferDetailUpdateCommand, IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procItemTransferDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemTransferDetail_Transfer_Req_DetailID>> Handle( procItemTransferDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ItemTransferDetail_Transfer_Req_DetailID> result = await _procedureAdabter
                .Execute<ItemTransferDetail_Transfer_Req_DetailID>("[FINA].proc_Item_Transfer_DetailUpdate", request);
           

            return result;
        }
    }
}
 