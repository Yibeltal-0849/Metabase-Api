using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Finance.Commands.procItemType.procItemTypeDelete.procItemTypeDeleteCommand
{

    /// @author  Shimels Alem  proc_ItemTypeDelete stored procedure.


    public class procItemTypeDeleteHandler : IRequestHandler<procItemTypeDeleteCommand, IList<ItemType_Name>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procItemTypeDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemType_Name>> Handle( procItemTypeDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ItemType_Name> result = await _procedureAdabter
                .Execute<ItemType_Name>("[FINA].proc_ItemTypeDelete", request);
           

            return result;
        }
    }
}
  