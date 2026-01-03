using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.ProprtyData;
using XOKA.Domain.Interfaces;

namespace Application.ProprtyData.Queries.proctblDemand.GetproctblDemandLoadAll
{
    class GetproctblDemandLoadAllQueryHandler : IRequestHandler<GetproctblDemandLoadAllQuery, GetproctblDemandLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetproctblDemandLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetproctblDemandLoadAllListVm> Handle(GetproctblDemandLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<tblDemand> proctblDemands = await _procedureAdabter
               .Execute<tblDemand>("[ProprtyData].[proc_tblDemandLoadAll]");
            GetproctblDemandLoadAllListVm vm = new GetproctblDemandLoadAllListVm
            {
                proctblDemands = _mapper.Map<IList<tblDemand>, IList<GetproctblDemandLoadAllVm>>(proctblDemands)
            };

            return vm;
        }
    }
}
