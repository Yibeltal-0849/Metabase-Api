

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.procProportyAndPostion.procProportyAndPostionUpdate.procProportyAndPostionUpdateCommand
{

    /// @author  Shimels Alem  proc_Rent_CollectionUpdate stored procedure.


    public class procProportyAndPostionUpdateHandler : IRequestHandler<procProportyAndPostionUpdateCommand, IList<Proporty_And_PostionID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procProportyAndPostionUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<Proporty_And_PostionID>> Handle(procProportyAndPostionUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<Proporty_And_PostionID> result = await _procedureAdabter
                .Execute<Proporty_And_PostionID>("[ProprtyData].[proc_Proporty_And_PostionUpdate]", request);
           

            return result;
        }
    }
}
 