

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;



namespace Application.Inventory.Commands.ItemReturnVocher.ItemReturnVocherUpdate.ItemReturnVocherUpdateCommand
{

    /// @author  Shimels Alem  Item_Return_VocherUpdate stored procedure.


    public class ItemReturnVocherUpdateHandler : IRequestHandler<ItemReturnVocherUpdateCommand, IList<ItemReturnVocher_Requsition_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemReturnVocherUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemReturnVocher_Requsition_ID>> Handle( ItemReturnVocherUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<ItemReturnVocher_Requsition_ID> result = await _procedureAdabter
                .Execute<ItemReturnVocher_Requsition_ID>("[Inventory].Item_Return_VocherUpdate", request);
           
            return result;
        }
    }
}
 