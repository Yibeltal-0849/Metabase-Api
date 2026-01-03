using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procPurchaseLine.procPurchaseLineDelete.procPurchaseLineDeleteCommand
{

    /// @author  Shimels Alem  proc_Purchase_LineDelete stored procedure.


    public class procPurchaseLineDeleteHandler : IRequestHandler<procPurchaseLineDeleteCommand, IList<PurchaseLine_PurchaseLineID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPurchaseLineDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PurchaseLine_PurchaseLineID>> Handle( procPurchaseLineDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<PurchaseLine_PurchaseLineID> result = await _procedureAdabter
                .Execute<PurchaseLine_PurchaseLineID>("[FINA].proc_Purchase_LineDelete", request);
           

            return result;
        }
    }
}
  