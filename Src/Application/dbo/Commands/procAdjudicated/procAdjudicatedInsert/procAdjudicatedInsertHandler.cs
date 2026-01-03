using AutoMapper;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Interfaces;
using System.Collections.Generic;
using XOKA.Domain.Entities.dbo;


namespace Application.dbo.Commands.procAdjudicated.procAdjudicatedInsert
{
    public class procAdjudicatedInsertHandler : IRequestHandler<procAdjudicatedInsertCommand, IList<AdjudicatedCode>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public procAdjudicatedInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<AdjudicatedCode>> Handle(procAdjudicatedInsertCommand request, CancellationToken cancellationToken)
        {

            IList<AdjudicatedCode> result = await _procedureAdabter
                .Execute<AdjudicatedCode>("[dbo].proc_Plot_AdjudicatedInsert", request);


            return result;
        }
    }
}
