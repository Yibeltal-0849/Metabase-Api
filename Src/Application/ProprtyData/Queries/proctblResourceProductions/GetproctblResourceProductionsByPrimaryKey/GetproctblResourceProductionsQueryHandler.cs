using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.ProprtyData.Queries.proctblResourceProductions.GetproctblResourceProductionsLoadAll;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblResourceProductions.GetproctblResourceProductionsByPrimaryKey
{
    public class GetproctblResourceProductionsQueryHandler : IRequestHandler<GetproctblResourceProductionsByPrimaryKey, GetproctblResourceProductionsLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetproctblResourceProductionsQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblResourceProductionsLoadAllListVm> Handle(GetproctblResourceProductionsByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<tblResourceProductions> proctblResourceProductionss = await _procedureAdabter
               .Execute<tblResourceProductions>("[ProprtyData].[proc_tblResourceProductionsLoadByPrimaryKey]", request);
            GetproctblResourceProductionsLoadAllListVm vm = new GetproctblResourceProductionsLoadAllListVm
            {
                proctblResourceProductionss = _mapper.Map<IList<tblResourceProductions>, IList<GetproctblResourceProductionsLoadAllVm>>(proctblResourceProductionss)
            };

            return vm;
        }
    }
}
