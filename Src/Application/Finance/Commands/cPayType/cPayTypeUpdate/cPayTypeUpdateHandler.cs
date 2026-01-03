

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;



namespace Application.Finance.Commands.cPayType.cPayTypeUpdate.cPayTypeUpdateCommand
{

    /// @author  Shimels Alem  c_PayTypeUpdate stored procedure.


    public class cPayTypeUpdateHandler : IRequestHandler<cPayTypeUpdateCommand, IList<CPayType_PayType>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayTypeUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayType_PayType>> Handle( cPayTypeUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<CPayType_PayType> result = await _procedureAdabter
                .Execute<CPayType_PayType>("[FINA].c_PayTypeUpdate", request);
           

            return result;
        }
    }
}
 