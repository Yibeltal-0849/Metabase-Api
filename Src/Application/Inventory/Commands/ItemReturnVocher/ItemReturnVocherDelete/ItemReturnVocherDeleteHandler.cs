using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;

namespace Application.Inventory.Commands.ItemReturnVocher.ItemReturnVocherDelete.ItemReturnVocherDeleteCommand
{

    /// @author  Shimels Alem  Item_Return_VocherDelete stored procedure.


    public class ItemReturnVocherDeleteHandler : IRequestHandler<ItemReturnVocherDeleteCommand, IList<ItemReturnVocher_Requsition_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemReturnVocherDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemReturnVocher_Requsition_ID>> Handle( ItemReturnVocherDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ItemReturnVocher_Requsition_ID> result = await _procedureAdabter
                .Execute<ItemReturnVocher_Requsition_ID>("[Inventory].Item_Return_VocherDelete", request);
           
            return result;
        }
    }
}
  