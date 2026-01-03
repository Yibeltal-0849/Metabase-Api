



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procPurchaseLine.procPurchaseLineInsert.procPurchaseLineInsertCommand
{

    /// @author  Shimels Alem  proc_Purchase_LineInsert stored procedure.


    public class procPurchaseLineInsertHandler : IRequestHandler<procPurchaseLineInsertCommand, IList<PurchaseLine_PurchaseLineID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procPurchaseLineInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<PurchaseLine_PurchaseLineID>> Handle( procPurchaseLineInsertCommand request, CancellationToken cancellationToken)
        {

            IList<PurchaseLine_PurchaseLineID> result = await _procedureAdabter
                .Execute<PurchaseLine_PurchaseLineID>("[FINA].proc_Purchase_LineInsert", request);
           

            return result;
        }
    }
}
 