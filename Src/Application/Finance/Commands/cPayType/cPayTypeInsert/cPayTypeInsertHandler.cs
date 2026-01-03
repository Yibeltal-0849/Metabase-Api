



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Finance;
using XOKA.Domain.Interfaces;


namespace Application.Finance.Commands.cPayType.cPayTypeInsert.cPayTypeInsertCommand
{

    /// @author  Shimels Alem  c_PayTypeInsert stored procedure.


    public class cPayTypeInsertHandler : IRequestHandler<cPayTypeInsertCommand, IList<CPayType_PayType>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public cPayTypeInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<CPayType_PayType>> Handle( cPayTypeInsertCommand request, CancellationToken cancellationToken)
        {

            IList<CPayType_PayType> result = await _procedureAdabter
                .Execute<CPayType_PayType>("[FINA].c_PayTypeInsert", request);
           

            return result;
        }
    }
}
 