



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.Store.StoreInsert.StoreInsertCommand
{

    /// @author  Shimels Alem  StoreInsert stored procedure.


    public class StoreInsertHandler : IRequestHandler<StoreInsertCommand, IList<_Store_Store_code>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public StoreInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<_Store_Store_code>> Handle( StoreInsertCommand request, CancellationToken cancellationToken)
        {

            IList<_Store_Store_code> result = await _procedureAdabter
                .Execute<_Store_Store_code>("[Inventory].StoreInsert", request);
           

            return result;
        }
    }
}
 