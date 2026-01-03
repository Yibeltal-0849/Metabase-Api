

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.procItemType.procItemTypeUpdate.procItemTypeUpdateCommand
{

    /// @author  Shimels Alem  proc_ItemTypeUpdate stored procedure.


    public class procItemTypeUpdateHandler : IRequestHandler<procItemTypeUpdateCommand, IList<ItemType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procItemTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemType_Name>> Handle( procItemTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ItemType_Name> result = await _procedureAdabter
                .Execute<ItemType_Name>("[FINA].proc_ItemTypeUpdate", request);
           

            return result;
        }
    }
}
 