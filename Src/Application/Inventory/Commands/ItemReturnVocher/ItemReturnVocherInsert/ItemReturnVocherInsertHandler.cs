



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Inventory;
using XOKA.Domain.Interfaces;


namespace Application.Inventory.Commands.ItemReturnVocher.ItemReturnVocherInsert.ItemReturnVocherInsertCommand
{

    /// @author  Shimels Alem  Item_Return_VocherInsert stored procedure.


    public class ItemReturnVocherInsertHandler : IRequestHandler<ItemReturnVocherInsertCommand, IList<ItemReturnVocher_Requsition_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public ItemReturnVocherInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ItemReturnVocher_Requsition_ID>> Handle( ItemReturnVocherInsertCommand request, CancellationToken cancellationToken)
        {

            IList<ItemReturnVocher_Requsition_ID> result = await _procedureAdabter
                .Execute<ItemReturnVocher_Requsition_ID>("[Inventory].Item_Return_VocherInsert", request);
           

            return result;
        }
    }
}
 