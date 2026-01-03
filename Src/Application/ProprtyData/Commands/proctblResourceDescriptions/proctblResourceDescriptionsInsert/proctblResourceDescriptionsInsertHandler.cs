



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;


namespace Application.ProprtyData.Commands.proctblResourceDescriptions.proctblResourceDescriptionsInsert.proctblResourceDescriptionsInsertCommand
{

    /// @author  Shimels Alem  proc_tblResourceDescriptionsInsert stored procedure.


    public class proctblResourceDescriptionsInsertHandler : IRequestHandler<proctblResourceDescriptionsInsertCommand, IList<tblResourceDescriptions_id>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public proctblResourceDescriptionsInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<tblResourceDescriptions_id>> Handle( proctblResourceDescriptionsInsertCommand request, CancellationToken cancellationToken)
        {

            IList<tblResourceDescriptions_id> result = await _procedureAdabter
                .Execute<tblResourceDescriptions_id>("[ProprtyData].proc_tblResourceDescriptionsInsert", request);
           

            return result;
        }
    }
}
 