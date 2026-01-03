using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;

namespace Application.dbo.Commands.procAdjudicated.procAdjudicatedDelete
{
    public class procAdjudicatedDeleteHandler : IRequestHandler<procAdjudicatedDeleteCommand, IList<AdjudicatedCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdjudicatedDeleteHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdjudicatedCode>> Handle(procAdjudicatedDeleteCommand request, CancellationToken cancellationToken)
        {

            IList<AdjudicatedCode> result = await _procedureAdabter
                .Execute<AdjudicatedCode>("[dbo].proc_Plot_AdjudicatedDelete", request);


            return result;
        }
    }
}
