



using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.Bsc;


namespace Application.BSC.Commands.procBSCValues.procBSCValuesInsert.procBSCValuesInsertCommand
{

    /// @author  Shimels Alem  proc_BSC_ValuesInsert stored procedure.


    public class procBSCValuesInsertHandler : IRequestHandler<procBSCValuesInsertCommand, IList<BSCValues_BSCValueID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procBSCValuesInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<BSCValues_BSCValueID>> Handle( procBSCValuesInsertCommand request, CancellationToken cancellationToken)
        {

            IList<BSCValues_BSCValueID> result = await _procedureAdabter
                .Execute<BSCValues_BSCValueID>("[BSC].proc_BSC_ValuesInsert", request);
           

            return result;
        }
    }
}
 