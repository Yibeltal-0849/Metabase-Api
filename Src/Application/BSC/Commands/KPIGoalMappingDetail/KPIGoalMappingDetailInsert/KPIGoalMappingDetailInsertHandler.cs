



using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;


namespace Application.BSC.Commands.KPIGoalMappingDetail.KPIGoalMappingDetailInsert.KPIGoalMappingDetailInsertCommand
{

    /// @author  Shimels Alem  KPI_Goal_Mapping_DetailInsert stored procedure.


    public class KPIGoalMappingDetailInsertHandler : IRequestHandler<KPIGoalMappingDetailInsertCommand, IList<KPIGoalMappingDetail_Mapping_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public KPIGoalMappingDetailInsertHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<KPIGoalMappingDetail_Mapping_DetailID>> Handle( KPIGoalMappingDetailInsertCommand request, CancellationToken cancellationToken)
        {

            IList<KPIGoalMappingDetail_Mapping_DetailID> result = await _procedureAdabter
                .Execute<KPIGoalMappingDetail_Mapping_DetailID>("[BSC].KPI_Goal_Mapping_DetailInsert", request);
          
            return result;
        }
    }
}
 