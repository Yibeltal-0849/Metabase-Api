using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Application.Vehicle.Quiries.procVehicleRequst.GetprocVehicleRequstLoadAll;
using XOKA.Domain.Entities.Vehicle;
using XOKA.Domain.Interfaces;

namespace Application.Vehicle.Quiries.procVehicleRequst.GetprocVehicleRequstByPrimaryKey
{
    public class GetprocVehicleRequstQueryHandler : IRequestHandler<GetprocVehicleRequstByPrimaryKey, GetprocVehicleRequstLoadAllListVm>
    {
        readonly IMapper _mapper;
        readonly IProcedureAdabter _procedureAdabter;
        public GetprocVehicleRequstQueryHandler(IMapper mapper, IProcedureAdabter procedureAdabter)
        {
            _mapper = mapper;
            _procedureAdabter = procedureAdabter;
        }

        public async Task<GetprocVehicleRequstLoadAllListVm> Handle(GetprocVehicleRequstByPrimaryKey request, CancellationToken cancellationToken)
        {
           
            IList<VehicleRequst> procVehicleRequsts = await _procedureAdabter
               .Execute<VehicleRequst>("[Vehicle].[proc_Vehicle_RequstLoadByPrimaryKey]", request);
            GetprocVehicleRequstLoadAllListVm vm = new GetprocVehicleRequstLoadAllListVm
            {
                procVehicleRequsts = _mapper.Map<IList<VehicleRequst>, IList<GetprocVehicleRequstLoadAllVm>>(procVehicleRequsts)
            };

            return vm;
        }
    }
}
