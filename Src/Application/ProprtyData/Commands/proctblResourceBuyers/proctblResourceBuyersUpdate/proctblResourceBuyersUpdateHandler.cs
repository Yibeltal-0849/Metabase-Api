

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblResourceBuyers.proctblResourceBuyersUpdate.proctblResourceBuyersUpdateCommand
{

    /// @author  Shimels Alem  proc_tblResourceBuyersUpdate stored procedure.


    public class proctblResourceBuyersUpdateHandler : IRequestHandler<proctblResourceBuyersUpdateCommand, IList<tblResourceBuyers_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceBuyersUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceBuyers_id>> Handle( proctblResourceBuyersUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceBuyers_id> result = await _procedureAdabter
                .Execute<tblResourceBuyers_id>("[ProprtyData].proc_tblResourceBuyersUpdate", request);
           

            return result;
        }
    }
}
 