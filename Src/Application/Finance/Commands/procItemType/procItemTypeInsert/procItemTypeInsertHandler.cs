



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.procItemType.procItemTypeInsert.procItemTypeInsertCommand
{

    /// @author  Shimels Alem  proc_ItemTypeInsert stored procedure.


    public class procItemTypeInsertHandler : IRequestHandler<procItemTypeInsertCommand, IList<ItemType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procItemTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemType_Name>> Handle( procItemTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemType_Name> result = await _procedureAdabter
                .Execute<ItemType_Name>("[FINA].proc_ItemTypeInsert", request);
           

            return result;
        }
    }
}
 