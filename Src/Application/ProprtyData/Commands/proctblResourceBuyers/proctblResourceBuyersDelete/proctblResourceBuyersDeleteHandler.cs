using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Commands.proctblResourceBuyers.proctblResourceBuyersDelete.proctblResourceBuyersDeleteCommand
{

    /// @author  Shimels Alem  proc_tblResourceBuyersDelete stored procedure.


    public class proctblResourceBuyersDeleteHandler : IRequestHandler<proctblResourceBuyersDeleteCommand, IList<tblResourceBuyers_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceBuyersDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceBuyers_id>> Handle( proctblResourceBuyersDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceBuyers_id> result = await _procedureAdabter
                .Execute<tblResourceBuyers_id>("[ProprtyData].proc_tblResourceBuyersDelete", request);
           

            return result;
        }
    }
}
  