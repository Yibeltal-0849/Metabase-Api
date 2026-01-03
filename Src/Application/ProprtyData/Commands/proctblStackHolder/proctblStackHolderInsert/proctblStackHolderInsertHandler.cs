



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblStackHolder.proctblStackHolderInsert.proctblStackHolderInsertCommand
{

    /// @author  Shimels Alem  proc_tblStackHolderInsert stored procedure.


    public class proctblStackHolderInsertHandler : IRequestHandler<proctblStackHolderInsertCommand, IList<tblStackHolder_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblStackHolderInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblStackHolder_id>> Handle( proctblStackHolderInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblStackHolder_id> result = await _procedureAdabter
                .Execute<tblStackHolder_id>("[ProprtyData].proc_tblStackHolderInsert", request);
           

            return result;
        }
    }
}
 