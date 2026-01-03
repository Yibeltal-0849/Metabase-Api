using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procAdjudicated.procAdjudicatedUpdate
{
    public class procAdjudicatedUpdateHandler : IRequestHandler<procAdjudicatedUpdateCommand, IList<AdjudicatedCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdjudicatedUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdjudicatedCode>> Handle(procAdjudicatedUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<AdjudicatedCode> result = await _procedureAdabter
                .Execute<AdjudicatedCode>("[dbo].proc_Plot_AdjudicatedUpdate", request);


            return result;
        }
    }
}
