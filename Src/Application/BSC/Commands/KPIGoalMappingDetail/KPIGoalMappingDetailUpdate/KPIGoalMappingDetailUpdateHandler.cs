

using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Bsc;
using XOKA.Domain.Interfaces;



namespace Application.BSC.Commands.KPIGoalMappingDetail.KPIGoalMappingDetailUpdate.KPIGoalMappingDetailUpdateCommand
{

    /// @author  Shimels Alem  KPI_Goal_Mapping_DetailUpdate stored procedure.


    public class KPIGoalMappingDetailUpdateHandler : IRequestHandler<KPIGoalMappingDetailUpdateCommand, IList<KPIGoalMappingDetail_Mapping_DetailID>>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public KPIGoalMappingDetailUpdateHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<IList<KPIGoalMappingDetail_Mapping_DetailID>> Handle( KPIGoalMappingDetailUpdateCommand request, CancellationToken cancellationToken)
        {

            IList<KPIGoalMappingDetail_Mapping_DetailID> result = await _procedureAdabter
                .Execute<KPIGoalMappingDetail_Mapping_DetailID>("[BSC].KPI_Goal_Mapping_DetailUpdate", request);
           
            return result;
        }
    }
}
 