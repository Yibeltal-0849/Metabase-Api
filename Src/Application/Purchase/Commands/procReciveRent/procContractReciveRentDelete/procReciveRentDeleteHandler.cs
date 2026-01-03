using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Purchase;

namespace Application.Purchase.Commands.procReciveRent.procContractReciveRentDelete.procReciveRentDeleteCommand
{
    public class procReciveRentDeleteHandler : IRequestHandler<procReciveRentDeleteCommand, IList<ReciveRentRent_Collection_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procReciveRentDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<ReciveRentRent_Collection_ID>> Handle(procReciveRentDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<ReciveRentRent_Collection_ID> result = await _procedureAdabter
                .Execute<ReciveRentRent_Collection_ID>("[Purchase].[proc_Recive_Rent_Delete]", request);


            return result;
        }
    }
}
