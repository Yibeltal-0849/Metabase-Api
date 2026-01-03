



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;


namespace Application.BSC.Commands.KPIGoalMapping.KPIGoalMappingInsert.KPIGoalMappingInsertCommand
{

    /// @author  Shimels Alem  KPI_Goal_MappingInsert stored procedure.

    public class KPIGoalMappingInsertHandler : IRequestHandler<KPIGoalMappingInsertCommand, IList<KPIGoalMapping_KPIMapping_ID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public KPIGoalMappingInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<KPIGoalMapping_KPIMapping_ID>> Handle( KPIGoalMappingInsertCommand request, CancellationToken cancellationToken)
        {

            IList<KPIGoalMapping_KPIMapping_ID> result = await _procedureAdabter
                .Execute<KPIGoalMapping_KPIMapping_ID>("[BSC].KPI_Goal_MappingInsert", request);
           
            return result;
        }
    }
}
 