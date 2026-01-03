using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procItemTransferDetail.procItemTransferDetailDelete.procItemTransferDetailDeleteCommand
{

    /// @author  Shimels Alem  proc_Item_Transfer_DetailDelete stored procedure.


    public class procItemTransferDetailDeleteHandler : IRequestHandler<procItemTransferDetailDeleteCommand, IList<ItemTransferDetail_Transfer_Req_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procItemTransferDetailDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemTransferDetail_Transfer_Req_DetailID>> Handle( procItemTransferDetailDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ItemTransferDetail_Transfer_Req_DetailID> result = await _procedureAdabter
                .Execute<ItemTransferDetail_Transfer_Req_DetailID>("[FINA].proc_Item_Transfer_DetailDelete", request);
           

            return result;
        }
    }
}
  