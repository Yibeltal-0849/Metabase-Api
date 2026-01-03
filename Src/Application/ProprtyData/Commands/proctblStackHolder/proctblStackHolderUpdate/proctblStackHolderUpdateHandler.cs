

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;



namespace Application.ProprtyData.Commands.proctblStackHolder.proctblStackHolderUpdate.proctblStackHolderUpdateCommand
{

    /// @author  Shimels Alem  proc_tblStackHolderUpdate stored procedure.


    public class proctblStackHolderUpdateHandler : IRequestHandler<proctblStackHolderUpdateCommand, IList<tblStackHolder_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblStackHolderUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblStackHolder_id>> Handle( proctblStackHolderUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<tblStackHolder_id> result = await _procedureAdabter
                .Execute<tblStackHolder_id>("[ProprtyData].proc_tblStackHolderUpdate", request);
           

            return result;
        }
    }
}
 