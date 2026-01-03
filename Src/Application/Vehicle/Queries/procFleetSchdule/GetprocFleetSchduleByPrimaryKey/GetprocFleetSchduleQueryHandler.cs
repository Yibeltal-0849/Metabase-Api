using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procFleetSchdule.GetprocFleetSchduleLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procFleetSchdule.GetprocFleetSchduleByPrimaryKey
{
    public class GetprocFleetSchduleQueryHandler : IRequestHandler<GetprocFleetSchduleByPrimaryKey, GetprocFleetSchduleLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocFleetSchduleQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocFleetSchduleLoadAllListVm> Handle(GetprocFleetSchduleByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<FleetSchdule> procFleetSchdules = await _procedureAdabter
               .Execute<FleetSchdule>("[Vehicle].[proc_Fleet_SchduleLoadByPrimaryKey]", request);
            GetprocFleetSchduleLoadAllListVm vm = new GetprocFleetSchduleLoadAllListVm
            {
                procFleetSchdules = _mapper.Map<IList<FleetSchdule>, IList<GetprocFleetSchduleLoadAllVm>>(procFleetSchdules)
            };

            return vm;
        }
    }
}
