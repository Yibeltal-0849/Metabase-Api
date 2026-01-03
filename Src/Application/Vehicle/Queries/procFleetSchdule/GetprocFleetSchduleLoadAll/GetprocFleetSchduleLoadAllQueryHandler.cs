using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procFleetSchdule.GetprocFleetSchduleLoadAll
{
    class GetprocFleetSchduleLoadAllQueryHandler : IRequestHandler<GetprocFleetSchduleLoadAllQuery, GetprocFleetSchduleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;

        public GetprocFleetSchduleLoadAllQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFleetSchduleLoadAllListVm> Handle(GetprocFleetSchduleLoadAllQuery request, CancellationToken cancellationToken)
        {
            IList<FleetSchdule> procFleetSchdules = await _procedureAdabter
               .Execute<FleetSchdule>("[Vehicle].[proc_Fleet_SchduleLoadAll]");
            GetprocFleetSchduleLoadAllListVm vm = new GetprocFleetSchduleLoadAllListVm
            {
                procFleetSchdules = _mapper.Map<IList<FleetSchdule>, IList<GetprocFleetSchduleLoadAllVm>>(procFleetSchdules)
            };

            return vm;
        }
    }
}
